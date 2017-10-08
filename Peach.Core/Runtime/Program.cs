
//
// Copyright (c) Michael Eddington
//
// Permission is hereby granted, free of charge, to any person obtaining a copy 
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights 
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell 
// copies of the Software, and to permit persons to whom the Software is 
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in	
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR 
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE 
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
//

// Authors:
//   Michael Eddington (mike@dejavusecurity.com)

// $Id$

using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.IO;
using System.Xml;

using Peach.Core.Dom;
using Peach.Core;
using Peach.Core.Agent;
using Peach.Core.Analyzers;

using SharpPcap;
using NLog;
using NLog.Targets;
using NLog.Config;
using System.Threading;

namespace Peach.Core.Runtime

{
    /// <summary>
    /// Command line interface for Peach 3.  Mostly backwards compatable with
    /// Peach 2.3.
    /// </summary>
    public class Program
    {
        // PUT THIS INTO YOUR PROGRAM
        ////public static int Run(string[] args)
        ////{
        ////    Peach.Core.AssertWriter.Register();

        ////    return new Program(args).exitCode;
        ////}

        public static ConsoleColor DefaultForground = Console.ForegroundColor;

        /// <summary>
        /// Configure NLog.
        /// </summary>
        /// <remarks>
        /// Level &lt; 0 --&gt; Clear Config
        /// Level = 0 --&gt; Do nothing
        /// Level = 1 --&gt; Debug
        /// Leven &gt; 1 --&gt; Trace
        /// </remarks>
        /// <param name="level"></param>
        public static void ConfigureLogging(int level)
        {
            if (level < 0)
            {
                // Need to reset configuration to null for NLog 2.0 on mono
                // so we don't hang on exit.
                LogManager.Configuration = null;
                return;
            }

            if (level == 0)
                return;

            if (LogManager.Configuration != null && LogManager.Configuration.LoggingRules.Count > 0)
            {
                Console.WriteLine("Logging was configured by a .config file, not changing the configuration.");
                return;
            }

            var nconfig = new LoggingConfiguration();
            var consoleTarget = new ConsoleTarget();
            nconfig.AddTarget("console", consoleTarget);
            consoleTarget.Layout = "${logger} ${message}";

            var rule = new LoggingRule("*", level == 1 ? LogLevel.Debug : LogLevel.Trace, consoleTarget);
            nconfig.LoggingRules.Add(rule);

            LogManager.Configuration = nconfig;
        }

        public Dictionary<string, string> DefinedValues = new Dictionary<string, string>();
        public Peach.Core.Dom.Dom dom;

        public int exitCode = 1;

        protected RunConfiguration config = null;

        /// <summary>
        /// Copyright message
        /// </summary>
        public virtual string Copyright
        {
            get { return "Copyright (c) Michael Eddington"; }
        }

        /// <summary>
        /// Product name
        /// </summary>
        public virtual string ProductName
        {
            get { return "Peach v" + Assembly.GetExecutingAssembly().GetName().Version; }
        }

        /// <summary>
        /// 可重写此函数来输出64位和32位不匹配的错误.
        /// </summary>
        public virtual bool ErrorOnArchitecture { get { return true; } }

        public Program(string[] args)
        {
            AppDomain.CurrentDomain.DomainUnload += new EventHandler(CurrentDomain_DomainUnload);
            Console.CancelKeyPress += new ConsoleCancelEventHandler(Console_CancelKeyPress);
            config = new RunConfiguration();
            config.debug = 0;

            try
            {
                string analyzer = null;
                bool test = false;
                string agent = null;
                var definedValues = new List<string>();
                bool parseOnly = false;

                var color = Console.ForegroundColor;
                Console.Write("\n");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("[[ ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(ProductName);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("[[ ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(Copyright);
                Console.ForegroundColor = color;

                if (args.Length == 0)
                    Syntax();

                var p = new OptionSet()
				{
					{ "h|?|help", v => Syntax() },
					{ "analyzer=", v => analyzer = v },
					{ "debug", v => config.debug = 1 },
					{ "trace", v => config.debug = 2 },
					{ "1", v => config.singleIteration = true},
					{ "range=", v => ParseRange(config, v)},
					{ "t|test", v => test = true},
					{ "c|count", v => config.countOnly = true},
					{ "skipto=", v => config.skipToIteration = Convert.ToUInt32(v)},
					{ "seed=", v => config.randomSeed = Convert.ToUInt32(v)},
					{ "p|parallel=", v => ParseParallel(config, v)},
					{ "a|agent=", v => agent = v},
					{ "D|define=", v => AddNewDefine(v) },
					{ "definedvalues=", v => definedValues.Add(v) },
					{ "config=", v => definedValues.Add(v) },
					{ "parseonly", v => parseOnly = true },
					{ "bob", var => bob() },//输出他的头像，醉了
					{ "charlie", var => Charlie() },//醉了
					{ "showdevices", var => ShowDevices() },//列出网卡设备信息
					{ "showenv", var => ShowEnvironment() },//输出使用信息？基本属性的使用？
					{ "makexsd", var => MakeSchema() },//生成Peach.xsd文件
				};

                List<string> extra = p.Parse(args);//extra[0]存放文件名即 pit文件.xml 

                if (extra.Count == 0 && agent == null && analyzer == null)
                    Syntax();

                Platform.LoadAssembly();

                AddNewDefine("Peach.Cwd=" + Environment.CurrentDirectory);
                AddNewDefine("Peach.Pwd=" + Path.GetDirectoryName(Assembly.GetCallingAssembly().Location));

                // 判断是否有 pit文件.xml.config 文件，如果有我们就加载改文件
                // 注意：pit文件.xml.config 应该和 pit文件.xml文件放在同一目录下
                if (extra.Count > 0 && File.Exists(extra[0]) &&
                    extra[0].ToLower().EndsWith(".xml") &&
                    File.Exists(extra[0] + ".config"))
                {
                    definedValues.Insert(0, extra[0] + ".config");
                }

                foreach (var definedValuesFile in definedValues)
                {
                    var defs = PitParser.parseDefines(definedValuesFile);

                    foreach (var kv in defs)
                    {
                        // Allow command line to override values in XML file.
                        if (!DefinedValues.ContainsKey(kv.Key))
                            DefinedValues.Add(kv.Key, kv.Value);
                    }
                }

                // 如果需要则启动调试
                // 如果已经由.congig文件进行配置，则不会做任何更改
                ConfigureLogging(config.debug);

                if (agent != null)
                {
                    var agentType = ClassLoader.FindTypeByAttribute<AgentServerAttribute>((x, y) => y.name == agent);
                    if (agentType == null)
                    {
                        Console.WriteLine("错误, unable to locate agent server for protocol '" + agent + "'.\n");
                        return;
                    }

                    var agentServer = Activator.CreateInstance(agentType) as IAgentServer;

                    ConsoleWatcher.WriteInfoMark();
                    Console.WriteLine("启动代理服务...");

                    agentServer.Run(new Dictionary<string, string>());
                    return;
                }

                if (analyzer != null)
                {
                    var analyzerType = ClassLoader.FindTypeByAttribute<AnalyzerAttribute>((x, y) => y.Name == analyzer);
                    if (analyzerType == null)
                    {
                        Console.WriteLine("错误，无法定位名为'" + analyzer + "'的analyzer.\n");
                        return;
                    }

                    var field = analyzerType.GetField("supportCommandLine",
                        BindingFlags.Static | BindingFlags.Public | BindingFlags.FlattenHierarchy);
                    if ((bool)field.GetValue(null) == false)
                    {
                        Console.WriteLine("错误, 从命令行启动的analyzer还没有进行配置.");
                        return;
                    }

                    var analyzerInstance = Activator.CreateInstance(analyzerType) as Analyzer;

                    ConsoleWatcher.WriteInfoMark();
                    Console.WriteLine("启动Analyzer...");

                    analyzerInstance.asCommandLine(new Dictionary<string, string>());
                    return;
                }

                Dictionary<string, object> parserArgs = new Dictionary<string, object>();
                parserArgs[PitParser.DEFINED_VALUES] = this.DefinedValues;

                if (test)
                {
                    ConsoleWatcher.WriteInfoMark();
                    Console.Write("Validating file [" + extra[0] + "]... ");
                    Analyzer.defaultParser.asParserValidation(parserArgs, extra[0]);

                    if (Type.GetType("Mono.Runtime") != null)
                        Console.WriteLine("File parsed successfully, but XSD validation is not supported on the Mono runtime.");
                    else
                        Console.WriteLine("No Errors Found.");

                    return;
                }

                Engine e = new Engine(GetUIWatcher());
                dom = GetParser(e).asParser(parserArgs, extra[0]);
                config.pitFile = extra[0];

                // 用于单元测试
                if (parseOnly)
                    return;

                foreach (string arg in args)
                    config.commandLine += arg + " ";

                if (extra.Count > 1)
                    config.runName = extra[1];

                e.startFuzzing(dom, config);

                exitCode = 0;
            }
            catch (SyntaxException)
            {
                // 由syntax()抛出，可忽略
            }
            catch (OptionException oe)
            {
                Console.WriteLine(oe.Message + "\n");
            }
            catch (PeachException ee)
            {
                if (config.debug > 0)
                    Console.WriteLine(ee);
                else
                    Console.WriteLine(ee.Message + "\n");
            }
            finally
            {
                // HACK - 需使用NLog 2.0的Mono
                ConfigureLogging(-1);

                // 重置控制台输出文字的颜色
                Console.ForegroundColor = DefaultForground;
            }
        }

        protected static void CurrentDomain_DomainUnload(object sender, EventArgs e)
        {
            Console.ForegroundColor = DefaultForground;
        }

        /// <summary>
        /// 可通过重写此方法，增加自定义选项
        /// </summary>
        /// <param name="options"></param>
        protected virtual void AddCustomOptions(OptionSet options)
        {
        }

        /// <summary>
        /// 可通过重写此方法，更改输出程序使用的语法信息
        /// </summary>
        protected virtual void Syntax()
        {
            string syntax = @"Peach程序模糊测试流程：首先产生随机数种子，然后由该种子进行迭代。

    这是Peach的运行环境，这个运行环境有多种使用Peach xml文件的方法。当下，该运行环境仍处于开发阶段，但是在诸如简单的模糊测试和带有行为参数的Peach xml文件测试中它已能够显露一些能力。请将任何bug提交到 https://forums.peachfuzzer.com.

主要语法格式:

  peach -a channel										
  peach -c peach_xml_file [test_name] 					
  peach [--skipto #] peach_xml_flie [test_name] 
  peach -p 10,2 [--skipto #] peach_xml_file [test_name]
  peach --range 100,200 peach_xml_file [test_name]
  peach -t peach_xml_file

参数解释:

  -1                         仅进行一次迭代（注意：数字只能为1）
  -a,--agent                 加载一个代理
  -c,--count                 测试时带计数，需要有确定性突变时才能使用。
  -t,--test xml_file         验证一个XML文件是否有效（语法正确性和需要的必要文件）
  -p,--parallel M,N          并行运行模糊测试，M表示总共有M台，N表示本机是第N台
  --debug                    开启debug信息显示，当debug你的xml文件时这将会很有用。
                             警告：现实的信息有时会很模糊不清晰。
  --trace                    显示额外的的debug信息，会显示很多执行调用。
                             这样会使运行速度很慢（自动开启debug显示）
  --seed N                   设置一个用于随机数生成器的种子数字
  --parseonly                从语法上分析一个XML文件的正确性
  --makexsd                  生成Peach.xsd文件
  --showenv                  显示所有的DataElements, Fixups, Monito, Publisher 及其相关的参数.
  --showdevices              展示PCAP设备的列表
  --analyzer                 加载Peach分析器？？
  --skipto N                 跳转到一个特殊测试 #.  这代替了用于重启Peach测试的-r参数的命令
  --range N,M                提供一个范围使测试在该范围内进行迭代行为
  -D/define=KEY=VALUE        定义一个替代量，在你的PIT中你能 ##KEY## ，然后他就会被这个替代量替换
  --config=FILENAME          XML 文件包含定义的量

命令详解：

    1.Peach 代理

      语法: peach -a channel
      在当前机器上启动一个Peach代理的实例，用户必须提供通道或者协议的名字(例如：tcp).
      注意: 本地代理将自动地启动。

    2.执行模糊测试

      语法: peach peach_xml_flie [test_name]
      语法: peach --skipto 1234 peach_xml_flie [test_name]
      语法: peach --range 100,200 peach_xml_flie [test_name]

      一个模糊测试的执行开始于一个特殊的Peach XML文件 和 该文件中测试的名字。
      如果一个测试被某些未知原因打断，你可以通过使用--skipto 参数的命令来重启测试。但是你必须在参数后面提供 测试#来说明从何处启动
      另外，一系列的测试案例可以通过 --range 参数来指定。

  
    3.并行执行一个模糊测试

      语法: peach -p 10,2 peach_xml_flie [test_name]

      一个使用多台机器执行相同模糊的并行模糊测试，这将能缩短测试所需求的时间。想要以并行方式运行，我们必须知道机器的总数和这台机器是第几台。
      这些信息通过 -p 参数来指定，其格式为 总数,本机器编号。

    4.验证 Peach XML 文件

      语法: peach -t peach_xml_file

      这样做会对一个Peach XML文件进行语法分析而且会显示任何发现的错误。

    5.Debug Peach XML 文件

      语法: peach -1 --debug peach_xml_file

      这将进行一次迭代并在此过程中显示一些debug信息，这些debug信息的初衷是用于开发工作，但它同样有用于pit debug。
";
            Console.WriteLine(syntax);
            throw new SyntaxException();
        }

        protected void bob()
        {
            string bob = @"
@@@@@@@^^~~~~~~~~~~~~~~~~~~~~^@@@@@@@@@
@@@@@@^     ~^  @  @@ @ @ @ I  ~^@@@@@@
@@@@@            ~ ~~ ~I          @@@@@
@@@@'                  '  _,w@<    @@@@
@@@@     @@@@@@@@w___,w@@@@@@@@  @  @@@
@@@@     @@@@@@@@@@@@@@@@@@@@@@  I  @@@
@@@@     @@@@@@@@@@@@@@@@@@@@*@[ i  @@@
@@@@     @@@@@@@@@@@@@@@@@@@@[][ | ]@@@
@@@@     ~_,,_ ~@@@@@@@~ ____~ @    @@@
@@@@    _~ ,  ,  `@@@~  _  _`@ ]L  J@@@
@@@@  , @@w@ww+   @@@ww``,,@w@ ][  @@@@
@@@@,  @@@@www@@@ @@@@@@@ww@@@@@[  @@@@
@@@@@_|| @@@@@@P' @@P@@@@@@@@@@@[|c@@@@
@@@@@@w| '@@P~  P]@@@-~, ~Y@@^'],@@@@@@
@@@@@@@[   _        _J@@Tk     ]]@@@@@@
@@@@@@@@,@ @@, c,,,,,,,y ,w@@[ ,@@@@@@@
@@@@@@@@@ i @w   ====--_@@@@@  @@@@@@@@
@@@@@@@@@@`,P~ _ ~^^^^Y@@@@@  @@@@@@@@@
@@@@^^=^@@^   ^' ,ww,w@@@@@ _@@@@@@@@@@
@@@_xJ~ ~   ,    @@@@@@@P~_@@@@@@@@@@@@
@@   @,   ,@@@,_____   _,J@@@@@@@@@@@@@
@@L  `' ,@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
";
            Console.WriteLine(bob);
            throw new SyntaxException();
        }


        protected void Charlie()
        {
            Console.WriteLine(@"
,-----.   
\======'.                                                                 
 \  {}   '.                                                               
  \   \/ V '.                                                             
   \  || |   '._                                 _,cmmmnc,_               
    \___68FS___\'-._=----+- _______________,.-=:3H)###C--  `c._           
    :|=--------------`---" + "\"" + @"'`.   `  `.   `.   `,   `~\" + "\"\"" + @"===" + "\"" + @"~`    `'-.___   
  ,dH] '       =(*)=         :       ---==;=--;  .   ;    +-- -_ .-`      
  :HH]_:______________  ____,.........__     _____,.----=-" + "\"" + @"~ `            
  ;:" + "\"" + @"+" + "\"" + @"\" + "\"" + @"+@" + "\"" + @"" + "\"" + @"+" + "\"" + @"\" + "\"" + @"" + "\"" + @"+@" + "\"" + @"'" + "\"" + @"+" + "\"" + @"\" + "\"" + @"+@" + "\"" + @"'----._.------\`  :          .   `.'`'" + "\"" + @"'" + "\"" + @"'" + "\"" + @"P
  |:      .-'==-.__)___\. :        .   .'`___L~___(                       
  |:  _.'`       '|   / \.:      .  .-`" + "\"" + @"" + "\"" + @"`                                
  `'" + "\"" + @"'            `--'   \:    ._.-'                                      
                         }_`============>-             
");
            throw new SyntaxException();
        }

        protected void ParseRange(RunConfiguration config, string v)
        {
            string[] parts = v.Split(',');
            if (parts.Length != 2)
                throw new PeachException("Invalid range: " + v);

            try
            {
                config.rangeStart = Convert.ToUInt32(parts[0]);
            }
            catch (Exception ex)
            {
                throw new PeachException("Invalid range start iteration: " + parts[0], ex);
            }

            try
            {
                config.rangeStop = Convert.ToUInt32(parts[1]);
            }
            catch (Exception ex)
            {
                throw new PeachException("Invalid range stop iteration: " + parts[1], ex);
            }

            if (config.parallel)
                throw new PeachException("--parallel参数指定时不支持--range参数");

            config.range = true;
        }

        protected void ParseParallel(RunConfiguration config, string v)
        {
            string[] parts = v.Split(',');
            if (parts.Length != 2)
                throw new PeachException("Invalid parallel value: " + v);

            try
            {
                config.parallelTotal = Convert.ToUInt32(parts[0]);

                if (config.parallelTotal == 0)
                    throw new ArgumentOutOfRangeException();
            }
            catch (Exception ex)
            {
                throw new PeachException("Invalid parallel machine total: " + parts[0], ex);
            }

            try
            {
                config.parallelNum = Convert.ToUInt32(parts[1]);
                if (config.parallelNum == 0 || config.parallelNum > config.parallelTotal)
                    throw new ArgumentOutOfRangeException();
            }
            catch (Exception ex)
            {
                throw new PeachException("Invalid parallel machine number: " + parts[1], ex);
            }

            if (config.range)
                throw new PeachException("--range参数指定时不支持--parallel参数");

            config.parallel = true;
        }

        protected static void Console_CancelKeyPress(object sender, ConsoleCancelEventArgs e)
        {
            Console.WriteLine();
            Console.WriteLine(" --- Ctrl+C Detected --- ");

            e.Cancel = true;

            // 需从此事件处理器外部调用Environment.Exit()来确保finalizer被调用...
            // http://www.codeproject.com/Articles/16164/Managed-Application-Shutdown
            new Thread(delegate()
            {
                Environment.Exit(0);
            }).Start();
        }

        public void AddNewDefine(string value)
        {
            if (value.IndexOf("=") < 0)
                throw new PeachException("Error, defined values supplied via -D/--define must have an equals sign providing a key-pair set.");

            var kv = value.Split('=');
            DefinedValues[kv[0]] = kv[1];
        }

        public void ShowDevices()
        {
            Console.WriteLine();
            Console.WriteLine("在本机，有以下设备可用:");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();

            int i = 0;

            var devices = CaptureDeviceList.Instance;

            // 输出所有的可用设备
            foreach (ICaptureDevice dev in devices)
            {
                Console.WriteLine("名字: {0}\n描述: {1}\n\n", dev.Name, dev.Description);
                i++;
            }

            throw new SyntaxException();
        }

        public void ShowEnvironment()
        {
            Peach.Core.Usage.Print();
            throw new SyntaxException();
        }

        /// <summary>
        /// 创建peach.xsd文件
        /// </summary>
        public void MakeSchema()
        {
            try
            {
                Console.WriteLine();

                using (var stream = new FileStream("peach.xsd", FileMode.Create, FileAccess.Write))
                {
                    Xsd.SchemaBuilder.Generate(typeof(Xsd.Dom), stream);

                    Console.WriteLine("成功的创建了文件：{0}", stream.Name);
                }

                throw new SyntaxException();
            }
            catch (UnauthorizedAccessException ex)
            {
                throw new PeachException("Error creating schema. {0}".Fmt(ex.Message), ex);
            }

        }

        protected virtual Watcher GetUIWatcher()
        {
            return new ConsoleWatcher();
        }

        protected virtual Analyzer GetParser(Engine engine)
        {
            return Analyzer.defaultParser;
        }
    }


    public class SyntaxException : Exception
    {
    }
}

// end
