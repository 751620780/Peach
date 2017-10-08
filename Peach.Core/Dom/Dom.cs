
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
using System.Collections;
using System.Text;
using Peach.Core.Agent;
using System.Runtime.Serialization;
using System.Xml;

namespace Peach.Core.Dom
{
    /// <summary>
    /// 文档对象模型
    /// </summary>
	[Serializable]
	public class Dom : INamed
	{
		public string fileName = "";
		public string version = "";
		public string author = "";
		public string description = "";

		public RunContext context = null;
		public OrderedDictionary<string, Dom> ns = new OrderedDictionary<string, Dom>();
		public OrderedDictionary<string, DataModel> dataModels = new OrderedDictionary<string, DataModel>();
		public OrderedDictionary<string, StateModel> stateModels = new OrderedDictionary<string, StateModel>();
		public NamedCollection<Agent> agents = new NamedCollection<Agent>();
		public OrderedDictionary<string, Test> tests = new OrderedDictionary<string, Test>();
		public NamedCollection<DataSet> datas = new NamedCollection<DataSet>();

		public Dom()
		{
			name = "";

			dataModels.AddEvent += new AddEventHandler<string, DataModel>(dataModels_AddEvent);
			stateModels.AddEvent += new AddEventHandler<string, StateModel>(stateModels_AddEvent);
			tests.AddEvent += new AddEventHandler<string, Test>(tests_AddEvent);
		}

		#region OrderedDictionary AddEvent Handlers

		void tests_AddEvent(OrderedDictionary<string, Test> sender, string key, Test value)
		{
			value.parent = this;
		}

		void stateModels_AddEvent(OrderedDictionary<string, StateModel> sender, string key, StateModel value)
		{
			value.parent = this;
		}

		void dataModels_AddEvent(OrderedDictionary<string, DataModel> sender, string key, DataModel value)
		{
			value.dom = this;
		}

		#endregion

		/// <summary>
        /// 对DOM中的所有的DataModel执行dataModel分析器
        /// <para>其目的可能是分析出所有的dataModel</para>
		/// </summary>
		public void evaulateDataModelAnalyzers()
		{
            foreach (DataModel model in dataModels.Values)//查找dataModels字典中记录的的每一项dataModels，并进行分析
                model.evaulateAnalyzers();

            foreach (Test test in tests.Values)//对每一个Test里的每一个stateModel中的每一个action中的每一个DataModel进行分析
			{
                foreach (State state in test.stateModel.states)
				{
                    foreach (Action action in state.actions)
					{
						foreach (var data in action.allData)
						{
							data.dataModel.evaulateAnalyzers();
						}
					}
				}
			}
		}

		/// <summary>
        /// 泛型函数，可通过refname查找被引用的Dom元素，也包含有名称空间的前缀的情况
		/// </summary>
		/// <typeparam name="T">Dom的元素的类型.</typeparam>
		/// <param name="refName">引用名</param>
        /// <param name="predicate">Selector predicate that returns the element collection</param>
		/// <returns>找到则返回Dom元素的名字，否则返回null.</returns>
		public T getRef<T>(string refName, Func<Dom, ITryGetValue<string, T>> predicate)
		{
            /*
             * 对于一个xml的子标签，可能使用 ref="sb:refname" 的形式引用，sb表示名称空间的替代（可能不存在）
             * getRef<T>()是泛型函数，即返回参数的类型只有在调用时才能确定
             * Func<Dom, ITryGetValue<string, T>> predicate   表示定义了一个委托
             *                                      参数：Dom类型
             *                                      返回：ITryGetValue<string, T>的接口
             *                                      predicate是委托对象，是一个函数的指针？？？？
             */
            int i = refName.IndexOf(':');//记录“：”出现的第一个位置（0作为开始）
			if (i > -1)//如果存在冒号，这说明这个引入了一个外部名称空间
			{
				string prefix = refName.Substring(0, i);//获得冒号前面的字符串，即名称空间的替代

				Dom other;
				if (!ns.TryGetValue(prefix, out other))//看看在字典中能不能找到该名称空间的定义
                    throw new PeachException("找不到引用名为 '" + refName + "' 中的 '" + prefix + "' 所对应的名称空间.");//找不到，就说这个名称空间不存在

				refName = refName.Substring(i + 1);//取冒号后面的字符串，即refname

				return other.getRef<T>(refName, predicate);
			}
            //没有引入外部的名称空间的情况下
			var dict = predicate(this);
			T value = default(T);
			if (dict.TryGetValue(refName, out value))
				return value;
			return default(T);
		}


		#region INamed 成员

		public virtual string name//属性
		{
			get; set;
		}

		#endregion
	}
}


// END
