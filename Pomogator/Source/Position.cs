using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Collections;

namespace Pomogator
{
	public class Position: ICloneable, IComparable /*: INotifyPropertyChanged*/
	{
		//0 Ключ БД
		public uint key { get; set; }

		//1 Ключ приложения - идентифицирует позицию для программы
		public uint myKey { get; set; }

		//2 Дата открытия
		public DateTime openDate { get; set; }

		//лишнее
		//////3 Дата изменения позиции (редактирует всле записи с полем myKey)
		////public DateTime editDate { get; set; }

		//2 Дата закрытия позиции (редактирует всле записи с полем myKey)
		public DateTime closeDate { get; set; }

		//3 Название позиции (вводит пользователь)
		public string kind { get; set; }

		//4 Категория  - должна устанавливаться автоматически, либо вручную
		public string category { get; set; }

		//5 Приход (вводит пользователь если поле активно, по умолчанию 0)
		public decimal income { get; set; }

		public decimal getIncome()
		{
			return income;
		}

		//6 Расход (вводит пользователь если поле активно, по умолчанию 0)
		public decimal expence { get; set; }
		public decimal getExpence()
		{
			return income;
		}

		//7 Количество лотов (по умолчанию при открытой позиции 1, при закрытой 0
		public uint lotCount { get; set; }

		//По задумке должна автоматически пересчитываться на курс текущих валют
		//8 Валюта или валютная пара позиции
		public string currCoin { get; set; }

		//9 Разность прихода и расхода
		public decimal saldo { get; set; }

		//10 Статус позиции(открыта true/закрыта false)
		public string status { get; set; }

		//11 Вид(Тэг) позиции - используется для индивидуальной подписи позиции для группировки
		public string tag { get; set; }

		//лишнее
		//////8 Тип позиции (разовый - по умолчанию 'single'/периодический 'period'/ непредвиденный 'unexcepted')
		////public string positionType { get; set; }

		//12 Заметки/примечания (вводит пользователь при необходимости)
		public string notes { get; set; }

		//// ОТКАЗАЛСЯ ОТ ДАННОЙ КОНЦЕПЦИИ 25.01.24
		////По задумке при запуске приложения курсы должны парситься в excel таблицу дата/торговая пара/ курс
		////13 Курсы (набор курсов - хранятся отдельно представляют структуру значение 1, значение 2, отношение )
		//public List<ratesData> Rates { get; set; }
		//public struct ratesData
		//{
		//	public string coinPair { get; set; }
		//	public double Ratio { get; set; }
  //          public ratesData(string _coinPair, double _ratio)
  //          {
		//		coinPair = _coinPair;
		//		Ratio = _ratio;
  //          }
  //      }



		public Position()
		{
			lotCount = 1;
		}

		public Position(uint _key, uint _myKey, DateTime _openDate, DateTime _closeDate, string _posKind, string _category, decimal _income, decimal _expence, uint _lotCount, string _currCoin, decimal _saldo, string _status, string _tag, string _note)
		{
			key = _key;
			myKey = _myKey;
			openDate = _openDate;
			closeDate = _closeDate;
			kind = _posKind;
			category = _category;
			income = _income;
			expence = _expence;
			lotCount = _lotCount;
			currCoin = _currCoin;
			saldo = _saldo;
			status = _status;
			tag = _tag;
			notes = _note;
		}


		public override string ToString()
		{
			if (closeDate.Year == 9999 || (status == "открыто" || status == "open"))
			{
				return $"ID: {key}\t Дата открытия: {openDate.ToShortDateString()}\t Дата закрытия: ---\t Вид: {kind}\t Тег: {tag}\t Категория: {category}\t" +
					$" Приход: {income}\t Расход: {expence}\t Сальдо: {saldo} {currCoin} \t" +
					$" Количество лотов: {lotCount}\t Состояние: {status}";
			}
			else
				return $"ID: {key}\t Дата открытия: {openDate.ToShortDateString()}\t Дата закрытия: {closeDate.ToShortDateString()}\t Вид: {kind}\t Тег: {tag}\t Категория: {category}\t" +
		$" Приход: {income}\t Расход: {expence}\t Сальдо: {saldo} {currCoin} \t" +
		$" Количество лотов: {lotCount}\t Состояние: {status} примечания {notes}";
		}

		//Копирование для безссылочных типов
		public object Clone() => MemberwiseClone();

		////Глубокое копирование
		//public object Clone()
		//{
		//	Position clone = (Position)this.MemberwiseClone();
		//	clone.Rates = new List<ratesData>();
		//	foreach (var item in Rates)
		//	{
		//		clone.Rates.Add(item);
		//	}
		//	return clone;
		//}

		public int CompareTo(object obj)
		{
			Position x = obj as Position;
			return string.Compare(this.kind, x.kind);

			throw new NotImplementedException();
		}
	}
}





/// <summary>
/// Реализация через связку
/// </summary>
////0 Ключ БД
//uint _key;
//public uint key
//{
//	get => _key; set { _key = value; OnPropertyChanged(); }
//}
////1 Ключ приложения - идентифицирует позицию для программы
//uint _myKey;
//[DisplayName("ID")]
//public uint myKey
//{
//	get => _myKey;
//	set
//	{
//		_myKey = value;
//		//Уведомляет клиента об изменении свойства через событие PropertyChanged
//		OnPropertyChanged();
//	}
//}

////2 Дата открытия
//DateTime _openDate;
//[DisplayName("Дата созд.")]
//public DateTime openDate { get => _openDate; set { _openDate = value; OnPropertyChanged(); } }

////лишнее
////////3 Дата изменения позиции (редактирует всле записи с полем myKey)
//////public DateTime editDate { get; set; }

////2 Дата закрытия позиции (редактирует всле записи с полем myKey)
//DateTime _closeDate;
//[DisplayName("Дата закр.")]
//public DateTime closeDate { get => _closeDate; set { _closeDate = value; OnPropertyChanged(); } }

////3 Название позиции (вводит пользователь)
//string _kind;
//[DisplayName("Наименование")]
//public string kind { get => _kind; set { _kind = value; OnPropertyChanged(); } }

////4 Категория - должна устанавливаться автоматически, либо вручную
//string _category;
//public string category { get => _category; set { _category = value; OnPropertyChanged(); } }

////5 Приход (вводит пользователь если поле активно, по умолчанию 0)
//public decimal income { get; set; }

////6 Расход (вводит пользователь если поле активно, по умолчанию 0)
//public decimal expence { get; set; }

////7 Количество лотов (по умолчанию при открытой позиции 1, при закрытой 0
//public uint lotCount { get; set; }

////По задумке должна автоматически пересчитываться на курс текущих валют
////8 Валюта или валютная пара позиции
//public string currCoin { get; set; }

////9 Разность прихода и расхода
//public decimal saldo { get; set; }

////10 Статус позиции(открыта true/закрыта false)
//public string status { get; set; }

////11 Вид(Тэг) позиции - используется для индивидуальной подписи позиции для группировки
//public string tag { get; set; }

////лишнее
////////8 Тип позиции (разовый - по умолчанию 'single'/периодический 'period'/ непредвиденный 'unexcepted')
//////public string positionType { get; set; }

////12 Заметки/примечания (вводит пользователь при необходимости)
//public string notes { get; set; }

////По задумке при запуске приложения курсы должны парситься в excel таблицу дата/торговая пара/ курс
////13 Курсы (набор курсов - хранятся отдельно представляют структуру значение 1, значение 2, отношение )
//public List<decimal> Rates { get; set; }



////Обработка изменений - сообщает клиента об изменении в значения в поле
//public event PropertyChangedEventHandler PropertyChanged;
//protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
//	=> PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));