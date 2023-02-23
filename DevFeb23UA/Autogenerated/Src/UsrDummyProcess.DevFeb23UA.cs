namespace Terrasoft.Core.Process
{

	using Newtonsoft.Json;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Drawing;
	using System.Globalization;
	using System.Text;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: UsrDummyProcessMethodsWrapper

	/// <exclude/>
	public class UsrDummyProcessMethodsWrapper : ProcessModel
	{

		public UsrDummyProcessMethodsWrapper(Process process)
			: base(process) {
			AddScriptTaskMethod("MyScriptTaskExecute", MyScriptTaskExecute);
		}

		#region Methods: Private

		private bool MyScriptTaskExecute(ProcessExecutingContext context) {
			var st = JsonConvert.SerializeObject(new {param = "value"});
			return true;
		}

		#endregion

	}

	#endregion

}

