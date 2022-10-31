using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			resultlbl.Text = String.Empty;
		}

		private void numbertxt_TextChanged(object sender, EventArgs e)
		{
			try
			{
				string result = numbertxt.Text;
				if (Convert.ToInt32(result) <= 0)
					resultlbl.Text = "輸入值不能為0或小於0";
				else
				{
					resultlbl.Text = String.Empty;
				}
			}
			catch (Exception ex)
			{
				resultlbl.Text = ex.Message;
			}
		}
	}
}
