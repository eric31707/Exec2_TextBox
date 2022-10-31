using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			resultlbl.Text = String.Empty;
		}

		private void datetxt_TextChanged(object sender, EventArgs e)
		{

		}

		private void submitbtn_Click(object sender, EventArgs e)
		{
			try
			{
				string[] datetime = datetxt.Text.Split('/');
				bool dt = int.TryParse(datetime[0], out int year);
				bool dt1 = int.TryParse(datetime[1], out int month);
				bool dt2 = int.TryParse(datetime[2], out int days);
				DateTime result = new DateTime(year, month, days);
				if (result > DateTime.Now)
					resultlbl.Text = "輸入值大於今天";
				else
				{
					resultlbl.Text = "輸入值小於今天";
				}
			}
			catch (Exception ex)
			{
				resultlbl.Text = ex.Message;
			}
		}
	}
}
