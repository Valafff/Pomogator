using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pomogator
{
	public partial class ExpenceIncomeForm : Form
	{
		public ExpenceIncomeForm(Pomogator_MainForm parrent)
		{
			InitializeComponent();
			//Устаноыление связи с главной формой
			this.parrent = parrent;
			//Установление связи со вспомогательной формой
			source = new SourceCode(this);
			//создание провайдера
			provider = new DB_Provider();

			//Блок чтения данных из БД
			provider.openConnection(parrent.getPass(), parrent.mainIni.pathDB);
			parrent.IncomeExpenceData = provider.IEDataListRead();
			parrent.CurrencyPairs = provider.CurrencyPairReader();
			parrent.maxMyKey = provider.getMyKeyMax();
			provider.closeConnection();

			//Заполнение combobox формы ExpenceIncomeForm
			write_Category_fromIEListToComboBox(comboBox_Category, parrent.IncomeExpenceData);
			write_Kind_fromIEListToComboBox(comboBox_Kind, parrent.IncomeExpenceData);
			write_CurrencyPair_fromCurrencyPairListToCombobox(comboBox_CoinPair, parrent.CurrencyPairs);

			//Блок автозаполнения комбобокс
			AutoCompleteTextInComboBox(comboBox_Kind);
			AutoCompleteTextInComboBox(comboBox_Category);
			AutoCompleteTextInComboBox(comboBox_CoinPair);
			AutoCompleteTextInComboBox(comboBox_positionStatus);
			AutoCompleteTextInComboBox(toolStripComboBox_CategorySearch);

			//Получение валюты по умолчанию
			comboBox_CoinPair.Text = parrent.mainIni.defaultCoin;

			//Обновление даты
			dateTimePickerEnd.Value = DateTime.Now;
			dateTimePickerStart.Value = new DateTime(dateTimePickerEnd.Value.Year, 01, 01, 00, 00, 00);
			//dateTimePickerStart.Value = new DateTime(2019, 01, 01, 00, 00, 00);

			//Первоначальное чтение данных из таблицы
			btn_refreshDataGrid_Click(this, null);

            foreach (var item in bufferPositionsList)
			{
				bufferPositionsListOriginal.Add((Position)item.Clone());
			}
			toolStripComboBox_CategorySearch.Text = toolStripComboBox_CategorySearch.Items[0].ToString();
		}

		private void ExpenceIncomeForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			//Console.WriteLine("destr");
			provider.closeConnection();
			parrent.eiF = null;
		}

		private void comboBox_Kind_TextUpdate(object sender, EventArgs e)
		{
			if (!comboBox_Kind.Items.Contains(comboBox_Kind.Text) && comboBox_Kind.Items.Count < parrent.IncomeExpenceData.Count)
			{
				//Обновление видов
				comboBox_Kind.Items.Clear();
				foreach (var item in parrent.IncomeExpenceData)
				{
					comboBox_Kind.Items.Add(item.kind);
				}
				comboBox_Kind.SelectionStart = 1;
			}
			foreach (var item in parrent.IncomeExpenceData)
			{
				if (comboBox_Kind.Text == item.kind)
				{
					comboBox_Category.Text = item.category;
					if (item.type == "expence")
					{
						textBox_Income.Text = "0";
						textBox_Income.Enabled = false;
						textBox_Expence.Enabled = true;
					}
					else if (item.type == "income")
					{
						textBox_Expence.Text = "0";
						textBox_Expence.Enabled = false;
						textBox_Income.Enabled = true;
					}
					else
					{
						textBox_Expence.Text = "0";
						textBox_Expence.Enabled = true;
						textBox_Income.Enabled = true;
					}
					if (item.defaultStatus == "closed")
					{
						comboBox_positionStatus.Text = comboBox_positionStatus.Items[0].ToString();
					}
					else
					{
						comboBox_positionStatus.Text = comboBox_positionStatus.Items[1].ToString();
					}
					return;
				}
				comboBox_Category.Text = "Категория не определена";
				textBox_Expence.Enabled = true;
				textBox_Income.Enabled = true;
			}
		}
		private void comboBox_Category_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBox_Category.Items.Contains(comboBox_Category.Text) && comboBox_Category.Focused)
			{
				comboBox_Kind.Items.Clear();
				foreach (var item in parrent.IncomeExpenceData)
				{
					if (item.category == comboBox_Category.Text)
					{
						comboBox_Kind.Items.Add(item.kind);
					}
				}
				comboBox_Kind.Text = "";
			}
		}


		//Ввод десятичной дроби
		private void textBox_Income_KeyPress(object sender, KeyPressEventArgs e)
		{
			KeyboardChar = e.KeyChar;
			//if (!(Char.IsDigit(e.KeyChar)) && !((e.KeyChar == '.') && (textBox_Income.Text.IndexOf(".") == -1) && (textBox_Income.Text.Length != 0)))
			//{
			//	if (e.KeyChar != (char)Keys.Back)
			//	{
			//		e.Handled = true;
			//	}
			//}

			if (!(Char.IsDigit(e.KeyChar)) && !((e.KeyChar == ',') && (textBox_Income.Text.IndexOf(",") == -1) && (textBox_Income.Text.Length != 0)))
			{
				if (e.KeyChar != (char)Keys.Back)
				{
					e.Handled = true;
				}
			}
		}

		//Ввод десятичной дроби
		private void textBox_Expence_KeyPress(object sender, KeyPressEventArgs e)
		{
			KeyboardChar = e.KeyChar;
			//if (!(Char.IsDigit(e.KeyChar)) && !((e.KeyChar == '.') && (textBox_Income.Text.IndexOf(".") == -1) && (textBox_Income.Text.Length != 0)))
			//{
			//	if (e.KeyChar != (char)Keys.Back)
			//	{
			//		e.Handled = true;
			//	}
			//}

			if (!(Char.IsDigit(e.KeyChar)) && !((e.KeyChar == ',') && (textBox_Expence.Text.IndexOf(",") == -1) && (textBox_Expence.Text.Length != 0)))
			{
				if (e.KeyChar != (char)Keys.Back)
				{
					e.Handled = true;
				}
			}
		}

		private void btn_writePosition_Click(object sender, EventArgs e)
		{
			//Предварительная подготовка записи
			textBox_Income.Text = source.dotTocommaRepair(textBox_Income.Text);
			textBox_Expence.Text = source.dotTocommaRepair(textBox_Expence.Text);

			//if (textBox_Expence.Text == "") { textBox_Expence.Text = "0"; }
			//if (textBox_Income.Text == "") { textBox_Income.Text = "0"; }

			if (comboBox_Kind.Text != "" && comboBox_Category.Text != "" && (textBox_Income.Text != "" || textBox_Expence.Text != ""))
			{
				//Запись простой или первой позиции 
				if (bufferPosition == null)
				{
					provider.openConnection(parrent.getPass(), parrent.mainIni.pathDB);
					//Всегда прибавляется 1 к максимальному значению myKey
					bufferPosition = new Position(0, provider.getMyKeyMax() + (uint)AddID.simplPosition, dateTimePicker_open.Value, source.getCloseDateFromForm(comboBox_positionStatus),/*дата закрытия*/
					 comboBox_Kind.Text, comboBox_Category.Text, Convert.ToDecimal(textBox_Income.Text),
					 Convert.ToDecimal(textBox_Expence.Text), Convert.ToUInt32(numericUpDown_numberLots.Value), comboBox_CoinPair.Text,
					 source.getSaldoFromForm(Convert.ToDecimal(textBox_Income.Text), Convert.ToDecimal(textBox_Expence.Text)), /*сальдо*/
					 comboBox_positionStatus.Text, tb_tag.Text, textBox_notes.Text);

					////Отладка
					//Console.WriteLine(bufferPosition.key);
					//Console.WriteLine(bufferPosition.myKey);
					//Console.WriteLine(bufferPosition.openDate);
					//Console.WriteLine(bufferPosition.closeDate);
					//Console.WriteLine(bufferPosition.kind);
					//Console.WriteLine(bufferPosition.category);
					//Console.WriteLine(bufferPosition.income);
					//Console.WriteLine(bufferPosition.expence);
					//Console.WriteLine(bufferPosition.lotCount);
					//Console.WriteLine(bufferPosition.currCoin);
					//Console.WriteLine(bufferPosition.saldo);
					//Console.WriteLine(bufferPosition.status);
					//Console.WriteLine(bufferPosition.tag);
					//Console.WriteLine(bufferPosition.notes);

					if (provider.addPositionToDB(bufferPosition))
					{
						bufferPosition = null;
						clearAllFilds();
					}
					else
					{
						bufferPosition = null;
						MessageBox.Show("Позиция не записана");
					}
					provider.closeConnection();
				}
				//Дозапись комплексной позиции
				else if (bufferPosition.status == "открыта")
				{
					provider.openConnection(parrent.getPass(), parrent.mainIni.pathDB);
					//Всегда прибавляется 0 к максимальному значению myKey
					bufferPosition = new Position(0, bufferPosition.myKey, dateTimePicker_open.Value, source.getCloseDateFromForm(comboBox_positionStatus),/*дата закрытия*/
					 comboBox_Kind.Text, comboBox_Category.Text, Convert.ToDecimal(textBox_Income.Text),
					 Convert.ToDecimal(textBox_Expence.Text), Convert.ToUInt32(numericUpDown_numberLots.Value), comboBox_CoinPair.Text,
					 source.getSaldoFromForm(Convert.ToDecimal(textBox_Income.Text), Convert.ToDecimal(textBox_Expence.Text)), /*сальдо*/
					 comboBox_positionStatus.Text, tb_tag.Text, textBox_notes.Text);

					if (provider.addPositionToDB(bufferPosition))
					{
						if (bufferPosition.status == "закрыта")
						{
							bufferPosition = null;
							//complexPositon = false;
							btn_writePosition.Enabled = false;
						}
						else
						{
							//Если позиция была комплексной и закрыта - дозапись невозможна
							//complexPositon = true;

						}
						//MessageBox.Show("Позиция записана");
						clearAllFilds();
					}
					else
					{
						bufferPosition = null;
						MessageBox.Show("Позиция не записана");
					}
					provider.closeConnection();
				}
			}
			else
			{
				MessageBox.Show("Заполнены не все поля");
			}

			btn_refreshDataGrid_Click(this, e);
			bufferPositionsList.Reverse();
			//Обновление видов
			comboBox_Kind.Items.Clear();
			dateTimePickerEnd.Value = DateTime.Now;
			dateTimePickerStart.Value = new DateTime(dateTimePickerEnd.Value.Year, 01, 01, 00, 00, 00);


			foreach (var item in parrent.IncomeExpenceData)
			{
				comboBox_Kind.Items.Add(item.kind);
				//Console.WriteLine(item.kind);
			}
		}

		private void comboBox_GroupData_SelectedIndexChanged(object sender, EventArgs e)
		{
			positionSort(this, e);
			isRevers = false;
		}

		private void btn_refreshDataGrid_Click(object sender, EventArgs e)
		{
			provider.openConnection(parrent.getPass(), parrent.mainIni.pathDB);
			bufferPositionsList = provider.readPositionsFromBD();
			provider.closeConnection();

			//Фильтрует в установленном временном диапазоне по задумке начало- начало текущего года, конец сегодняшняя дата
			List<Position> newPosList = new List<Position>();
			foreach (var pos in bufferPositionsList)
			{
				if (pos.openDate >= dateTimePickerStart.Value && pos.openDate <= dateTimePickerEnd.Value)
				{
					var temp = (Position)pos.Clone();
					newPosList.Add(temp);
				}
			}
			bufferPositionsList = newPosList;
			bindingPositionsBufferListWithDataGridView(this, e);

			for (int i = 0; i < dataGridView_positions.Rows.Count; i++)
			{
				//было
				//if (dataGridView_positions.Rows[i].Cells[2].Value.ToString() == "30.12.9999 0:00:00" || dataGridView_positions.Rows[i].Cells[2].Value.ToString() == "31.12.9999 0:00:00")
				if (dataGridView_positions.Rows[i].Cells[2].Value.ToString() == DateTime.MaxValue.ToString())
				{
					dataGridView_positions.Rows[i].Cells[2].Value = null;
				}
			}
			////Связывание позиций с таблицей dataGridView_Position
			//Load += new System.EventHandler(bindingPositionsBufferListWithDataGridView);
		}

		//Чтение позиции из листа
		private void dataGridView_positions_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{

			//textBox_notes.Text = e.RowIndex.ToString();
			//textBox_notes.Text = dataGridView_positions.CurrentRow.Cells[8].Value.ToString();
			//Получение данных из выделенной строки таблицы
			Position positionFromDataGrid = (Position)dataGridView_positions.CurrentRow.DataBoundItem;
			bufferPosition = new Position();

			////Получение статуса позиции
			//string tempStatus = dataGridView_positions.CurrentRow.Cells[8].Value.ToString();

			//Вспомогательные переменные
			decimal tempTotalIncome = 0;
			decimal tempTotalExpence = 0;

			List<Position> tempComplexPosition = new List<Position>();

			//Запись выбранной позиции во временную комплексную позицию bufferPositionsList
			foreach (var item in bufferPositionsList)
			{
				//Создаю поверхностные копии выбранных позиций и добавляю их во временную позицию
				if (positionFromDataGrid.myKey == item.myKey)
				{
					var temp = (Position)item.Clone();
					tempTotalIncome += temp.income;
					//Console.WriteLine("income " + tempTotalIncome + " item income " + item.income);
					tempTotalExpence += temp.expence;
					//Console.WriteLine("expence " + tempTotalExpence + " item expence " + item.expence);
					tempComplexPosition.Add(temp);
					//Console.WriteLine(temp);
				}
			}

			//Получение  позиции с последней датой открытия/редактирования
			DateTime maxdate = DateTime.MaxValue;
			DateTime tempCloseDate = new DateTime();
			foreach (var item in tempComplexPosition)
			{
				//Читаю список временных позиций, создаю копию позиции с большей датой

				if (item.openDate >= maxdate)
				{
					var temp = (Position)item.Clone();
					maxdate = temp.openDate;
					bufferPosition = temp;
				}
				//Если во временном листе позиций нахожу вменяемую дату - записываю ее в closeDate
				//было 
				//if (item.closeDate.ToString() != "01.01.0001 0:00:00")
				if (item.closeDate != DateTime.MinValue)
				{
					var temp = (Position)item.Clone();
					tempCloseDate = temp.closeDate;
				}
			}
			try
			{
				//Получение конечных данных позиции

				bufferPosition.key = positionFromDataGrid.key;
				bufferPosition.myKey = positionFromDataGrid.myKey;
				bufferPosition.openDate = positionFromDataGrid.openDate;
				bufferPosition.closeDate = tempCloseDate;
				bufferPosition.kind = positionFromDataGrid.kind;
				bufferPosition.category = positionFromDataGrid.category;
				bufferPosition.income = tempTotalIncome;
				bufferPosition.expence = tempTotalExpence;
				bufferPosition.currCoin = positionFromDataGrid.currCoin;
				bufferPosition.tag = positionFromDataGrid.tag;
				bufferPosition.notes = positionFromDataGrid.notes;
				bufferPosition.status = positionFromDataGrid.status;
				bufferPosition.saldo = bufferPosition.income - bufferPosition.expence;
			}
			catch (Exception)
			{

				throw;
			}

			//Не дает закрыть еще раз уже закрытую комплексную позицию
			if (bufferPosition.status == "открыта" && source.isClosedPosition(tempComplexPosition))
			{
				//complexPositon = true;
				btn_deletePosition.Enabled = true;
				btn_UpdatePosition.Enabled = true;
				btn_writePosition.Enabled = false;
				comboBox_positionStatus.Text = comboBox_positionStatus.Items[1].ToString();
				isAllReadyClosed = true;
			}
			else if (bufferPosition.status == "открыта" && !source.isClosedPosition(tempComplexPosition))
			{
				//complexPositon = true;
				btn_deletePosition.Enabled = true;
				btn_UpdatePosition.Enabled = true;
				btn_writePosition.Enabled = true;
				comboBox_positionStatus.Text = comboBox_positionStatus.Items[1].ToString();
				isAllReadyClosed = false;
			}
			else
			{
				//complexPositon = false;
				btn_deletePosition.Enabled = true;
				btn_UpdatePosition.Enabled = true;
				btn_writePosition.Enabled = false;
				comboBox_positionStatus.Text = comboBox_positionStatus.Items[0].ToString();
				isAllReadyClosed = false;
			}
			source.setPositionToInfoTable();
			if (bufferPosition != null)
			{
				dateTimePicker_open.Value = bufferPosition.openDate;
				comboBox_Category.Text = bufferPosition.category;
				comboBox_Kind.Text = bufferPosition.kind;
				textBox_Income.Text = positionFromDataGrid.income.ToString();
				textBox_Expence.Text = positionFromDataGrid.expence.ToString();
				//textBox_Income.Text = "0";
				//textBox_Expence.Text = "0";
				numericUpDown_numberLots.Value = positionFromDataGrid.lotCount;
				comboBox_CoinPair.Text = bufferPosition.currCoin;
				comboBox_positionStatus.Text = bufferPosition.status;
				tb_tag.Text = bufferPosition.tag;
				textBox_notes.Text = bufferPosition.notes;
			}
			else
			{
				clearAllFilds();
			}
			//Console.WriteLine(isAllReadyClosed);
		}

		private void создатьНовуюПозициюToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//Обновление видов
			comboBox_Kind.Items.Clear();
			foreach (var item in parrent.IncomeExpenceData)
			{
				comboBox_Kind.Items.Add(item.kind);
			}

			btn_deletePosition.Enabled = false;
			btn_UpdatePosition.Enabled = false;
			btn_writePosition.Enabled = true;
			//complexPositon = false;
			source.delBufferPosition();
			clearAllFilds();
		}
		//Изменение выделенной позиции
		private void btn_UpdatePosition_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Позиция будет перезаписана. Осуществить перезапись?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				if (bufferPosition == null)
				{
					MessageBox.Show("Позиция для перзаписи отсутствует");
				}
				else if (comboBox_Kind.Text != "" && comboBox_Category.Text != "" && (textBox_Income.Text != "" || textBox_Expence.Text != ""))
				{
					//Проверка даты закрытия
					//Если позиция открыта
					if (comboBox_positionStatus.Text == "открыта")
					{
						bufferPosition.closeDate = DateTime.MaxValue;
					}
					else
					{
						bufferPosition.closeDate = DateTime.Now;
					}
					bufferPosition.openDate = dateTimePicker_open.Value;
					bufferPosition.category = comboBox_Category.Text;
					bufferPosition.kind = comboBox_Kind.Text;
					bufferPosition.income = Convert.ToDecimal(textBox_Income.Text);
					bufferPosition.expence = Convert.ToDecimal(textBox_Expence.Text);
					bufferPosition.lotCount = Convert.ToUInt32(numericUpDown_numberLots.Value);
					bufferPosition.currCoin = comboBox_CoinPair.Text;
					//проверка можно ли закрыть комплексную позицию
					if (isAllReadyClosed && comboBox_positionStatus.Text == "закрыта")
					{
						MessageBox.Show("Нельзя два раза закрыть одну и ту же позицию");
						return;
					}
					bufferPosition.status = comboBox_positionStatus.Text;
					bufferPosition.tag = tb_tag.Text;
					bufferPosition.notes = textBox_notes.Text;
					bufferPosition.saldo = source.getSaldoFromForm(bufferPosition.income, bufferPosition.expence);
					provider.openConnection(parrent.getPass(), parrent.mainIni.pathDB);
					if (!provider.updatePosition(bufferPosition))
					{
						MessageBox.Show("Позиция не изменена");
					}
					provider.closeConnection();
				}
				else
				{
					MessageBox.Show("Заполнены не все поля");
				}

				btn_refreshDataGrid_Click(this, e);
				//Обновление видов
				comboBox_Kind.Items.Clear();
				foreach (var item in parrent.IncomeExpenceData)
				{
					comboBox_Kind.Items.Add(item.kind);
				}
			}
		}

		private void btn_deletePosition_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Запись будет безвозвратно удалена. Удалить запись?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				if (bufferPosition == null)
				{
					MessageBox.Show("Позиция для перзаписи отсутствует");
				}
				else
				{
					provider.openConnection(parrent.getPass(), parrent.mainIni.pathDB);
					if (!provider.deletePosition(bufferPosition))
					{
						MessageBox.Show("Позиция не удалена");
					}
					provider.closeConnection();
				}
				source.delBufferPosition();
				clearAllFilds();
				btn_deletePosition.Enabled = false;
				btn_UpdatePosition.Enabled = false;
				btn_writePosition.Enabled = true;
				btn_refreshDataGrid_Click(this, e);
				//Обновление видов
				comboBox_Kind.Items.Clear();
				foreach (var item in parrent.IncomeExpenceData)
				{
					comboBox_Kind.Items.Add(item.kind);
				}
			}
		}

		private void btn_sortDatafromDB_Click(object sender, EventArgs e)
		{
			if (!isRevers)
			{
				bufferPositionsList.Reverse();
				bindingPositionsBufferListWithDataGridView(sender, e);
				isRevers = !isRevers;
			}
			else
			{
				positionSort(sender, e);
				//bindingPositionsBufferListWithDataGridView(sender, e);
				isRevers = !isRevers;
			}

		}
		//Корректирую время для точного поиска
		private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
		{
			var newDate = new DateTime(dateTimePickerEnd.Value.Year, dateTimePickerEnd.Value.Month, dateTimePickerEnd.Value.Day, 23, 59, 59);
			dateTimePickerEnd.Value = newDate;
		}

		private void textBox_Income_TextChanged(object sender, EventArgs e)
		{
			textBox_Income.Text = source.dotTocommaRepair(textBox_Income.Text);
			textBox_Income.SelectionStart = textBox_Income.Text.Length;
		}

		private void textBox_Expence_TextChanged(object sender, EventArgs e)
		{
			textBox_Expence.Text = source.dotTocommaRepair(textBox_Expence.Text);
			textBox_Expence.SelectionStart = textBox_Expence.Text.Length;
		}

		private void lb_IDInfo_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			try
			{
				if (sender is Label)
				{
					Clipboard.SetText(((Label)sender).Text.ToString());
					toolStripStatusLabelBufferNowData.Text = ((Label)sender).Text.ToString();
				}
				if (sender is TextBox)
				{
					Clipboard.SetText(((TextBox)sender).Text.ToString());
					toolStripStatusLabelBufferNowData.Text = ((TextBox)sender).Text.ToString();
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Данные отсутствуют");
				toolStripStatusLabelBufferNowData.Text = "null";
			}
		}

		//Поиск
		private void toolStripTextBox_search_TextChanged(object sender, EventArgs e)
		{
			//Console.WriteLine(bufferPositionsList.Count);
			//Console.WriteLine(bufferPositionsListOriginal.Count);
			//Если что-то ищем и позиция текущего буффера отличается от оригинала, переписываю оригинал, чтобы возвратить полный список когда в поиске ничего не будет
			if ((toolStripTextBox_search.Text != "" || toolStripTextBox_search.Text != "Поиск") && bufferPositionsList.Count != bufferPositionsListOriginal.Count)
			{
				bufferPositionsListOriginal.Clear();
				foreach (var item in bufferPositionsList)
				{
					bufferPositionsListOriginal.Add((Position)item.Clone());
				}
				bindingPositionsBufferListWithDataGridView(sender, e);
			}
			//Если в поиске ничего нет - возвращается оригинал данных
			if (toolStripTextBox_search.Text == "" || toolStripTextBox_search.Text == "Поиск")
			{
				bufferPositionsList = bufferPositionsListOriginal;
				bindingPositionsBufferListWithDataGridView(sender, e);
				return;
			}
			//Если что-то ищем
			searchHendler(toolStripComboBox_CategorySearch.Text);

		}

		private void comboBox_CoinPair_SelectedIndexChanged(object sender, EventArgs e)
		{
			getMonthIncomExpenseSaldoToolStripStatus(bufferPositionsList);
		}

		private void toolStripComboBox_DefaultCoin_TextChanged(object sender, EventArgs e)
		{
			if (toolStripComboBox_DefaultCoin.SelectedIndex != -1)
			{
				parrent.reWriteDefaultCoin(toolStripComboBox_DefaultCoin.Items[toolStripComboBox_DefaultCoin.SelectedIndex].ToString());
				comboBox_CoinPair.Text = toolStripComboBox_DefaultCoin.Text;
			}

		}
	}
}


