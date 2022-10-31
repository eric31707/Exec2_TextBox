using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q4
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void calcubtn_Click(object sender, EventArgs e)
		{
			try
			{
				string cars = cartxt.Text;
				string people = peopletxt.Text;
				if (Convert.ToInt32(cars) * 200 > Convert.ToInt32(people) * 60)
				{
					MessageBox.Show($"費用是{Convert.ToInt32(people) * 60}");
				}
				else
				{
					MessageBox.Show($"費用是{Convert.ToInt32(cars) * 200}");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
