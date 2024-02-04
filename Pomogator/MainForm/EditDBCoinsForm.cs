using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pomogator.MainForm
{
	public partial class EditDBCoinsForm : Form
	{
		Pomogator_MainForm parrent;
		DB_Provider provider;
		//Currency temp = new Currency();


		BindingList<Currency> bind = new BindingList<Currency>();
		

		public EditDBCoinsForm(Pomogator_MainForm parrent)
		{
			InitializeComponent();
			this.parrent = parrent;
			provider = new DB_Provider();
			provider.openConnection(parrent.getPass(), parrent.mainIni.pathDB);
			parrent.CurrencyNames = provider.CurrencyNameReader();
			provider.closeConnection();
			bindingCurrency(parrent.CurrencyNames);
			listBox_coinsNameList.DataSource = bind;
		}

		private void EditDBCoinsForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			provider.closeConnection();
			parrent.editDBCoinsForm = null;
		}

		void bindingCurrency(List<Currency> currencies)
		{
			foreach (Currency cur in currencies)
			{
                bind.Add(cur);
			}
		}

		private void listBox_coinsNameList_SelectedIndexChanged(object sender, EventArgs e)
		{
			Currency temp = new Currency();
			//temp = new Currency();
			temp = parrent.CurrencyNames[listBox_coinsNameList.SelectedIndex];
			dateTimePicker_addDateNewCoin.Value = temp.date;
			textBox_coinName.Text = temp.currencyName;
			textBox_coinShortName.Text = temp.shortCurrencyName;
			EditDBCoinsForm_Load(sender, e);

			//Console.WriteLine($"Сейчас выбран {temp.key}");
		}

		private void EditDBCoinsForm_Load(object sender, EventArgs e)
		{
			if (textBox_coinName.Text == "" & textBox_coinShortName.Text == "")
			{
				button_newCoinName.Enabled = true;
				button_editCoinName.Enabled = false;
				button_delCoinName.Enabled = false;
			}
			else
			{
				button_newCoinName.Enabled = true;
				button_editCoinName.Enabled = true;
				button_delCoinName.Enabled = true;
			}

		}

		private void textBox_coinName_TextChanged(object sender, EventArgs e)
		{
			//if (textBox_coinName.Text == "" & textBox_coinShortName.Text == "")
			//{
			//	button_newCoinName.Enabled = true;
			//	button_editCoinName.Enabled = false;
			//	button_delCoinName.Enabled = false;
			//}
		}

		private void button_newCoinName_Click(object sender, EventArgs e)
		{
			Currency temp = new Currency();
			temp.date = dateTimePicker_addDateNewCoin.Value;
			temp.currencyName = textBox_coinName.Text;
			temp.shortCurrencyName = textBox_coinShortName.Text;
			foreach (var item in parrent.CurrencyNames)
			{
				if (item.currencyName == temp.currencyName || item.shortCurrencyName == temp.shortCurrencyName)
				{
					MessageBox.Show("Такая валюта уже есть!", "Повторная запись", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}
			//Запись в БД
			provider.openConnection(parrent.getPass(), parrent.mainIni.pathDB);
			try
			{

				temp.key = provider.addCurrencyNameToDB(temp);
				//this.temp = temp;
				//Добавление в лист данных программы и в биндинг лист
				parrent.CurrencyNames.Add(temp);
				bind.Add(temp);
				//MessageBox.Show("Валюта добавлена в БД!", "Успешная запись", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception)
			{
				MessageBox.Show("Валюта не записана", "Ошибка записи в БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			provider.closeConnection();
		}

		private void button_editCoinName_Click(object sender, EventArgs e)
		{
			Currency temp = new Currency();
			int index = listBox_coinsNameList.SelectedIndex;
			temp.date = dateTimePicker_addDateNewCoin.Value;
			temp.currencyName = textBox_coinName.Text;
			temp.shortCurrencyName = textBox_coinShortName.Text;
			temp.key = parrent.CurrencyNames[index].key;

			Console.WriteLine(temp.key);
			DialogResult res = MessageBox.Show($"Вы собираетесь изменить валюту: {listBox_coinsNameList.Items[index]} на: {temp}", "Изменение данных", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (res == DialogResult.Yes)
			{

				provider.openConnection(parrent.getPass(), parrent.mainIni.pathDB);
				try
				{
					temp.key = provider.updateCurrency(temp);

					bind.RemoveAt(index);
					bind.Insert(index, temp);
					listBox_coinsNameList.SelectedIndex = index;

					parrent.CurrencyNames[index].date = temp.date;
					parrent.CurrencyNames[index].currencyName = temp.currencyName;
					parrent.CurrencyNames[index].shortCurrencyName = temp.shortCurrencyName;
				}
				catch (Exception)
				{
					MessageBox.Show("Валюта не отредактирована", "Ошибка записи в БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				provider.closeConnection();
			}
		}

		private void button_delCoinName_Click(object sender, EventArgs e)
		{
			Currency temp = new Currency();
			int index = listBox_coinsNameList.SelectedIndex;
			temp.date = dateTimePicker_addDateNewCoin.Value;
			temp.currencyName = textBox_coinName.Text;
			temp.shortCurrencyName = textBox_coinShortName.Text;
			temp.key = parrent.CurrencyNames[listBox_coinsNameList.SelectedIndex].key;
			DialogResult res = MessageBox.Show($"Вы собираетесь удалить валюту: {listBox_coinsNameList.Items[index]} Нажмите ДА чтобы продолжить", "Изменение данных", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (res == DialogResult.Yes)
			{
				provider.openConnection(parrent.getPass(), parrent.mainIni.pathDB);
				if (provider.deleteCurrency(temp))
				{
					bind.RemoveAt(index);
					//bind.Insert(index, temp);
					//listBox_coinsNameList.SelectedIndex = index;

					parrent.CurrencyNames.RemoveAt(index);
				}
				else
				{
					MessageBox.Show("Валюта не удалена", "Ошибка записи в БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				provider.closeConnection();
			}
		}


	}
}
