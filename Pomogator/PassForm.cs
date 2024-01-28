using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pomogator
{
	public partial class PassForm : Form
	{
		//Объявляем объект главной формы 
		Pomogator_MainForm parrent;
		//Передаю этот объект в качестве параметра в конструктор
		//Через этот объект буду передавать данные в главную форму
		public PassForm(Pomogator_MainForm parrent)
		{
			//CenterToParent();
			InitializeComponent();
			this.parrent = parrent;

		}

		private void btn_Cancel_Click(object sender, EventArgs e)
		{
			//Visible = false;
			DialogResult = DialogResult.Cancel;
			Close();

		}

		private void btn_OK_Click(object sender, EventArgs e)
		{
			parrent.setPass(PassTextBox.Text);
			//Visible = false;
			DialogResult = DialogResult.OK;
			Close();

		}

		private void PassTextBox_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btn_OK_Click((object)sender, e);
			}
			if (e.KeyCode == Keys.Escape)
			{
				btn_Cancel_Click((object)sender, e);
			}
		}
	}
}
