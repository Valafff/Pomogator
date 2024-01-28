using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Pomogator
{
	public partial class Pomogator_MainForm : Form
	{
		//ПАРОЛЬ
		string password;
		public void setPass(string pass)
		{
			password = pass;
		}
		public string getPass()
		{
			return password;
		}
		//ПАРОЛЬ

		//Объявление и инициализация формы приход/расход для исключения множественного открытия
		public ExpenceIncomeForm eiF = null;

		//Объявление базовых списков переменных(классы в файле SourceCode.cs)
		public List<IncomeExpenceData> IncomeExpenceData = new List<IncomeExpenceData>();
		public List<CurrencyPair> CurrencyPairs = new List<CurrencyPair>();
		//Класс Position хранится в файле Position.cs
		public List<Position> Positions = new List<Position>();
		public uint maxMyKey;

		DB_Provider provider = new DB_Provider();

		public Pomogator_MainForm()
		{
			serialization();
			InitializeComponent();
			openFileDialogDB_path.Filter = "mdb files (*.mdb)|*.mdb";
			//!!!!НЕ ДАЕТ СЛИВАТЬСЯ МЕНЮШКАМ ДОЧЕРНЕГО ЭЛЕМЕНТА С РОДИТЕЛЬСКИМ!!!!
			menuStrip1.AllowMerge = false;
			startMenuForm startMenu = new startMenuForm(this);
			startMenu.MdiParent = this;
			startMenu.StartPosition = FormStartPosition.CenterScreen;
			startMenu.Show();
		}

		private void выходToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		//открытие окна учета прихода и расхода

		public void расходПриходToolStripMenuItem_Click(object sender, EventArgs e)
		{
			PassForm pf = new PassForm(this);
			pf.StartPosition = FormStartPosition.CenterScreen;
			pf.ShowDialog();

			// sender StripMenu Item, e - клик мыши
			if (eiF == null)
			{
				bool testconnection = provider.openConnection(password, mainIni.pathDB);
				if (pf.DialogResult == DialogResult.OK && testconnection)
				{
					Position p = provider.GetPosition(provider.getMyKeyMax());
					if (p == null)
					{
						MessageBox.Show("Ошибка чтения данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}

					eiF = new ExpenceIncomeForm(this);
					eiF.MdiParent = this;
					eiF.Show();
				}
				else if (pf.DialogResult == DialogResult.OK && !testconnection)
				{
					MessageBox.Show("Пароль не принят, в доступе отказано");
				}
				if (testconnection)
					provider.closeConnection();
			}
		}

		private void ToolStripMenuItem_importBD_v1_07_Click(object sender, EventArgs e)
		{
			DialogResult res = openFileDialogDB_path.ShowDialog();
			if (res == DialogResult.OK)
			{				
				try
				{
                    //Уже прочитало в необработанный лист данных tempDBdata_1_07
                    importDB_1_07(openFileDialogDB_path.FileName);
					//Адаптация листа данных adaptedTempList
					trancelate();
					//Записываю адаптированные позиции в БД
					provider.openConnection();
					uint myKey = provider.getMyKeyMax();
					foreach (var item in adaptedTempList)
					{
						item.myKey = myKey;
						myKey++;
						provider.addPositionToDB(item);
					}
					provider.closeConnection();
					MessageBox.Show("Данные импортированы, нажмите Обновить данные");
				}
				catch (Exception)
				{
					MessageBox.Show("Данные не импортированы");
				}
			}
		}

		private void задатьПутьБДToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult res = openFileDialogDB_path.ShowDialog();
			if (res == DialogResult.OK)
			{
				mainIni.pathDB = openFileDialogDB_path.FileName;
				reWritePathDB(mainIni.pathDB);
				MessageBox.Show("Новый путь к БД назначен. Обновите данные в таблице");
			}


		}

		private void созданиеРезервнойКопииToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				DialogResult res = folderBrowserDialog_BackUp.ShowDialog();
				if (res == DialogResult.OK)
				{
					string[] arrayFileName = mainIni.pathDB.Split('\\');
					string tempFileName = arrayFileName[arrayFileName.Count() - 1];
					string timeNow = DateTime.Now.ToLongTimeString();
					string dateNow = DateTime.Now.ToShortDateString();
					string[] temptime = timeNow.Split(':');
					string time = temptime[0] + "h" + temptime[1] + "m" + temptime[2] + "sec";
					timeNow = timeNow.Replace(':', '_');
					File.Copy(mainIni.pathDB, $"{folderBrowserDialog_BackUp.SelectedPath}\\backup_{time}_{tempFileName}", true);
				}
			}
			catch (Exception)
			{

				MessageBox.Show("Путь к исходному файлу не найден. Укажите новый путь");
				задатьПутьБДToolStripMenuItem_Click(this, e);
			}



		}
	}
}
