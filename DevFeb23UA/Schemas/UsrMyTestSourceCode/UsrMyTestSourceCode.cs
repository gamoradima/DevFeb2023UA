 namespace Terrasoft.Configuration {
	 using Newtonsoft.Json;
	 
	 public class MyName {
		public string MyMethod()
		{
			var st = JsonConvert.SerializeObject(new { param = "value" });
			return st;
		}
	 }
 }