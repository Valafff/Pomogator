using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pomogator
{
	//Вспомогательные методы
	internal class SourceCode
	{

		ExpenceIncomeForm pEIForm;
		public SourceCode(ExpenceIncomeForm _parrentExpenceIncomeForm)
		{
			pEIForm = _parrentExpenceIncomeForm;
		}

		////Вспомогательная функция для автоподстановки TextBox
		//public string[] getStringArrayFromComboBox(ComboBox _combo)
		//{
		//	string[] temp = new string[_combo.Items.Count];
		//	for (int i = 0; i < _combo.Items.Count; i++)
		//	{
		//		temp[i] = _combo.Items[i].ToString();
		//	}

		//	return temp;
		//}


		////Полная функция для автоподстановки TextBox
		//public void AutoCompleteTextInComboBox(ComboBox _combo)
		//{
		//	string[] temp = new string[_combo.Items.Count];
		//	for (int i = 0; i < _combo.Items.Count; i++)
		//	{
		//		temp[i] = _combo.Items[i].ToString();
		//	}
		//	_combo.AutoCompleteCustomSource.AddRange(getStringArrayFromComboBox(_combo));
		//	_combo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		//	_combo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
		//}

		////Запись данных IncomExpence из List в элементы формы
		//public void write_Category_fromIEListToComboBox(ComboBox _combo, List<IncomeExpenceData> _data)
		//{
		//	_combo.Items.Clear();
		//	_combo.Text = "";
		//	foreach (var item in _data)
		//	{
		//		if (!_combo.Items.Contains(item.category))
		//		{
		//			_combo.Items.Add(item.category);
		//		}
		//	}
		//}

		//Подготовка данных перед записью позиции в БД
		public decimal getSaldoFromForm(decimal income, decimal expence)
		{
			return income - expence;
		}
		public DateTime getCloseDateFromForm(ComboBox _combo)
		{
			if (_combo.Text == "закрыта" || _combo.Text == "closed")
			{
				return DateTime.Now;
			}
			else
			{
				//было
				//return new DateTime(9999, 12, 31);
				//Console.WriteLine(DateTime.MaxValue);
				return DateTime.MaxValue;

			}
		}

		//Запись в информационный блок
		public void setPositionToInfoTable()
		{
			try
			{

				if (pEIForm.bufferPosition != null)
				{
					//ID
					pEIForm.lb_IDInfo.Text = pEIForm.bufferPosition.myKey.ToString();
					// openDate
					pEIForm.lb_dateOpenInfo.Text = pEIForm.bufferPosition.openDate.ToString();
					//CloseDate
					//было
					//if (pEIForm.bufferPosition.closeDate.ToString() != "01.01.0001 0:00:00")
					if (pEIForm.bufferPosition.closeDate != DateTime.MinValue)
					{
						pEIForm.lb_closeDateInfo.Text = pEIForm.bufferPosition.closeDate.ToString();
					}
					else
					{
						pEIForm.lb_closeDateInfo.Text = "Позиция открыта";
					}
					//Kind
					pEIForm.lb_kindInfo.Text = pEIForm.bufferPosition.kind.ToString();
					//category
					pEIForm.lb_categoryInfo.Text = pEIForm.bufferPosition.category.ToString();
					//status
					pEIForm.lb_statusInfo.Text = pEIForm.bufferPosition.status.ToString();
					//Income
					pEIForm.lb_totalIncomInfo.Text = pEIForm.bufferPosition.income.ToString();
					//Expence
					pEIForm.lb_totalExpenceInfo.Text = pEIForm.bufferPosition.expence.ToString();
					//saldo
					pEIForm.lb_saldoInfo.Text = pEIForm.bufferPosition.saldo.ToString();
					//tag
					pEIForm.lb_tagInfo.Text = pEIForm.bufferPosition.tag.ToString();
					//number lots
					pEIForm.lb_lotcountInfo.Text = pEIForm.bufferPosition.lotCount.ToString();
					//coin
					pEIForm.lb_currCoinInfo.Text = pEIForm.bufferPosition.currCoin.ToString();
					//notes
					pEIForm.textBox_notes.Text = pEIForm.bufferPosition.notes.ToString();

				}
				else
				{
					//ID
					pEIForm.lb_IDInfo.Text = "";
					// openDate
					pEIForm.lb_dateOpenInfo.Text = "";
					//CloseDate
					pEIForm.lb_closeDateInfo.Text = "";
					//Kind
					pEIForm.lb_kindInfo.Text = "";
					//category
					pEIForm.lb_categoryInfo.Text = "";
					//status
					pEIForm.lb_statusInfo.Text = "";
					//Income
					pEIForm.lb_totalIncomInfo.Text = "";
					//Expence
					pEIForm.lb_totalExpenceInfo.Text = "";
					//saldo
					pEIForm.lb_saldoInfo.Text = "";
					//tag
					pEIForm.lb_tagInfo.Text = "";
					//number lots
					pEIForm.lb_lotcountInfo.Text = "";
					//coin
					pEIForm.lb_currCoinInfo.Text = "";
				}
			}
			catch (Exception)
			{

				Console.WriteLine("Error read from buffer position");
			}
		}
		//Обнуляет буффер позиции
		public void delBufferPosition()
		{
			pEIForm.bufferPosition = null;
			setPositionToInfoTable();
		}
		//Форматирование строки под число
		public string dotTocommaRepair(string tempStr)
		{
			if (tempStr.Contains('.') && tempStr.Contains(','))
			{
				tempStr = valueStringToDoubleFormating(tempStr);
			}
			double result = 0;
			tempStr = tempStr.Replace('.', ',');
			if (!tempStr.Contains(','))
			{
				if (double.TryParse(tempStr, out result))
				{
					return result.ToString();
				}
			}
			else if (double.TryParse(tempStr, out result))
			{
				//Любая десятичная дробь больше нуля и больше 1го
				if (result != 0 && tempStr[0] != '0')
				{
					return tempStr;
				}
				// Любая десятичная дробь равная или больше 0, но меньще 1
				else if (result >= 0 && tempStr[0] == '0' && tempStr[1] == ',')
				{
					return tempStr;
				}
				else
				{
					return tempStr.Remove(0, 1);
				}
			}
			return "0";
		}

		//Форматирование числа вида 3,569,636.62 в 3569636,62
		public string valueStringToDoubleFormating(string commaAndDotFormatingStr)
		{
			string[] temparr = commaAndDotFormatingStr.Split(new char[] { ',' });
			string result = "";
			foreach (var item in temparr)
			{
				result += item;
			}
			return result;
		}

		//Проверка на наличие закрытых позиций в комплексной позиции
		public bool isClosedPosition(List<Position> _pos)
		{
			foreach (var item in _pos)
			{
				if (item.status == "закрыта")
				{
					return true;
				}
			}
			return false;
		}

	}


	//Хранение данных из БД расходы/приходы
	public class IncomeExpenceData : ICloneable
	{
		public uint key { get; set; }
		public string type { get; set; }
		public string category { get; set; }
		public string kind { get; set; }
		public string defaultStatus { get; set; }
		public string note { get; set; }

		public IncomeExpenceData() { }

		public IncomeExpenceData(uint _key, string _type, string _category, string _kind, string _defaultStatus, string _note)
		{
			key = _key;
			type = _type;
			category = _category;
			kind = _kind;
			defaultStatus = _defaultStatus;
			note = _note;
		}
		public object Clone() => MemberwiseClone();
	}
	//Хранение пар валют из БД расходы/приходы
	public class Currency : INotifyPropertyChanged
	{
		uint KEY;
		public uint key
		{
			get => KEY;
			set
			{
				KEY = value;
				ChangeProperty("KEY");
			}
		}
		DateTime DATE;
		public DateTime date
		{
			get => DATE;
			set
			{
				DATE = value;
				ChangeProperty("DATE");
			}
		}

		string NAME;
		public string currencyName
		{
			get => NAME;
			set
			{
				NAME = value;
				ChangeProperty("NAME");
			}
		}
		string SHNAME;
		public string shortCurrencyName
		{
			get => SHNAME;
			set
			{
				SHNAME = value;
				ChangeProperty("SHNAME");
			}
		}





		public Currency() { }

		public Currency(uint _key, DateTime _addDate, string _currencyName, string _shortCurrencyName)
		{
			key = _key;
			date = _addDate;
			currencyName = _currencyName;
			shortCurrencyName = _shortCurrencyName;
		}

		public event PropertyChangedEventHandler PropertyChanged;
		void ChangeProperty(string property)
		{
			if (PropertyChanged != null)
				PropertyChanged(this, new PropertyChangedEventArgs(property));
		}


		public override string ToString()
		{
			return $"Дата доб/обнов: {date.ToShortDateString()}\t  |  Название валюты: {currencyName}  |  Короткое название: {shortCurrencyName}";
		}
	}
}
