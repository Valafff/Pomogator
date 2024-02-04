using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Pomogator
{
	//Вспомогательные данные
	partial class ExpenceIncomeForm
	{
		//Блок вспомогательных переменных
		Pomogator_MainForm parrent;
		SourceCode source;
		DB_Provider provider;

		//если false - комплексная позиция не закрыта, true - закрыта
		bool isAllReadyClosed = false;
		//bool complexPositon = false;
		bool isRevers = false;
		public char KeyboardChar;
		//Временная позиция для записи и чтения из БД
		public Position bufferPosition = null;
		//Лист позиций читаемых и записываемых из БД
		public List<Position> bufferPositionsList = new List<Position>();
		public List<Position> bufferPositionsListOriginal = new List<Position>();
		//Связывание данных
		public BindingSource bindingSourcePosition = new BindingSource();

		//Связывание листа позиций с dataGridView
		public void bindingPositionsBufferListWithDataGridView(object sender, System.EventArgs e)
		{
			dataGridView_positions.Rows.Clear();
			BindingList(bufferPositionsList);
			toolStripStatusLabel_numberPositions.Text = $"Прочитано данных: {bufferPositionsList.Count}";
		}


		/// <summary>
		/// Автозаполнение
		/// </summary>

		//Вспомогательная функция для автоподстановки TextBox
		public string[] getStringArrayFromComboBox(ComboBox _combo)
		{
			string[] temp = new string[_combo.Items.Count];
			for (int i = 0; i < _combo.Items.Count; i++)
			{
				temp[i] = _combo.Items[i].ToString();
			}

			return temp;
		}


		//Полная функция для автоподстановки ComboBox
		public void AutoCompleteTextInComboBox(ComboBox _combo)
		{
			string[] temp = new string[_combo.Items.Count];
			for (int i = 0; i < _combo.Items.Count; i++)
			{
				temp[i] = _combo.Items[i].ToString();
			}
			_combo.AutoCompleteCustomSource.AddRange(getStringArrayFromComboBox(_combo));
			_combo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			_combo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
		}

		//Полная функция для автоподстановки ToolStripComboBox
		public void AutoCompleteTextInComboBox(ToolStripComboBox _combo)
		{
			string[] temp = new string[_combo.Items.Count];
			for (int i = 0; i < _combo.Items.Count; i++)
			{
				temp[i] = _combo.Items[i].ToString();
			}
			_combo.AutoCompleteCustomSource.AddRange(temp);
			_combo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			_combo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
		}

		//Запись данных IncomExpence из List в элементы формы
		public void write_Category_fromIEListToComboBox(ComboBox _combo, List<IncomeExpenceData> _data)
		{
			_combo.Items.Clear();
			_combo.Text = "";
			foreach (var item in _data)
			{
				if (!_combo.Items.Contains(item.category))
				{
					_combo.Items.Add(item.category);
				}
			}
		}

		public void write_Kind_fromIEListToComboBox(ComboBox _combo, List<IncomeExpenceData> _data)
		{
			_combo.Items.Clear();
			_combo.Text = "";
			foreach (var item in _data)
			{
				if (!_combo.Items.Contains(item.kind))
				{
					_combo.Items.Add(item.kind);
				}
			}
		}

		public void write_CurrencyPair_fromCurrencyPairListToCombobox(ComboBox _combo, List<CurrencyPair> _data)
		{
			_combo.Items.Clear();
			_combo.Text = "";
			foreach (var item in _data)
			{
				if (!_combo.Items.Contains(item.shortPairName))
				{
					_combo.Items.Add(item.shortPairName);
				}
			}
			_combo.Text = _combo.Items[0].ToString();
		}

		/// <summary>
		/// Автозаполнение конец
		/// </summary>

		//Не дает форме закрыться при выполнении Close()
		private void ExpenceIncomeForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			////Не дает форме закрыться при выполнении Close()
			//if (!saved)
			//{
			//	//cancel=true форма не закрывается
			//	e.Cancel = true;
			//	MessageBox.Show("Сохрани введенные данные");
			//}
		}

		//Запись позиции
		enum AddID
		{
			complexPosition,
			simplPosition
		}

		//Очистка всех значений у элементов формы, кроме таблицы
		void clearAllFilds()
		{
			comboBox_Kind.Text = "";
			comboBox_Category.Text = "";
			textBox_Income.Text = "0";
			textBox_Expence.Text = "0";
			numericUpDown_numberLots.Value = 1;
			comboBox_CoinPair.Text = comboBox_CoinPair.Items[0].ToString();
			comboBox_positionStatus.Text = comboBox_positionStatus.Items[0].ToString();
			tb_tag.Text = "";
			textBox_notes.Text = "";
			toolStripTextBox_search.Text = "Поиск";
			toolStripTextBox_search.ForeColor = Color.Gray;
		}

		void positionSort(object sender, EventArgs e)
		{
			List<Position> newPosList = new List<Position>();
			foreach (var pos in bufferPositionsList)
			{
				if (pos.openDate >= dateTimePickerStart.Value && pos.openDate <= dateTimePickerEnd.Value)
				{
					newPosList.Add(pos);
				}
			}
			bufferPositionsList = newPosList;

			if (comboBox_GroupData.Text == comboBox_GroupData.Items[0].ToString())
			{

				//Console.WriteLine("Сортировка по дате создания");
				////Стандартная сортировка через интефейс IComparable
				//bufferPositionsList.Sort();
				//!!!!!!!!//https://ru.stackoverflow.com/questions/1249145/%D0%A1%D0%BE%D1%80%D1%82%D0%B8%D1%80%D0%BE%D0%B2%D0%BA%D0%B0-%D1%81%D0%BF%D0%B8%D1%81%D0%BA%D0%B0-list-%D1%81-%D0%BA%D0%BB%D0%B0%D1%81%D1%81%D0%B0%D0%BC%D0%B8-%D0%BF%D0%BE-%D0%B0%D0%BB%D1%84%D0%B0%D0%B2%D0%B8%D1%82%D1%83
				//Сортировка через Linq!!!!
				//List<Position> newPosList = new List<Position>();
				//foreach (var item in bufferPositionsList.OrderBy(w => w.closeDate))
				//{
				//	newPosList.Add(item);
				//}
				//bufferPositionsList = newPosList;

				//Сортировка через стандартную функцию Sort без е%ли с интерфейсами
				bufferPositionsList.Sort((l, r) => l.openDate.CompareTo(r.openDate));
				bindingPositionsBufferListWithDataGridView(sender, e);
				//bufferPositionsList.Reverse();
			}
			else if (comboBox_GroupData.Text == comboBox_GroupData.Items[1].ToString())
			{
				//Console.WriteLine("Сортировка по дате закрытия");
				bufferPositionsList.Sort((l, r) => l.closeDate.CompareTo(r.closeDate));
				bindingPositionsBufferListWithDataGridView(sender, e);
			}
			else if (comboBox_GroupData.Text == comboBox_GroupData.Items[2].ToString())
			{
				//Console.WriteLine("Сортировка по категория");
				bufferPositionsList.Sort((l, r) => l.category.CompareTo(r.category));
				bindingPositionsBufferListWithDataGridView(sender, e);
			}
			else if (comboBox_GroupData.Text == comboBox_GroupData.Items[3].ToString())
			{
				//Console.WriteLine("Сортировка по вид");
				bufferPositionsList.Sort((l, r) => l.kind.CompareTo(r.kind));
				bindingPositionsBufferListWithDataGridView(sender, e);
			}
			else if (comboBox_GroupData.Text == comboBox_GroupData.Items[4].ToString())
			{
				//Console.WriteLine("Сортировка по тег");
				bufferPositionsList.Sort((l, r) => l.tag.CompareTo(r.tag));
				bindingPositionsBufferListWithDataGridView(sender, e);
			}
			else if (comboBox_GroupData.Text == comboBox_GroupData.Items[5].ToString())
			{
				//Console.WriteLine("Сортировка по валюта");
				bufferPositionsList.Sort((l, r) => l.currCoin.CompareTo(r.currCoin));
				bindingPositionsBufferListWithDataGridView(sender, e);
			}
			else if (comboBox_GroupData.Text == comboBox_GroupData.Items[6].ToString())
			{
				//Console.WriteLine("Сортировка по статус");
				bufferPositionsList.Sort((l, r) => l.status.CompareTo(r.status));
				bindingPositionsBufferListWithDataGridView(sender, e);
			}
			else
			{
				//Console.WriteLine("Сортировка по ID");
				bufferPositionsList.Sort((l, r) => l.myKey.CompareTo(r.myKey));
				bindingPositionsBufferListWithDataGridView(sender, e);
			}
		}

		void currencyPairLoadForDefaultList()
		{
			toolStripComboBox_DefaultCoin.Items.Clear();
			foreach (var item in parrent.CurrencyPairs)
			{
				toolStripComboBox_DefaultCoin.Items.Add(item.shortPairName);
			}
			toolStripComboBox_DefaultCoin.Text = parrent.mainIni.defaultCoin;	
		}

		//place holders
		private void ExpenceIncomeForm_Load(object sender, EventArgs e)
		{
			comboBox_Category.Text = "Выберете категорию:";
			comboBox_Kind.Text = "Выберете вид:";
			comboBox_GroupData.Text = "Опорядочить по:";
			toolStripTextBox_search.Text = "Поиск";

			//comboBox_Category.ForeColor = Color.Gray;
			//comboBox_Kind.ForeColor = Color.Gray;
			comboBox_GroupData.ForeColor = Color.Gray;
			toolStripTextBox_search.ForeColor = Color.Gray;

			////Корректно не отработало
			getMonthIncomExpenseSaldoToolStripStatus(bufferPositionsList);
			currencyPairLoadForDefaultList();
		}


		void getMonthIncomExpenseSaldoToolStripStatus(List<Position> _posList)
		{

			toolStripStatusLabelMonthExpence.Text = "\t\t|   РАСХОД";
				//"\t\t|   РАСХОД ЗА " +
				//((DateTime.Now.Month == 1) ? "январь" :
				//(DateTime.Now.Month == 2) ? "февраль" :
				//(DateTime.Now.Month == 3) ? "март" :
				//(DateTime.Now.Month == 4) ? "апрель" :
				//(DateTime.Now.Month == 5) ? "май" :
				//(DateTime.Now.Month == 6) ? "июнь" :
				//(DateTime.Now.Month == 7) ? "июль" :
				//(DateTime.Now.Month == 8) ? "август" :
				//(DateTime.Now.Month == 9) ? "сентябрь" :
				//(DateTime.Now.Month == 10) ? "октябрь" :
				//(DateTime.Now.Month == 11) ? "ноябрь" :
				//"декабрь");
			toolStripStatusLabel_MonthIncome.Text = "\t\t|  ПРИХОД";
			//"\t\t|   ПРИХОД ЗА " +
			//	((DateTime.Now.Month == 1) ? "январь" :
			//	(DateTime.Now.Month == 2) ? "февраль" :
			//	(DateTime.Now.Month == 3) ? "март" :
			//	(DateTime.Now.Month == 4) ? "апрель" :
			//	(DateTime.Now.Month == 5) ? "май" :
			//	(DateTime.Now.Month == 6) ? "июнь" :
			//	(DateTime.Now.Month == 7) ? "июль" :
			//	(DateTime.Now.Month == 8) ? "август" :
			//	(DateTime.Now.Month == 9) ? "сентябрь" :
			//	(DateTime.Now.Month == 10) ? "октябрь" :
			//	(DateTime.Now.Month == 11) ? "ноябрь" :
			//	"декабрь");

			toolStripStatusLabelMonthExpence.Text += "   " + periodExpence(_posList) + "   " + comboBox_CoinPair.Text; ;
			toolStripStatusLabelMonthExpence.ForeColor = Color.Red;
			toolStripStatusLabel_MonthIncome.Text += "   " + periodIncome(_posList) + "   " + comboBox_CoinPair.Text; ;
			toolStripStatusLabel_MonthIncome.ForeColor = Color.Green;
			toolStripStatusLabel_MonthSaldo.Text = "\t\t|   САЛЬДО:   " + (periodIncome(_posList) - periodExpence(_posList)) + "   " + comboBox_CoinPair.Text;
			if ((periodIncome(_posList) - periodExpence(_posList)) > 0)
			{
				toolStripStatusLabel_MonthSaldo.ForeColor = Color.Green;
			}
			else if ((periodIncome(_posList) - periodExpence(_posList)) < 0)
			{
				toolStripStatusLabel_MonthSaldo.ForeColor = Color.Red;
			}
			else
			{
				toolStripStatusLabel_MonthSaldo.ForeColor = Color.Black;
			}
		}

		decimal periodIncome(List<Position> _posList)
		{
			decimal tempIncome = 0;
			foreach (var item in _posList)
			{
				if (item.currCoin == comboBox_CoinPair.Text)
					tempIncome += item.income;
			}
			return tempIncome;
		}
		decimal periodExpence(List<Position> _posList)
		{
			decimal tempExpence = 0;
			foreach (var item in _posList)
			{
				if (item.currCoin == comboBox_CoinPair.Text)
					tempExpence += item.expence;
			}
			return tempExpence;
		}

		private void toolStripTextBox_search_Enter(object sender, EventArgs e)
		{
			if (toolStripTextBox_search.Text == "Поиск")
			{
				toolStripTextBox_search.Text = "";
				toolStripTextBox_search.ForeColor = Color.Black;
			}
		}
		private void toolStripTextBox_search_Leave(object sender, EventArgs e)
		{
			if (toolStripTextBox_search.Text == "")
			{
				toolStripTextBox_search.Text = "Поиск";
				toolStripTextBox_search.ForeColor = Color.Gray;
			}
		}
		private void comboBox_GroupData_Enter(object sender, EventArgs e)
		{
			if (comboBox_GroupData.Text == "Опорядочить по:")
			{
				comboBox_GroupData.Text = "";
				comboBox_GroupData.ForeColor = Color.Black;
			}
		}
		private void comboBox_GroupData_Leave(object sender, EventArgs e)
		{
			if (comboBox_GroupData.Text == "")
			{
				comboBox_GroupData.Text = "Опорядочить по:";
				comboBox_GroupData.ForeColor = Color.Gray;
			}
		}

		//Биндинг Листа позиций с таблицей и обновлени таблицы
		void BindingList(List<Position> tempList)
		{
			foreach (var pos in tempList)
			{
				bindingSourcePosition.Add(pos);
			}
			//Запрещает автоматическую генерацию колонок
			dataGridView_positions.AutoGenerateColumns = false;
			//Передает данные в dataGridView
			dataGridView_positions.DataSource = bindingSourcePosition;
			//Назначает столбцам dataGridView значения из листа данных
			my_key.DataPropertyName = "myKey";
			openDate.DataPropertyName = "openDate";
			closeDate.DataPropertyName = "closeDate";
			category.DataPropertyName = "category";
			kind.DataPropertyName = "kind";
			tag.DataPropertyName = "tag";
			income.DataPropertyName = "income";
			expence.DataPropertyName = "expence";
			saldo.DataPropertyName = "saldo";
			lotCount.DataPropertyName = "lotCount";
			coin.DataPropertyName = "currCoin";
			status.DataPropertyName = "status";
			getMonthIncomExpenseSaldoToolStripStatus(tempList);
		}

		//Метод поиска
		void searchHendler(string inputStr)
		{
			if (toolStripComboBox_CategorySearch.Text == inputStr)
			{
				List<Position> tempList = new List<Position>();
				foreach (var item in bufferPositionsList)
				{
					if (inputStr == "Категория")
					{
						if (item.category.Contains(toolStripTextBox_search.Text))
						{
							tempList.Add(item);
						}
					}
					if (inputStr == "Вид")
					{
						if (item.kind.Contains(toolStripTextBox_search.Text))
						{
							tempList.Add(item);
						}
					}
					if (inputStr == "Тег")
					{
						if (item.tag.Contains(toolStripTextBox_search.Text))
						{
							tempList.Add(item);
						}
					}
					if (inputStr == "Валютная пара")
					{
						if (item.currCoin.Contains(toolStripTextBox_search.Text))
						{
							tempList.Add(item);
						}
					}
					if (inputStr == "Примечания")
					{
						if (item.notes.Contains(toolStripTextBox_search.Text))
						{
							tempList.Add(item);
						}
					}
					if (inputStr == "Статус позиции")
					{
						if (item.status.Contains(toolStripTextBox_search.Text))
						{
							tempList.Add(item);
						}
					}
					if (inputStr == "ID")
					{
						if ((item.myKey).ToString().Contains(toolStripTextBox_search.Text))
						{
							tempList.Add(item);
						}
					}
				}
				dataGridView_positions.Rows.Clear();
				BindingList(tempList);
				toolStripStatusLabel_numberPositions.Text = $"Прочитано данных: {tempList.Count}";
			}
		}

	}
}
