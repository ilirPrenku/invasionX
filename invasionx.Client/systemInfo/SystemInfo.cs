using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Management;

namespace ClientSystemInfo
{
	class SystemInfo
	{
		public static string GetComponent(string hwDevice, string hwStatus)
		{
			ManagementObjectSearcher search = new ManagementObjectSearcher("SELECT * FROM " + hwDevice);
			string Component_Name = "";
			foreach (var hardware in search.Get())
			{
				Component_Name = Convert.ToString(hardware[hwStatus]);
				
				
			}

			return Component_Name ;
		}

	}

	class ClinetInfo
	{
		public static string OS = SystemInfo.GetComponent(OperatingSystem.OS, OperatingSystem.Name);
		public string RAM = SystemInfo.GetComponent(OperatingSystem.OS, OperatingSystem.Memory);
		public string SystemStarted = SystemInfo.GetComponent(OperatingSystem.OS, OperatingSystem.BootTime);

	}

}
