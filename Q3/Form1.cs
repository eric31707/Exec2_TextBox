using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			resultlbl.Text = String.Empty;
		}

		private void comparebtn_Click(object sender, EventArgs e)
		{
			try
			{
				string[] datetime = inputtxt.Text.Split('/');
				bool dt = int.TryParse(datetime[0], out int year);
				bool dt1 = int.TryParse(datetime[1], out int month);
				bool dt2 = int.TryParse(datetime[2], out int days);
				DateTime result = new DateTime(year, month, days);
				if (result > DateTime.Now)
				{
					MessageBox.Show("生日不能比今天更晚");
					resultlbl.Text = "請重新輸入";
				}
				else if (DateTime.Now.Year - year == 13)
				{
					resultlbl.Text = "剛好13歲";
				}
				else if (DateTime.Now.Year - year > 13)
				{
					resultlbl.Text = "已滿13歲";
				}
				else if (DateTime.Now.Year - year < 13)
				{
					resultlbl.Text = "未滿13歲";
				}
			}
			catch (Exception ex)
			{
				resultlbl.Text = ex.Message;
			}
		}
	}
}
