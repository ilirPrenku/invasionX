using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientSystemInfo;
using System.Diagnostics;


namespace invasionX.invasionx.Client
{
	public partial class Client : Form
	{
		public Client()
		{
			InitializeComponent();
		}



		private void Client_Load(object sender, EventArgs e)
		{
			
			//MessageBox.Show(SystemInfo.GetComponent(component.network, component.Name));
			MessageBox.Show(ClinetInfo.OS);
		}
	}
}
