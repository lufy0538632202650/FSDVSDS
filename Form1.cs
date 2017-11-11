using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LFY_Bit8
{
	public partial class Frm_BiwTestBit8 : Form
	{
		byte var = 0;
		public Frm_BiwTestBit8()
		{
			InitializeComponent();
		}
		private void NubBtnClick(Button btn)
		{
			if (btn.Text == "0")
			{
				btn.Text = "1";
			}
			else
			{
				btn.Text = "0";
			}
		}
		private void ODLblChange(byte byt)
		{
			this.Lbl_OLbl.Text =byt.ToString();
			this.Lbl_DLbl.Text = Convert.ToString(var,16);
		}
	     private void Btn_OneBtn_Click(object sender, EventArgs e)
		{	
			var = (Byte)(var^1);
			NubBtnClick(Btn_OneBtn);
			ODLblChange(var);
		}

		private void Btn_TwoBtn_Click(object sender, EventArgs e)
		{
			var = (Byte)(var^2);
			NubBtnClick(Btn_TwoBtn);
			ODLblChange(var);
		}

		private void Btn_ThrBtn_Click(object sender, EventArgs e)
		{
			var = (Byte)(var^4);
			NubBtnClick(Btn_ThrBtn);
			ODLblChange(var);
		}

		private void Btn_FouBtn_Click(object sender, EventArgs e)
		{
			var = (Byte)(var^8);
			NubBtnClick(Btn_FouBtn);
			ODLblChange(var);
		}

		private void Btn_FivBtn_Click(object sender, EventArgs e)
		{
			var = (Byte)(var^16);
			NubBtnClick(Btn_FivBtn);
			ODLblChange(var);
		}

		private void Btn_SixBtn_Click(object sender, EventArgs e)
		{
			var = (Byte)(var^32);
			NubBtnClick(Btn_SixBtn);
			ODLblChange(var);
		}

		private void Btn_SevBtn_Click(object sender, EventArgs e)
		{
			var = (Byte)(var^64);
			NubBtnClick(Btn_SevBtn);
			ODLblChange(var);
		}

		private void Btn_ElgBtn_Click(object sender, EventArgs e)
		{
			var = (Byte)(var^128);
			NubBtnClick(Btn_ElgBtn);
			ODLblChange(var);
		}
	}
}
