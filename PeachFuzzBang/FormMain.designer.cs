namespace PeachFuzzBang
{
	partial class FormMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageIntroduction = new System.Windows.Forms.TabPage();
            this.richTextBoxIntroduction = new System.Windows.Forms.RichTextBox();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.label20 = new System.Windows.Forms.Label();
            this.buttonLogPathBrowse = new System.Windows.Forms.Button();
            this.textBoxLogPath = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonPitFileNameLoad = new System.Windows.Forms.Button();
            this.comboBoxPitDataModel = new System.Windows.Forms.ComboBox();
            this.buttonPitFileNameBrowse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPitFileName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxFuzzingStrategy = new System.Windows.Forms.ComboBox();
            this.textBoxIterations = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonBrowseFuzzedFile = new System.Windows.Forms.Button();
            this.buttonBrowseTemplates = new System.Windows.Forms.Button();
            this.textBoxFuzzedFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTemplateFiles = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageDebuggerWin = new System.Windows.Forms.TabPage();
            this.checkBoxCpuKill = new System.Windows.Forms.CheckBox();
            this.buttonDebuggerPathBrowse = new System.Windows.Forms.Button();
            this.textBoxDebuggerPath = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonDebuggerCommandBrowse = new System.Windows.Forms.Button();
            this.textBoxDebuggerCommandLine = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxKernelConnectionString = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxAttachToServiceServices = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxAttachToProcessProcessName = new System.Windows.Forms.ComboBox();
            this.textBoxAttachToProcessPID = new System.Windows.Forms.TextBox();
            this.radioButtonAttachToProcessProcessName = new System.Windows.Forms.RadioButton();
            this.radioButtonAttachToProcessPID = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonDebuggerAttachToProcess = new System.Windows.Forms.RadioButton();
            this.radioButtonDebuggerKernelDebugger = new System.Windows.Forms.RadioButton();
            this.radioButtonDebuggerAttachToService = new System.Windows.Forms.RadioButton();
            this.radioButtonDebuggerStartProcess = new System.Windows.Forms.RadioButton();
            this.tabPageDebuggerOSX = new System.Windows.Forms.TabPage();
            this.richTextBoxOSX = new System.Windows.Forms.RichTextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.textBoxOSXArguments = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.checkBoxOSXCpuKill = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxOSXExecutable = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.textBoxOSXCrashWrangler = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.radioButtonOSXCrashWrangler = new System.Windows.Forms.RadioButton();
            this.radioButtonOSXCrashReporter = new System.Windows.Forms.RadioButton();
            this.tabPageDebuggerLinux = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label29 = new System.Windows.Forms.Label();
            this.textBoxLinuxArguments = new System.Windows.Forms.TextBox();
            this.checkBoxLinuxCpuKill = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxLinuxExecutable = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.richTextBoxLinux = new System.Windows.Forms.RichTextBox();
            this.tabPageGUI = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.textBoxWindowTitle4 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textBoxWindowTitle3 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBoxWindowTitle2 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.checkBoxEnableWmClose = new System.Windows.Forms.CheckBox();
            this.textBoxWindowTitle1 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPageFuzzing = new System.Windows.Forms.TabPage();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPageOutput = new System.Windows.Forms.TabPage();
            this.textBoxIterationCount = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxFaultCount = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.progressBarOuputFuzzing = new System.Windows.Forms.ProgressBar();
            this.tabPageAbout = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonStopFuzzing = new System.Windows.Forms.Button();
            this.buttonSaveConfiguration = new System.Windows.Forms.Button();
            this.buttonStartFuzzing = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPageIntroduction.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPageDebuggerWin.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageDebuggerOSX.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tabPageDebuggerLinux.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.tabPageGUI.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tabPageFuzzing.SuspendLayout();
            this.tabPageOutput.SuspendLayout();
            this.tabPageAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageIntroduction);
            this.tabControl.Controls.Add(this.tabPageGeneral);
            this.tabControl.Controls.Add(this.tabPageDebuggerWin);
            this.tabControl.Controls.Add(this.tabPageDebuggerOSX);
            this.tabControl.Controls.Add(this.tabPageDebuggerLinux);
            this.tabControl.Controls.Add(this.tabPageGUI);
            this.tabControl.Controls.Add(this.tabPageFuzzing);
            this.tabControl.Controls.Add(this.tabPageOutput);
            this.tabControl.Controls.Add(this.tabPageAbout);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(553, 424);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageIntroduction
            // 
            this.tabPageIntroduction.Controls.Add(this.richTextBoxIntroduction);
            this.tabPageIntroduction.Location = new System.Drawing.Point(4, 22);
            this.tabPageIntroduction.Name = "tabPageIntroduction";
            this.tabPageIntroduction.Size = new System.Drawing.Size(545, 398);
            this.tabPageIntroduction.TabIndex = 6;
            this.tabPageIntroduction.Text = "介绍";
            this.tabPageIntroduction.UseVisualStyleBackColor = true;
            // 
            // richTextBoxIntroduction
            // 
            this.richTextBoxIntroduction.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxIntroduction.Name = "richTextBoxIntroduction";
            this.richTextBoxIntroduction.ReadOnly = true;
            this.richTextBoxIntroduction.Size = new System.Drawing.Size(539, 345);
            this.richTextBoxIntroduction.TabIndex = 0;
            this.richTextBoxIntroduction.Text = resources.GetString("richTextBoxIntroduction.Text");
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.Controls.Add(this.label20);
            this.tabPageGeneral.Controls.Add(this.buttonLogPathBrowse);
            this.tabPageGeneral.Controls.Add(this.textBoxLogPath);
            this.tabPageGeneral.Controls.Add(this.label17);
            this.tabPageGeneral.Controls.Add(this.groupBox6);
            this.tabPageGeneral.Controls.Add(this.label13);
            this.tabPageGeneral.Controls.Add(this.comboBoxFuzzingStrategy);
            this.tabPageGeneral.Controls.Add(this.textBoxIterations);
            this.tabPageGeneral.Controls.Add(this.label7);
            this.tabPageGeneral.Controls.Add(this.buttonBrowseFuzzedFile);
            this.tabPageGeneral.Controls.Add(this.buttonBrowseTemplates);
            this.tabPageGeneral.Controls.Add(this.textBoxFuzzedFile);
            this.tabPageGeneral.Controls.Add(this.label2);
            this.tabPageGeneral.Controls.Add(this.textBoxTemplateFiles);
            this.tabPageGeneral.Controls.Add(this.label1);
            this.tabPageGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGeneral.Size = new System.Drawing.Size(545, 398);
            this.tabPageGeneral.TabIndex = 0;
            this.tabPageGeneral.Text = "常规";
            this.tabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(220, 125);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(161, 12);
            this.label20.TabIndex = 20;
            this.label20.Text = "（无限制迭代次数请输入0.）";
            // 
            // buttonLogPathBrowse
            // 
            this.buttonLogPathBrowse.Location = new System.Drawing.Point(414, 98);
            this.buttonLogPathBrowse.Name = "buttonLogPathBrowse";
            this.buttonLogPathBrowse.Size = new System.Drawing.Size(75, 21);
            this.buttonLogPathBrowse.TabIndex = 19;
            this.buttonLogPathBrowse.Text = "浏览";
            this.buttonLogPathBrowse.UseVisualStyleBackColor = true;
            this.buttonLogPathBrowse.Click += new System.EventHandler(this.buttonLogPathBrowse_Click);
            // 
            // textBoxLogPath
            // 
            this.textBoxLogPath.Location = new System.Drawing.Point(115, 97);
            this.textBoxLogPath.Name = "textBoxLogPath";
            this.textBoxLogPath.Size = new System.Drawing.Size(293, 21);
            this.textBoxLogPath.TabIndex = 18;
            this.textBoxLogPath.Text = "Logs";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(53, 100);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 12);
            this.label17.TabIndex = 17;
            this.label17.Text = "日志路径:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.buttonPitFileNameLoad);
            this.groupBox6.Controls.Add(this.comboBoxPitDataModel);
            this.groupBox6.Controls.Add(this.buttonPitFileNameBrowse);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.textBoxPitFileName);
            this.groupBox6.Location = new System.Drawing.Point(8, 180);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(529, 164);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Peach Pit (选项)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(395, 36);
            this.label16.TabIndex = 21;
            this.label16.Text = "      选择现有的PIT文件然后加载. 加载完成后选择一个使用的数据模型\r\n\r\n你选择的数据模型将用于模糊测试.\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "数据模型:";
            // 
            // buttonPitFileNameLoad
            // 
            this.buttonPitFileNameLoad.Location = new System.Drawing.Point(433, 96);
            this.buttonPitFileNameLoad.Name = "buttonPitFileNameLoad";
            this.buttonPitFileNameLoad.Size = new System.Drawing.Size(75, 21);
            this.buttonPitFileNameLoad.TabIndex = 20;
            this.buttonPitFileNameLoad.Text = "加载";
            this.buttonPitFileNameLoad.UseVisualStyleBackColor = true;
            this.buttonPitFileNameLoad.Click += new System.EventHandler(this.buttonPitFileNameLoad_Click);
            // 
            // comboBoxPitDataModel
            // 
            this.comboBoxPitDataModel.FormattingEnabled = true;
            this.comboBoxPitDataModel.Location = new System.Drawing.Point(107, 124);
            this.comboBoxPitDataModel.Name = "comboBoxPitDataModel";
            this.comboBoxPitDataModel.Size = new System.Drawing.Size(239, 20);
            this.comboBoxPitDataModel.TabIndex = 17;
            // 
            // buttonPitFileNameBrowse
            // 
            this.buttonPitFileNameBrowse.Location = new System.Drawing.Point(352, 97);
            this.buttonPitFileNameBrowse.Name = "buttonPitFileNameBrowse";
            this.buttonPitFileNameBrowse.Size = new System.Drawing.Size(75, 21);
            this.buttonPitFileNameBrowse.TabIndex = 19;
            this.buttonPitFileNameBrowse.Text = "浏览";
            this.buttonPitFileNameBrowse.UseVisualStyleBackColor = true;
            this.buttonPitFileNameBrowse.Click += new System.EventHandler(this.buttonPitFileNameBrowse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "Pit文件:";
            // 
            // textBoxPitFileName
            // 
            this.textBoxPitFileName.Location = new System.Drawing.Point(107, 99);
            this.textBoxPitFileName.Name = "textBoxPitFileName";
            this.textBoxPitFileName.Size = new System.Drawing.Size(239, 21);
            this.textBoxPitFileName.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(53, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 12);
            this.label13.TabIndex = 15;
            this.label13.Text = "模糊策略:";
            // 
            // comboBoxFuzzingStrategy
            // 
            this.comboBoxFuzzingStrategy.FormattingEnabled = true;
            this.comboBoxFuzzingStrategy.Items.AddRange(new object[] {
            "Sequential Strategy",
            "Random Strategy"});
            this.comboBoxFuzzingStrategy.Location = new System.Drawing.Point(115, 72);
            this.comboBoxFuzzingStrategy.Name = "comboBoxFuzzingStrategy";
            this.comboBoxFuzzingStrategy.Size = new System.Drawing.Size(293, 20);
            this.comboBoxFuzzingStrategy.TabIndex = 14;
            this.comboBoxFuzzingStrategy.Text = "Random Strategy";
            // 
            // textBoxIterations
            // 
            this.textBoxIterations.Location = new System.Drawing.Point(115, 121);
            this.textBoxIterations.Name = "textBoxIterations";
            this.textBoxIterations.Size = new System.Drawing.Size(100, 21);
            this.textBoxIterations.TabIndex = 13;
            this.textBoxIterations.Text = "25";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "迭代次数:";
            // 
            // buttonBrowseFuzzedFile
            // 
            this.buttonBrowseFuzzedFile.Location = new System.Drawing.Point(414, 50);
            this.buttonBrowseFuzzedFile.Name = "buttonBrowseFuzzedFile";
            this.buttonBrowseFuzzedFile.Size = new System.Drawing.Size(75, 21);
            this.buttonBrowseFuzzedFile.TabIndex = 8;
            this.buttonBrowseFuzzedFile.Text = "浏览";
            this.buttonBrowseFuzzedFile.UseVisualStyleBackColor = true;
            this.buttonBrowseFuzzedFile.Click += new System.EventHandler(this.buttonBrowseFuzzedFile_Click);
            // 
            // buttonBrowseTemplates
            // 
            this.buttonBrowseTemplates.Location = new System.Drawing.Point(414, 23);
            this.buttonBrowseTemplates.Name = "buttonBrowseTemplates";
            this.buttonBrowseTemplates.Size = new System.Drawing.Size(75, 21);
            this.buttonBrowseTemplates.TabIndex = 7;
            this.buttonBrowseTemplates.Text = "浏览";
            this.buttonBrowseTemplates.UseVisualStyleBackColor = true;
            this.buttonBrowseTemplates.Click += new System.EventHandler(this.buttonBrowseTemplates_Click);
            // 
            // textBoxFuzzedFile
            // 
            this.textBoxFuzzedFile.Location = new System.Drawing.Point(115, 48);
            this.textBoxFuzzedFile.Name = "textBoxFuzzedFile";
            this.textBoxFuzzedFile.Size = new System.Drawing.Size(293, 21);
            this.textBoxFuzzedFile.TabIndex = 4;
            this.textBoxFuzzedFile.Text = "fuzzed.png";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "模糊后的文件名:";
            // 
            // textBoxTemplateFiles
            // 
            this.textBoxTemplateFiles.Location = new System.Drawing.Point(115, 24);
            this.textBoxTemplateFiles.Name = "textBoxTemplateFiles";
            this.textBoxTemplateFiles.Size = new System.Drawing.Size(293, 21);
            this.textBoxTemplateFiles.TabIndex = 1;
            this.textBoxTemplateFiles.Text = "samples_png";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "使用的模板文件(s):";
            // 
            // tabPageDebuggerWin
            // 
            this.tabPageDebuggerWin.Controls.Add(this.checkBoxCpuKill);
            this.tabPageDebuggerWin.Controls.Add(this.buttonDebuggerPathBrowse);
            this.tabPageDebuggerWin.Controls.Add(this.textBoxDebuggerPath);
            this.tabPageDebuggerWin.Controls.Add(this.label15);
            this.tabPageDebuggerWin.Controls.Add(this.groupBox5);
            this.tabPageDebuggerWin.Controls.Add(this.groupBox4);
            this.tabPageDebuggerWin.Controls.Add(this.groupBox3);
            this.tabPageDebuggerWin.Controls.Add(this.groupBox2);
            this.tabPageDebuggerWin.Controls.Add(this.groupBox1);
            this.tabPageDebuggerWin.Location = new System.Drawing.Point(4, 22);
            this.tabPageDebuggerWin.Name = "tabPageDebuggerWin";
            this.tabPageDebuggerWin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDebuggerWin.Size = new System.Drawing.Size(545, 398);
            this.tabPageDebuggerWin.TabIndex = 1;
            this.tabPageDebuggerWin.Text = "Debugger";
            this.tabPageDebuggerWin.UseVisualStyleBackColor = true;
            // 
            // checkBoxCpuKill
            // 
            this.checkBoxCpuKill.AutoSize = true;
            this.checkBoxCpuKill.Checked = true;
            this.checkBoxCpuKill.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCpuKill.Location = new System.Drawing.Point(17, 80);
            this.checkBoxCpuKill.Name = "checkBoxCpuKill";
            this.checkBoxCpuKill.Size = new System.Drawing.Size(180, 16);
            this.checkBoxCpuKill.TabIndex = 6;
            this.checkBoxCpuKill.Text = "当CPU利用率接近0时结束进程";
            this.checkBoxCpuKill.UseVisualStyleBackColor = true;
            // 
            // buttonDebuggerPathBrowse
            // 
            this.buttonDebuggerPathBrowse.Location = new System.Drawing.Point(462, 54);
            this.buttonDebuggerPathBrowse.Name = "buttonDebuggerPathBrowse";
            this.buttonDebuggerPathBrowse.Size = new System.Drawing.Size(71, 21);
            this.buttonDebuggerPathBrowse.TabIndex = 5;
            this.buttonDebuggerPathBrowse.Text = "浏览";
            this.buttonDebuggerPathBrowse.UseVisualStyleBackColor = true;
            this.buttonDebuggerPathBrowse.Click += new System.EventHandler(this.buttonDebuggerPathBrowse_Click);
            // 
            // textBoxDebuggerPath
            // 
            this.textBoxDebuggerPath.Location = new System.Drawing.Point(97, 56);
            this.textBoxDebuggerPath.Name = "textBoxDebuggerPath";
            this.textBoxDebuggerPath.Size = new System.Drawing.Size(359, 21);
            this.textBoxDebuggerPath.TabIndex = 3;
            this.textBoxDebuggerPath.Text = "C:\\Program Files (x86)\\Debugging Tools for Windows (x86)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 12);
            this.label15.TabIndex = 2;
            this.label15.Text = "WinDbg路径:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonDebuggerCommandBrowse);
            this.groupBox5.Controls.Add(this.textBoxDebuggerCommandLine);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Location = new System.Drawing.Point(10, 102);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(529, 54);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "打开进程";
            // 
            // buttonDebuggerCommandBrowse
            // 
            this.buttonDebuggerCommandBrowse.Location = new System.Drawing.Point(454, 18);
            this.buttonDebuggerCommandBrowse.Name = "buttonDebuggerCommandBrowse";
            this.buttonDebuggerCommandBrowse.Size = new System.Drawing.Size(71, 21);
            this.buttonDebuggerCommandBrowse.TabIndex = 6;
            this.buttonDebuggerCommandBrowse.Text = "浏览";
            this.buttonDebuggerCommandBrowse.UseVisualStyleBackColor = true;
            this.buttonDebuggerCommandBrowse.Click += new System.EventHandler(this.buttonDebuggerCommandBrowse_Click);
            // 
            // textBoxDebuggerCommandLine
            // 
            this.textBoxDebuggerCommandLine.Location = new System.Drawing.Point(92, 20);
            this.textBoxDebuggerCommandLine.Name = "textBoxDebuggerCommandLine";
            this.textBoxDebuggerCommandLine.Size = new System.Drawing.Size(356, 21);
            this.textBoxDebuggerCommandLine.TabIndex = 1;
            this.textBoxDebuggerCommandLine.Text = "mspaint.exe fuzzed.png";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(51, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 12);
            this.label14.TabIndex = 0;
            this.label14.Text = "命令:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxKernelConnectionString);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(10, 301);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(531, 63);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kernel Debugger";
            // 
            // textBoxKernelConnectionString
            // 
            this.textBoxKernelConnectionString.Location = new System.Drawing.Point(110, 26);
            this.textBoxKernelConnectionString.Name = "textBoxKernelConnectionString";
            this.textBoxKernelConnectionString.Size = new System.Drawing.Size(384, 21);
            this.textBoxKernelConnectionString.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "连接使用的字符:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxAttachToServiceServices);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(10, 236);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(529, 59);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "附加服务";
            // 
            // comboBoxAttachToServiceServices
            // 
            this.comboBoxAttachToServiceServices.FormattingEnabled = true;
            this.comboBoxAttachToServiceServices.Location = new System.Drawing.Point(110, 24);
            this.comboBoxAttachToServiceServices.Name = "comboBoxAttachToServiceServices";
            this.comboBoxAttachToServiceServices.Size = new System.Drawing.Size(219, 20);
            this.comboBoxAttachToServiceServices.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "选择服务:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxAttachToProcessProcessName);
            this.groupBox2.Controls.Add(this.textBoxAttachToProcessPID);
            this.groupBox2.Controls.Add(this.radioButtonAttachToProcessProcessName);
            this.groupBox2.Controls.Add(this.radioButtonAttachToProcessPID);
            this.groupBox2.Location = new System.Drawing.Point(10, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(529, 70);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "附加进程";
            // 
            // textBoxAttachToProcessProcessName
            // 
            this.textBoxAttachToProcessProcessName.FormattingEnabled = true;
            this.textBoxAttachToProcessProcessName.Location = new System.Drawing.Point(110, 42);
            this.textBoxAttachToProcessProcessName.Name = "textBoxAttachToProcessProcessName";
            this.textBoxAttachToProcessProcessName.Size = new System.Drawing.Size(219, 20);
            this.textBoxAttachToProcessProcessName.TabIndex = 3;
            // 
            // textBoxAttachToProcessPID
            // 
            this.textBoxAttachToProcessPID.Location = new System.Drawing.Point(110, 17);
            this.textBoxAttachToProcessPID.Name = "textBoxAttachToProcessPID";
            this.textBoxAttachToProcessPID.Size = new System.Drawing.Size(219, 21);
            this.textBoxAttachToProcessPID.TabIndex = 2;
            // 
            // radioButtonAttachToProcessProcessName
            // 
            this.radioButtonAttachToProcessProcessName.AutoSize = true;
            this.radioButtonAttachToProcessProcessName.Location = new System.Drawing.Point(35, 44);
            this.radioButtonAttachToProcessProcessName.Name = "radioButtonAttachToProcessProcessName";
            this.radioButtonAttachToProcessProcessName.Size = new System.Drawing.Size(71, 16);
            this.radioButtonAttachToProcessProcessName.TabIndex = 1;
            this.radioButtonAttachToProcessProcessName.TabStop = true;
            this.radioButtonAttachToProcessProcessName.Text = "选择进程";
            this.radioButtonAttachToProcessProcessName.UseVisualStyleBackColor = true;
            // 
            // radioButtonAttachToProcessPID
            // 
            this.radioButtonAttachToProcessPID.AutoSize = true;
            this.radioButtonAttachToProcessPID.Location = new System.Drawing.Point(36, 20);
            this.radioButtonAttachToProcessPID.Name = "radioButtonAttachToProcessPID";
            this.radioButtonAttachToProcessPID.Size = new System.Drawing.Size(65, 16);
            this.radioButtonAttachToProcessPID.TabIndex = 0;
            this.radioButtonAttachToProcessPID.TabStop = true;
            this.radioButtonAttachToProcessPID.Text = "输入PID";
            this.radioButtonAttachToProcessPID.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonDebuggerAttachToProcess);
            this.groupBox1.Controls.Add(this.radioButtonDebuggerKernelDebugger);
            this.groupBox1.Controls.Add(this.radioButtonDebuggerAttachToService);
            this.groupBox1.Controls.Add(this.radioButtonDebuggerStartProcess);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 45);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Debugger类型";
            // 
            // radioButtonDebuggerAttachToProcess
            // 
            this.radioButtonDebuggerAttachToProcess.AutoSize = true;
            this.radioButtonDebuggerAttachToProcess.Location = new System.Drawing.Point(128, 18);
            this.radioButtonDebuggerAttachToProcess.Name = "radioButtonDebuggerAttachToProcess";
            this.radioButtonDebuggerAttachToProcess.Size = new System.Drawing.Size(71, 16);
            this.radioButtonDebuggerAttachToProcess.TabIndex = 3;
            this.radioButtonDebuggerAttachToProcess.Text = "附加进程";
            this.radioButtonDebuggerAttachToProcess.UseVisualStyleBackColor = true;
            // 
            // radioButtonDebuggerKernelDebugger
            // 
            this.radioButtonDebuggerKernelDebugger.AutoSize = true;
            this.radioButtonDebuggerKernelDebugger.Location = new System.Drawing.Point(418, 18);
            this.radioButtonDebuggerKernelDebugger.Name = "radioButtonDebuggerKernelDebugger";
            this.radioButtonDebuggerKernelDebugger.Size = new System.Drawing.Size(113, 16);
            this.radioButtonDebuggerKernelDebugger.TabIndex = 2;
            this.radioButtonDebuggerKernelDebugger.Text = "Kernel Debugger";
            this.radioButtonDebuggerKernelDebugger.UseVisualStyleBackColor = true;
            // 
            // radioButtonDebuggerAttachToService
            // 
            this.radioButtonDebuggerAttachToService.AutoSize = true;
            this.radioButtonDebuggerAttachToService.Location = new System.Drawing.Point(273, 18);
            this.radioButtonDebuggerAttachToService.Name = "radioButtonDebuggerAttachToService";
            this.radioButtonDebuggerAttachToService.Size = new System.Drawing.Size(71, 16);
            this.radioButtonDebuggerAttachToService.TabIndex = 1;
            this.radioButtonDebuggerAttachToService.Text = "附加服务";
            this.radioButtonDebuggerAttachToService.UseVisualStyleBackColor = true;
            // 
            // radioButtonDebuggerStartProcess
            // 
            this.radioButtonDebuggerStartProcess.AutoSize = true;
            this.radioButtonDebuggerStartProcess.Checked = true;
            this.radioButtonDebuggerStartProcess.Location = new System.Drawing.Point(6, 18);
            this.radioButtonDebuggerStartProcess.Name = "radioButtonDebuggerStartProcess";
            this.radioButtonDebuggerStartProcess.Size = new System.Drawing.Size(71, 16);
            this.radioButtonDebuggerStartProcess.TabIndex = 0;
            this.radioButtonDebuggerStartProcess.TabStop = true;
            this.radioButtonDebuggerStartProcess.Text = "打开进程";
            this.radioButtonDebuggerStartProcess.UseVisualStyleBackColor = true;
            // 
            // tabPageDebuggerOSX
            // 
            this.tabPageDebuggerOSX.Controls.Add(this.richTextBoxOSX);
            this.tabPageDebuggerOSX.Controls.Add(this.groupBox9);
            this.tabPageDebuggerOSX.Controls.Add(this.groupBox11);
            this.tabPageDebuggerOSX.Controls.Add(this.groupBox8);
            this.tabPageDebuggerOSX.Location = new System.Drawing.Point(4, 22);
            this.tabPageDebuggerOSX.Name = "tabPageDebuggerOSX";
            this.tabPageDebuggerOSX.Size = new System.Drawing.Size(545, 398);
            this.tabPageDebuggerOSX.TabIndex = 7;
            this.tabPageDebuggerOSX.Text = "Debugger";
            this.tabPageDebuggerOSX.UseVisualStyleBackColor = true;
            // 
            // richTextBoxOSX
            // 
            this.richTextBoxOSX.Location = new System.Drawing.Point(3, 215);
            this.richTextBoxOSX.Name = "richTextBoxOSX";
            this.richTextBoxOSX.ReadOnly = true;
            this.richTextBoxOSX.Size = new System.Drawing.Size(539, 154);
            this.richTextBoxOSX.TabIndex = 10;
            this.richTextBoxOSX.Text = "";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.textBoxOSXArguments);
            this.groupBox9.Controls.Add(this.label28);
            this.groupBox9.Controls.Add(this.checkBoxOSXCpuKill);
            this.groupBox9.Controls.Add(this.button1);
            this.groupBox9.Controls.Add(this.textBoxOSXExecutable);
            this.groupBox9.Controls.Add(this.label25);
            this.groupBox9.Location = new System.Drawing.Point(8, 62);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(529, 92);
            this.groupBox9.TabIndex = 9;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Start Process";
            // 
            // textBoxOSXArguments
            // 
            this.textBoxOSXArguments.Location = new System.Drawing.Point(91, 44);
            this.textBoxOSXArguments.Name = "textBoxOSXArguments";
            this.textBoxOSXArguments.Size = new System.Drawing.Size(356, 21);
            this.textBoxOSXArguments.TabIndex = 13;
            this.textBoxOSXArguments.Text = "fuzzed.png";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(26, 47);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(65, 12);
            this.label28.TabIndex = 12;
            this.label28.Text = "Arguments:";
            // 
            // checkBoxOSXCpuKill
            // 
            this.checkBoxOSXCpuKill.AutoSize = true;
            this.checkBoxOSXCpuKill.Checked = true;
            this.checkBoxOSXCpuKill.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOSXCpuKill.Location = new System.Drawing.Point(91, 68);
            this.checkBoxOSXCpuKill.Name = "checkBoxOSXCpuKill";
            this.checkBoxOSXCpuKill.Size = new System.Drawing.Size(252, 16);
            this.checkBoxOSXCpuKill.TabIndex = 11;
            this.checkBoxOSXCpuKill.Text = "Kill Process when CPU Usage Nears Zero";
            this.checkBoxOSXCpuKill.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(454, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 21);
            this.button1.TabIndex = 6;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBoxOSXExecutable
            // 
            this.textBoxOSXExecutable.Location = new System.Drawing.Point(92, 20);
            this.textBoxOSXExecutable.Name = "textBoxOSXExecutable";
            this.textBoxOSXExecutable.Size = new System.Drawing.Size(356, 21);
            this.textBoxOSXExecutable.TabIndex = 1;
            this.textBoxOSXExecutable.Text = "/Applications/Safari.app/Contents/MacOS/Safari";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(23, 23);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(71, 12);
            this.label25.TabIndex = 0;
            this.label25.Text = "Executable:";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.button2);
            this.groupBox11.Controls.Add(this.label26);
            this.groupBox11.Controls.Add(this.textBoxOSXCrashWrangler);
            this.groupBox11.Location = new System.Drawing.Point(8, 160);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(529, 50);
            this.groupBox11.TabIndex = 7;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Crash Wrangler";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(452, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 21);
            this.button2.TabIndex = 7;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(5, 19);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(95, 12);
            this.label26.TabIndex = 3;
            this.label26.Text = "Crash Wrangler:";
            // 
            // textBoxOSXCrashWrangler
            // 
            this.textBoxOSXCrashWrangler.Location = new System.Drawing.Point(91, 17);
            this.textBoxOSXCrashWrangler.Name = "textBoxOSXCrashWrangler";
            this.textBoxOSXCrashWrangler.Size = new System.Drawing.Size(356, 21);
            this.textBoxOSXCrashWrangler.TabIndex = 2;
            this.textBoxOSXCrashWrangler.Text = "exc_handler";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.radioButtonOSXCrashWrangler);
            this.groupBox8.Controls.Add(this.radioButtonOSXCrashReporter);
            this.groupBox8.Location = new System.Drawing.Point(8, 11);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(529, 45);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Debugger Type";
            // 
            // radioButtonOSXCrashWrangler
            // 
            this.radioButtonOSXCrashWrangler.AutoSize = true;
            this.radioButtonOSXCrashWrangler.Location = new System.Drawing.Point(128, 18);
            this.radioButtonOSXCrashWrangler.Name = "radioButtonOSXCrashWrangler";
            this.radioButtonOSXCrashWrangler.Size = new System.Drawing.Size(107, 16);
            this.radioButtonOSXCrashWrangler.TabIndex = 3;
            this.radioButtonOSXCrashWrangler.Text = "Crash Wrangler";
            this.radioButtonOSXCrashWrangler.UseVisualStyleBackColor = true;
            // 
            // radioButtonOSXCrashReporter
            // 
            this.radioButtonOSXCrashReporter.AutoSize = true;
            this.radioButtonOSXCrashReporter.Checked = true;
            this.radioButtonOSXCrashReporter.Location = new System.Drawing.Point(6, 18);
            this.radioButtonOSXCrashReporter.Name = "radioButtonOSXCrashReporter";
            this.radioButtonOSXCrashReporter.Size = new System.Drawing.Size(107, 16);
            this.radioButtonOSXCrashReporter.TabIndex = 0;
            this.radioButtonOSXCrashReporter.TabStop = true;
            this.radioButtonOSXCrashReporter.Text = "Crash Reporter";
            this.radioButtonOSXCrashReporter.UseVisualStyleBackColor = true;
            // 
            // tabPageDebuggerLinux
            // 
            this.tabPageDebuggerLinux.Controls.Add(this.groupBox10);
            this.tabPageDebuggerLinux.Controls.Add(this.richTextBoxLinux);
            this.tabPageDebuggerLinux.Location = new System.Drawing.Point(4, 22);
            this.tabPageDebuggerLinux.Name = "tabPageDebuggerLinux";
            this.tabPageDebuggerLinux.Size = new System.Drawing.Size(545, 398);
            this.tabPageDebuggerLinux.TabIndex = 8;
            this.tabPageDebuggerLinux.Text = "Debugger";
            this.tabPageDebuggerLinux.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label29);
            this.groupBox10.Controls.Add(this.textBoxLinuxArguments);
            this.groupBox10.Controls.Add(this.checkBoxLinuxCpuKill);
            this.groupBox10.Controls.Add(this.button3);
            this.groupBox10.Controls.Add(this.textBoxLinuxExecutable);
            this.groupBox10.Controls.Add(this.label27);
            this.groupBox10.Location = new System.Drawing.Point(8, 11);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(529, 90);
            this.groupBox10.TabIndex = 10;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Start Process";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(6, 47);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(65, 12);
            this.label29.TabIndex = 13;
            this.label29.Text = "Arguments:";
            // 
            // textBoxLinuxArguments
            // 
            this.textBoxLinuxArguments.Location = new System.Drawing.Point(92, 44);
            this.textBoxLinuxArguments.Name = "textBoxLinuxArguments";
            this.textBoxLinuxArguments.Size = new System.Drawing.Size(356, 21);
            this.textBoxLinuxArguments.TabIndex = 12;
            this.textBoxLinuxArguments.Text = "fuzzed.png";
            // 
            // checkBoxLinuxCpuKill
            // 
            this.checkBoxLinuxCpuKill.AutoSize = true;
            this.checkBoxLinuxCpuKill.Checked = true;
            this.checkBoxLinuxCpuKill.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLinuxCpuKill.Location = new System.Drawing.Point(92, 68);
            this.checkBoxLinuxCpuKill.Name = "checkBoxLinuxCpuKill";
            this.checkBoxLinuxCpuKill.Size = new System.Drawing.Size(252, 16);
            this.checkBoxLinuxCpuKill.TabIndex = 11;
            this.checkBoxLinuxCpuKill.Text = "Kill Process when CPU Usage Nears Zero";
            this.checkBoxLinuxCpuKill.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(454, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 21);
            this.button3.TabIndex = 6;
            this.button3.Text = "Browse";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBoxLinuxExecutable
            // 
            this.textBoxLinuxExecutable.Location = new System.Drawing.Point(92, 20);
            this.textBoxLinuxExecutable.Name = "textBoxLinuxExecutable";
            this.textBoxLinuxExecutable.Size = new System.Drawing.Size(356, 21);
            this.textBoxLinuxExecutable.TabIndex = 1;
            this.textBoxLinuxExecutable.Text = "/usr/bin/feh";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(6, 23);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(71, 12);
            this.label27.TabIndex = 0;
            this.label27.Text = "Executable:";
            // 
            // richTextBoxLinux
            // 
            this.richTextBoxLinux.Location = new System.Drawing.Point(3, 106);
            this.richTextBoxLinux.Name = "richTextBoxLinux";
            this.richTextBoxLinux.ReadOnly = true;
            this.richTextBoxLinux.Size = new System.Drawing.Size(539, 241);
            this.richTextBoxLinux.TabIndex = 1;
            this.richTextBoxLinux.Text = "";
            // 
            // tabPageGUI
            // 
            this.tabPageGUI.Controls.Add(this.groupBox7);
            this.tabPageGUI.Controls.Add(this.textBox1);
            this.tabPageGUI.Location = new System.Drawing.Point(4, 22);
            this.tabPageGUI.Name = "tabPageGUI";
            this.tabPageGUI.Size = new System.Drawing.Size(545, 398);
            this.tabPageGUI.TabIndex = 2;
            this.tabPageGUI.Text = "GUI";
            this.tabPageGUI.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label24);
            this.groupBox7.Controls.Add(this.textBoxWindowTitle4);
            this.groupBox7.Controls.Add(this.label23);
            this.groupBox7.Controls.Add(this.textBoxWindowTitle3);
            this.groupBox7.Controls.Add(this.label22);
            this.groupBox7.Controls.Add(this.textBoxWindowTitle2);
            this.groupBox7.Controls.Add(this.label21);
            this.groupBox7.Controls.Add(this.checkBoxEnableWmClose);
            this.groupBox7.Controls.Add(this.textBoxWindowTitle1);
            this.groupBox7.Location = new System.Drawing.Point(9, 11);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(528, 148);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "关闭窗口程序";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 114);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(65, 12);
            this.label24.TabIndex = 7;
            this.label24.Text = "窗口标题4:";
            // 
            // textBoxWindowTitle4
            // 
            this.textBoxWindowTitle4.Location = new System.Drawing.Point(84, 111);
            this.textBoxWindowTitle4.Name = "textBoxWindowTitle4";
            this.textBoxWindowTitle4.Size = new System.Drawing.Size(438, 21);
            this.textBoxWindowTitle4.TabIndex = 6;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 90);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(65, 12);
            this.label23.TabIndex = 5;
            this.label23.Text = "窗口标题3:";
            // 
            // textBoxWindowTitle3
            // 
            this.textBoxWindowTitle3.Location = new System.Drawing.Point(84, 87);
            this.textBoxWindowTitle3.Name = "textBoxWindowTitle3";
            this.textBoxWindowTitle3.Size = new System.Drawing.Size(438, 21);
            this.textBoxWindowTitle3.TabIndex = 4;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 66);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 12);
            this.label22.TabIndex = 3;
            this.label22.Text = "窗口标题2:";
            // 
            // textBoxWindowTitle2
            // 
            this.textBoxWindowTitle2.Location = new System.Drawing.Point(84, 63);
            this.textBoxWindowTitle2.Name = "textBoxWindowTitle2";
            this.textBoxWindowTitle2.Size = new System.Drawing.Size(438, 21);
            this.textBoxWindowTitle2.TabIndex = 2;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 42);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 12);
            this.label21.TabIndex = 1;
            this.label21.Text = "窗口标题1:";
            // 
            // checkBoxEnableWmClose
            // 
            this.checkBoxEnableWmClose.AutoSize = true;
            this.checkBoxEnableWmClose.Location = new System.Drawing.Point(9, 18);
            this.checkBoxEnableWmClose.Name = "checkBoxEnableWmClose";
            this.checkBoxEnableWmClose.Size = new System.Drawing.Size(144, 16);
            this.checkBoxEnableWmClose.TabIndex = 1;
            this.checkBoxEnableWmClose.Text = "允许关闭(弹出的)窗口";
            this.checkBoxEnableWmClose.UseVisualStyleBackColor = true;
            // 
            // textBoxWindowTitle1
            // 
            this.textBoxWindowTitle1.Location = new System.Drawing.Point(84, 39);
            this.textBoxWindowTitle1.Name = "textBoxWindowTitle1";
            this.textBoxWindowTitle1.Size = new System.Drawing.Size(438, 21);
            this.textBoxWindowTitle1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 233);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(529, 112);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "当模糊程序使用了带UI的程序时最好的办法是向其发送一个 WM_CLOSE消息来关闭该UI,\r\n\r\n这与使用Cltr+F4的操作相似\r\n\r\n为了能够这样做,你需要勾" +
    "选上方的单选框并在其下方输入关闭窗口的信息\r\n\r\n注意:输入完整的标题或部分标题都可以。";
            // 
            // tabPageFuzzing
            // 
            this.tabPageFuzzing.Controls.Add(this.textBox13);
            this.tabPageFuzzing.Controls.Add(this.label12);
            this.tabPageFuzzing.Controls.Add(this.textBox12);
            this.tabPageFuzzing.Controls.Add(this.textBox11);
            this.tabPageFuzzing.Controls.Add(this.textBox10);
            this.tabPageFuzzing.Controls.Add(this.textBox9);
            this.tabPageFuzzing.Controls.Add(this.label11);
            this.tabPageFuzzing.Controls.Add(this.label10);
            this.tabPageFuzzing.Controls.Add(this.label9);
            this.tabPageFuzzing.Controls.Add(this.label8);
            this.tabPageFuzzing.Location = new System.Drawing.Point(4, 22);
            this.tabPageFuzzing.Name = "tabPageFuzzing";
            this.tabPageFuzzing.Size = new System.Drawing.Size(545, 398);
            this.tabPageFuzzing.TabIndex = 3;
            this.tabPageFuzzing.Text = "Fuzzing";
            this.tabPageFuzzing.UseVisualStyleBackColor = true;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(151, 111);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(284, 21);
            this.textBox13.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(96, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 12);
            this.label12.TabIndex = 8;
            this.label12.Text = "Strategy:";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(151, 87);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(284, 21);
            this.textBox12.TabIndex = 7;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(151, 63);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(284, 21);
            this.textBox11.TabIndex = 6;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(151, 39);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(284, 21);
            this.textBox10.TabIndex = 5;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(151, 17);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(284, 21);
            this.textBox9.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 12);
            this.label11.TabIndex = 3;
            this.label11.Text = "Estimated Completion Time:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(89, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 2;
            this.label10.Text = "Run Time:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(65, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = "Total Iterations:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "Current Iteration:";
            // 
            // tabPageOutput
            // 
            this.tabPageOutput.Controls.Add(this.textBoxIterationCount);
            this.tabPageOutput.Controls.Add(this.label19);
            this.tabPageOutput.Controls.Add(this.textBoxFaultCount);
            this.tabPageOutput.Controls.Add(this.label18);
            this.tabPageOutput.Controls.Add(this.textBoxOutput);
            this.tabPageOutput.Controls.Add(this.progressBarOuputFuzzing);
            this.tabPageOutput.Location = new System.Drawing.Point(4, 22);
            this.tabPageOutput.Name = "tabPageOutput";
            this.tabPageOutput.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOutput.Size = new System.Drawing.Size(545, 398);
            this.tabPageOutput.TabIndex = 4;
            this.tabPageOutput.Text = "Output";
            this.tabPageOutput.UseVisualStyleBackColor = true;
            // 
            // textBoxIterationCount
            // 
            this.textBoxIterationCount.Location = new System.Drawing.Point(92, 329);
            this.textBoxIterationCount.Name = "textBoxIterationCount";
            this.textBoxIterationCount.ReadOnly = true;
            this.textBoxIterationCount.Size = new System.Drawing.Size(100, 21);
            this.textBoxIterationCount.TabIndex = 5;
            this.textBoxIterationCount.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(5, 333);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(83, 12);
            this.label19.TabIndex = 4;
            this.label19.Text = "迭代次数计数:";
            // 
            // textBoxFaultCount
            // 
            this.textBoxFaultCount.Location = new System.Drawing.Point(294, 329);
            this.textBoxFaultCount.Name = "textBoxFaultCount";
            this.textBoxFaultCount.ReadOnly = true;
            this.textBoxFaultCount.Size = new System.Drawing.Size(100, 21);
            this.textBoxFaultCount.TabIndex = 3;
            this.textBoxFaultCount.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(207, 333);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(83, 12);
            this.label18.TabIndex = 2;
            this.label18.Text = "失败次数计数:";
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(8, 32);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput.Size = new System.Drawing.Size(529, 291);
            this.textBoxOutput.TabIndex = 1;
            // 
            // progressBarOuputFuzzing
            // 
            this.progressBarOuputFuzzing.Location = new System.Drawing.Point(8, 6);
            this.progressBarOuputFuzzing.Name = "progressBarOuputFuzzing";
            this.progressBarOuputFuzzing.Size = new System.Drawing.Size(529, 21);
            this.progressBarOuputFuzzing.TabIndex = 0;
            // 
            // tabPageAbout
            // 
            this.tabPageAbout.Controls.Add(this.pictureBox2);
            this.tabPageAbout.Controls.Add(this.pictureBox1);
            this.tabPageAbout.Location = new System.Drawing.Point(4, 22);
            this.tabPageAbout.Name = "tabPageAbout";
            this.tabPageAbout.Size = new System.Drawing.Size(545, 398);
            this.tabPageAbout.TabIndex = 5;
            this.tabPageAbout.Text = "关于";
            this.tabPageAbout.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(9, 133);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(528, 210);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(529, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonStopFuzzing);
            this.panel1.Controls.Add(this.buttonSaveConfiguration);
            this.panel1.Controls.Add(this.buttonStartFuzzing);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 394);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 30);
            this.panel1.TabIndex = 1;
            // 
            // buttonStopFuzzing
            // 
            this.buttonStopFuzzing.Location = new System.Drawing.Point(352, 3);
            this.buttonStopFuzzing.Name = "buttonStopFuzzing";
            this.buttonStopFuzzing.Size = new System.Drawing.Size(87, 21);
            this.buttonStopFuzzing.TabIndex = 2;
            this.buttonStopFuzzing.Text = "停止模糊测试";
            this.buttonStopFuzzing.UseVisualStyleBackColor = true;
            this.buttonStopFuzzing.Click += new System.EventHandler(this.buttonStopFuzzing_Click);
            // 
            // buttonSaveConfiguration
            // 
            this.buttonSaveConfiguration.Location = new System.Drawing.Point(237, 3);
            this.buttonSaveConfiguration.Name = "buttonSaveConfiguration";
            this.buttonSaveConfiguration.Size = new System.Drawing.Size(109, 21);
            this.buttonSaveConfiguration.TabIndex = 1;
            this.buttonSaveConfiguration.Text = "保存配置";
            this.buttonSaveConfiguration.UseVisualStyleBackColor = true;
            this.buttonSaveConfiguration.Click += new System.EventHandler(this.buttonSaveConfiguration_Click);
            // 
            // buttonStartFuzzing
            // 
            this.buttonStartFuzzing.Location = new System.Drawing.Point(129, 3);
            this.buttonStartFuzzing.Name = "buttonStartFuzzing";
            this.buttonStartFuzzing.Size = new System.Drawing.Size(102, 21);
            this.buttonStartFuzzing.TabIndex = 0;
            this.buttonStartFuzzing.Text = "开始模糊测试";
            this.buttonStartFuzzing.UseVisualStyleBackColor = true;
            this.buttonStartFuzzing.Click += new System.EventHandler(this.buttonStartFuzzing_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 424);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Peach 3 - Fuzz Bang";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageIntroduction.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            this.tabPageGeneral.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabPageDebuggerWin.ResumeLayout(false);
            this.tabPageDebuggerWin.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageDebuggerOSX.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.tabPageDebuggerLinux.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.tabPageGUI.ResumeLayout(false);
            this.tabPageGUI.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.tabPageFuzzing.ResumeLayout(false);
            this.tabPageFuzzing.PerformLayout();
            this.tabPageOutput.ResumeLayout(false);
            this.tabPageOutput.PerformLayout();
            this.tabPageAbout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPageGeneral;
		private System.Windows.Forms.Button buttonBrowseFuzzedFile;
		private System.Windows.Forms.Button buttonBrowseTemplates;
		private System.Windows.Forms.TextBox textBoxFuzzedFile;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxTemplateFiles;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabPage tabPageDebuggerWin;
		private System.Windows.Forms.TabPage tabPageGUI;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox textBoxAttachToProcessPID;
		private System.Windows.Forms.RadioButton radioButtonAttachToProcessProcessName;
		private System.Windows.Forms.RadioButton radioButtonAttachToProcessPID;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButtonDebuggerAttachToProcess;
		private System.Windows.Forms.RadioButton radioButtonDebuggerKernelDebugger;
		private System.Windows.Forms.RadioButton radioButtonDebuggerAttachToService;
		private System.Windows.Forms.RadioButton radioButtonDebuggerStartProcess;
		private System.Windows.Forms.TextBox textBoxKernelConnectionString;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox comboBoxAttachToServiceServices;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TabPage tabPageFuzzing;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button buttonStopFuzzing;
		private System.Windows.Forms.Button buttonSaveConfiguration;
		private System.Windows.Forms.Button buttonStartFuzzing;
		private System.Windows.Forms.TextBox textBox13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox textBox12;
		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.ComboBox comboBoxFuzzingStrategy;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.TextBox textBoxDebuggerCommandLine;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TabPage tabPageOutput;
		public System.Windows.Forms.TextBox textBoxOutput;
		public System.Windows.Forms.ProgressBar progressBarOuputFuzzing;
		private System.Windows.Forms.Button buttonDebuggerPathBrowse;
		private System.Windows.Forms.TextBox textBoxDebuggerPath;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Button buttonDebuggerCommandBrowse;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.Button buttonPitFileNameBrowse;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxPitFileName;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button buttonPitFileNameLoad;
		private System.Windows.Forms.ComboBox comboBoxPitDataModel;
		private System.Windows.Forms.TabPage tabPageAbout;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button buttonLogPathBrowse;
		private System.Windows.Forms.TextBox textBoxLogPath;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label18;
		public System.Windows.Forms.TextBox textBoxIterationCount;
		public System.Windows.Forms.TextBox textBoxFaultCount;
		private System.Windows.Forms.ComboBox textBoxAttachToProcessProcessName;
		private System.Windows.Forms.TabPage tabPageIntroduction;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.RichTextBox richTextBoxIntroduction;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.CheckBox checkBoxEnableWmClose;
		private System.Windows.Forms.TextBox textBoxWindowTitle1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.CheckBox checkBoxCpuKill;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.TextBox textBoxWindowTitle4;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.TextBox textBoxWindowTitle3;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.TextBox textBoxWindowTitle2;
		private System.Windows.Forms.TabPage tabPageDebuggerOSX;
		private System.Windows.Forms.TabPage tabPageDebuggerLinux;
		private System.Windows.Forms.GroupBox groupBox9;
		private System.Windows.Forms.CheckBox checkBoxOSXCpuKill;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBoxOSXExecutable;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.GroupBox groupBox11;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.TextBox textBoxOSXCrashWrangler;
		private System.Windows.Forms.GroupBox groupBox8;
		private System.Windows.Forms.RadioButton radioButtonOSXCrashWrangler;
		private System.Windows.Forms.RadioButton radioButtonOSXCrashReporter;
		private System.Windows.Forms.GroupBox groupBox10;
		private System.Windows.Forms.CheckBox checkBoxLinuxCpuKill;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox textBoxLinuxExecutable;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.RichTextBox richTextBoxLinux;
		private System.Windows.Forms.RichTextBox richTextBoxOSX;
		private System.Windows.Forms.TextBox textBoxOSXArguments;
		private System.Windows.Forms.Label label28;
		public System.Windows.Forms.TextBox textBoxIterations;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.TextBox textBoxLinuxArguments;
	}
}

