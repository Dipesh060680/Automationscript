namespace TestscriptDIPS_1
{
	using System;
	using System.Collections.Generic;
	using System.Globalization;
	using System.Text;
	using Skyline.DataMiner.Automation;
	
	/// <summary>
	/// Represents a DataMiner Automation script.
	/// </summary>
	public class Script
	{
		/// <summary>
		/// The script entry point.
		/// </summary>
		/// <param name="engine">Link with SLAutomation process.</param>
		public void Run(IEngine engine)
		{
			engine.GenerateInformation("Hello Mumbai World!");
			engine.GenerateInformation("welcome #dmempowermumbai")
		    engine.GenerateInformation("Dish Tv India Ltd")
			engine.GenerateInformation("Hotel sahara star Datamine seminar Empower")
	}
}