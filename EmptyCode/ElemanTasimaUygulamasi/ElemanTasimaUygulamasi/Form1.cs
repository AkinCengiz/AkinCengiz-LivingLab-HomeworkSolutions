using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElemanTasimaUygulamasi
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		List<string> solElemanlar;
		List<string> sagElemanlar;
		private void Form1_Load(object sender, EventArgs e)
		{
			solElemanlar = new List<string>() { "Kalem", "Defter", "Silgi", "Kitap", "Cetvel", "Pergel", "Boya" };
			sagElemanlar = new List<string>();
			ListFill();
		}

		private void btnMoveRight_Click(object sender, EventArgs e)
		{
			
		}

		private void btnMoveLeft_Click(object sender, EventArgs e)
		{
			
		}

		void ListFill()
		{
			lstLeft.DataSource = null;
			lstRight.DataSource = null;
			lstLeft.DataSource = solElemanlar;
			lstRight.DataSource = sagElemanlar;
		}
	}
}
