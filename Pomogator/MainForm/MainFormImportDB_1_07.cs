using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pomogator
{
	public partial class Pomogator_MainForm : Form
	{
		List<OldDBData_1_07> tempDBdata_1_07 = new List<OldDBData_1_07>();
		List<Position> adaptedTempList = new List<Position>();
		void importDB_1_07(string _sourcePath = "outputDB.mdb")
		{
			if (provider.openConnection("",_sourcePath))
			{
				tempDBdata_1_07 = provider.readPositionsFromOldBD_1_07();
			}
			else
			{
                //Console.WriteLine("fail");
            }
			provider.closeConnection();
		}


		void trancelate()
		{
			//Income
			string[] debts = new string[] {  };
			string[] salary = new string[] { "Зарплата: Аванс", "Зарплата: Зарплата", "Зарплата: Отпускные", };
			string[] crypto = new string[] { "Крипто: Майнинг", "Крипто: Трейдинг", "Крипто: Биткоин" };
			string[] passiveIncome = new string[] { "Пассивный доход: Проценты с Н.З.", "Пассивный доход: Прочие доходы с депозитов", "Пассивный доход: Дивиденды" };
			string[] otherincome = new string[] { "Прочие доходы: Прочее" };
			string[] myselfJob = new string[] { "Работа на себя: Продажа металлических изделий", "Работа на себя: Разработка документации", "Работа на себя: Съемка с квадрокоптера", "Работа на себя: Торговые площадки", "Работа на себя: Прочее", "Шабашки" };
			string[] subsubsidy = new string[] { "Трейдинг", "Субсидии: Друзья", "Субсидии: Коллеги", "Субсидии: Мама", "Субсидии: Маша", "Субсидии: Отец", "Субсидии: Прочие субсидии", "Субсидии: Родственники" };
			//Expence
			string[] car = new string[] { "Автомобильные штрафы", "Автостраховка", "Бензин", "Мойка автомобиля", "Омывайка",
				"Прочие расходы на автомобиль",
				"Ремонт автомобиля"};
			string[] myselfExpence = new[] { "Гигиена(стрижка и прочее)", "Дал в долг", "Деньги на Д.Р. и прочее коллег",
				"Занятие спортом",
				"Личные вещи",
				"Мобильный телефон",
				"Обеды",
				"Обучение",
				"Общественный транспорт",
				"Одежда",
				"Подарки",
				"Прочие личные расходы",
				"Прочие личные расходы за месяц",
				"Развлечения",
				"Хобби"};
			string[] collection = new[] { "Работа на себя: Коллекционирование" };
			string[] debt = new[] { "Дал в долг", "Кредиты", "Мои долги", "Прочие мои долги", "Возвращение долгов" };
			string[] family = new string[] { "Детский сад", "Питание, здоровье, хозбыт" };
			string[] home = new string[] { "Домашний интернет", "Домашний телефон",
				"Виды расходов",
				"Квитанция 1 - Жилищно-коммунальные услуги",
				"Квитанция 10-Отопление и горячее водоснабжение",
				"Квитанция 20-Жилищно-коммунальные услуги",
				"Квитанция 29-Коммунальные услуги-вывоз мусора",
				"Квитанция 3-Содержание и ремонт лифта",
				"Квитанция 50-Фонд капитального ремонта",
				"Квитанция 5-Коммунальные услуги-водоснабжение",
				"Квитанция 67-Электроэнергия",
				"Квитанция 7- Линия ТВ",
				"Квитанция за газ",
				"Мебель и бытовая техника",
				"Прочие расходы по дому",
				"Ремонт квартиры"};
			string[] investitions = new string[] { "Инвестиции в фондовый рынок", "Отчисление в Н.З." };
			string[] taxes = new string[] { "Налог на автомобиль KIA RIO 2014 г.в.", "Налог на гараж",
				"Налог на доход", "Налог на землю где стоит гараж",
				"Налог на квартиру Урицкого 67", "Налог самозанятого"};
			string[] UnexpectedExpenses = new string[] { "Непредвиденные расходы" };
			string[] other = new string[] { "Прочие траты" };
			string[] garage = new string[] { "Ремонт гаража" };


			foreach (var item in tempDBdata_1_07)
			{
				Position temPos = new Position();
				temPos.openDate = item.openDate;
				temPos.closeDate = item.openDate;
				temPos.status = "закрыта";
				temPos.currCoin = "RUB";
				temPos.tag = $"Импорт БД от {DateTime.Now.ToShortDateString()}";
				//Поступления
				if (item.kindIncome != "null") 
				{
					temPos.notes = item.note + $"***imported*** {item.kindIncome} ***imported***";
					if (debts.Contains(item.kindIncome))
					{
						temPos.category = "Долги";
						temPos.kind = item.kindIncome;
						temPos.income = item.value;
						temPos.saldo = item.value;
					}
					else if (salary.Contains(item.kindIncome))
					{
						temPos.category = "Зарплата";
						temPos.kind = item.kindIncome;
						temPos.income = item.value;
						temPos.saldo = item.value;
					}
					else if (crypto.Contains(item.kindIncome))
					{
						temPos.category = "Крипта";
						temPos.kind = item.kindIncome;
						temPos.income = item.value;
						temPos.saldo = item.value;
					}
					else if (passiveIncome.Contains(item.kindIncome))
					{
						temPos.category = "Пассивный доход";
						temPos.kind = item.kindIncome;
						temPos.income = item.value;
						temPos.saldo = item.value;
					}
					else if (otherincome.Contains(item.kindIncome))
					{
						temPos.category = "Прочее income";
						temPos.kind = item.kindIncome;
						temPos.income = item.value;
						temPos.saldo = item.value;
					}
					else if (myselfJob.Contains(item.kindIncome))
					{
						temPos.category = "Самозанятость";
						temPos.kind = item.kindIncome;
						temPos.income = item.value;
						temPos.saldo = item.value;
					}
					else if (subsubsidy.Contains(item.kindIncome))
					{
						temPos.category = "Субсидии";
						temPos.kind = item.kindIncome;
						temPos.income = item.value;
						temPos.saldo = item.value;
					}
					else
					{
						temPos.category = "Прочее income";
						temPos.kind = item.kindIncome;
						temPos.income = item.value;
						temPos.saldo = item.value;
					}
				}
				//Траты
				else
				{
					temPos.notes = item.note + $"***imported*** {item.kindExpence} ***imported***";
					if (car.Contains(item.kindExpence))
					{
						temPos.category = "Автомобиль";
						temPos.kind = item.kindExpence;
						temPos.expence = item.value;
						temPos.saldo = -1*item.value;
					}
					else if (myselfExpence.Contains(item.kindExpence))
					{
						temPos.category = "Личные траты";
						temPos.kind = item.kindExpence;
						temPos.expence = item.value;
						temPos.saldo = -1*item.value;
					}
					else if (collection.Contains(item.kindExpence))
					{
						temPos.category = "Коллекционирование";
						temPos.kind = item.kindExpence;
						temPos.expence = item.value;
						temPos.saldo = -1 * item.value;
					}
					else if (debt.Contains(item.kindExpence))
					{
						temPos.category = "Долги";
						temPos.kind = item.kindExpence;
						temPos.expence = item.value;
						temPos.saldo = -1 * item.value;
					}
					else if (family.Contains(item.kindExpence))
					{
						temPos.category = "Семья";
						temPos.kind = item.kindExpence;
						temPos.expence = item.value;
						temPos.saldo = -1 * item.value;
					}
					else if (home.Contains(item.kindExpence))
					{
						temPos.category = "Жилище";
						temPos.kind = item.kindExpence;
						temPos.expence = item.value;
						temPos.saldo = -1 * item.value;
					}
					else if (investitions.Contains(item.kindExpence))
					{
						temPos.category = "Инвестиции и пенсионный фонд";
						temPos.kind = item.kindExpence;
						temPos.expence = item.value;
						temPos.saldo = -1 * item.value;
					}
					else if (taxes.Contains(item.kindExpence))
					{
						temPos.category = "Налоги";
						temPos.kind = item.kindExpence;
						temPos.expence = item.value;
						temPos.saldo = -1 * item.value;
					}
					else if (UnexpectedExpenses.Contains(item.kindExpence))
					{
						temPos.category = "Непредвиденные расходы";
						temPos.kind = item.kindExpence;
						temPos.expence = item.value;
						temPos.saldo = -1 * item.value;
					}
					else if (other.Contains(item.kindExpence))
					{
						temPos.category = "Прочее expence";
						temPos.kind = item.kindExpence;
						temPos.expence = item.value;
						temPos.saldo = -1 * item.value;
					}
					else if (garage.Contains(item.kindExpence))
					{
						temPos.category = "Гараж";
						temPos.kind = item.kindExpence;
						temPos.expence = item.value;
						temPos.saldo = -1 * item.value;
					}
					else
					{
						temPos.category = "Прочее expence";
						temPos.kind = item.kindExpence;
						temPos.expence = item.value;
						temPos.saldo = -1 * item.value;
					}

				}
				adaptedTempList.Add(temPos);
			}
			//return adaptedTempList;
		}













	}






	class OldDBData_1_07 : ICloneable
	{
		//Table Код
		public uint key { get; set; }
		// Дата
		public DateTime openDate { get; set; }
		//Тип_дохода
		public string kindIncome { get; set; }
		//Тип_расходов
		public string kindExpence { get; set; }
		//Доход / Расходы
		public decimal value { get; set; }
		//Примечание
		public string note { get; set; }

        public OldDBData_1_07()   { }

        public OldDBData_1_07(uint _key, DateTime _openDate, string _kindIncome, string _kindExpence, decimal _value, string _note)
        {
			key = _key;
			openDate = _openDate;
			kindIncome = _kindIncome;
			kindExpence = _kindExpence;
			value = _value;
			note = _note;
        }
        public object Clone()
		{
			return MemberwiseClone();
		}
		public override string ToString()
		{
			return $"ключ: {key}, дата открытия {openDate}, приход {kindIncome}, расход {kindExpence}, значение {value}, примечания {note}";
		}
	}

}
