using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BolunebilenSayilar
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnMod2_Click(object sender, EventArgs e)
		{
			lstMod2.DataSource = null;
			List<int> mod2List = new List<int>();
			for (int i = 1; i <= 100; i++)
			{
				if (i % 2 == 0)
				{
					mod2List.Add(i);
				}
			}
			lstMod2.DataSource = mod2List;
		}

		private void btnMod3_Click(object sender, EventArgs e)
		{
			lstMod3.DataSource = null;
			List<int> mod3List = new List<int>();
			for (int i = 1; i <= 100; i++)
			{
				if (i % 3 == 0)
				{
					mod3List.Add(i);
				}
			}
			lstMod3.DataSource = mod3List;
		}

		private void btnMod4_Click(object sender, EventArgs e)
		{
			lstMod4.DataSource = null;
			List<int> mod4List = new List<int>();
			for (int i = 1; i <= 100; i++)
			{
				if (i % 4 == 0)
				{
					mod4List.Add(i);
				}
			}
			lstMod4.DataSource = mod4List;
		}

		private void btnMod5_Click(object sender, EventArgs e)
		{
			lstMod5.DataSource = null;
			List<int> mod5List = new List<int>();
			for (int i = 1; i <= 100; i++)
			{
				if (i % 5 == 0)
				{
					mod5List.Add(i);
				}
			}
			lstMod5.DataSource = mod5List;
		}

		private void btnMod6_Click(object sender, EventArgs e)
		{
			lstMod6.DataSource = null;
			List<int> mod6List = new List<int>();
			for (int i = 1; i <= 100; i++)
			{
				if (i % 2 == 0 && i % 3 == 0)
				{
					mod6List.Add(i);
				}
			}
			lstMod6.DataSource = mod6List;
		}

		private void btnMod7_Click(object sender, EventArgs e)
		{
			lstMod7.DataSource = null;
			List<int> mod7List = new List<int>();
			for (int i = 1; i <= 100; i++)
			{
				if (i % 7 == 0)
				{
					mod7List.Add(i);
				}
			}
			lstMod7.DataSource = mod7List;
		}

		private void btnMod8_Click(object sender, EventArgs e)
		{
			lstMod8.DataSource = null;
			List<int> mod8List = new List<int>();
			for (int i = 1; i <= 100; i++)
			{
				if (i % 8 == 0)
				{
					mod8List.Add(i);
				}
			}
			lstMod8.DataSource = mod8List;
		}

		private void btnMod9_Click(object sender, EventArgs e)
		{
			lstMod9.DataSource = null;
			List<int> mod9List = new List<int>();
			for (int i = 1; i <= 100; i++)
			{
				if (i % 9 == 0)
				{
					mod9List.Add(i);
				}
			}
			lstMod9.DataSource = mod9List;
		}
	}
}
