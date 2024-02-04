using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pomogator
{
	internal class DB_Provider
	{
		OleDbConnection DBConnection;

		//Подключение
		public bool openConnection(string pass = "", string path = "DataPomogator.mdb" )
		{
			try
			{
				if (pass == "")
				{
					string connectString = $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = {path};";
					DBConnection = new OleDbConnection(connectString);
					DBConnection.Open();
					return true;
				}
				else
				{
					string connectString = $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = {path}; Jet OLEDB:Database Password = {pass};";
					DBConnection = new OleDbConnection(connectString);
					DBConnection.Open();
					return true;
				}

			}
			catch (Exception)
			{
				return false;
			}
		}

		//Отключение
		public void closeConnection() { DBConnection.Close(); }


		//Получение листа данных приходов расходов
		public List<IncomeExpenceData> IEDataListRead()
		{
			List<IncomeExpenceData> tempIEData = new List<IncomeExpenceData>();
			//Формирование строки запроса к БД
			string query = "SELECT key, type, category, kind, defaultStatus, note FROM IncomeExpenceData";
			// создаем объект OleDbCommand для выполнения запроса к БД MS Access
			OleDbCommand command = new OleDbCommand(query, DBConnection);
			// получаем объект OleDbDataReader для чтения табличного результата запроса SELECT

			try
			{
				OleDbDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					IncomeExpenceData temp = new IncomeExpenceData(Convert.ToUInt32(reader[0]), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString());
					tempIEData.Add(temp);
				}
				return tempIEData;
			}
			catch (Exception)
			{
				MessageBox.Show("Ошибка чтения таблицы IncomeExpenceData");
				return null;
			}
		}

		//Получение одной позиции

		public Position GetPosition(uint _id)
		{
			Position temp = new Position();
			string query = $"SELECT key, myKey, openDate, closeDate, kind, category, income, expence, lotCount, currCoin, saldo, status, tag, notes FROM Positions WHERE myKey = {_id}";
			OleDbCommand command = new OleDbCommand(query, DBConnection);

			try
			{
				OleDbDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					temp = new Position(Convert.ToUInt32(reader[0]), Convert.ToUInt32(reader[1]),
						Convert.ToDateTime(reader[2]), Convert.ToDateTime(reader[3]),
						reader[4].ToString(), reader[5].ToString(), Convert.ToDecimal(reader[6]),
						Convert.ToDecimal(reader[7]), Convert.ToUInt32(reader[8]), reader[9].ToString(),
						Convert.ToDecimal(reader[10]), reader[11].ToString(), reader[12].ToString(), reader[13].ToString());
				}
				//Console.WriteLine("*************");
				return temp;
			}
			catch (Exception)
			{
				MessageBox.Show("Позиция не прочитана");
				return null;
			}
		}

		//Получение листа данных валют
		public List<Currency> CurrencyNameReader()
		{
			//ASC - сортировка от меньшего к большему
			List<Currency> tempCurrPair = new List<Currency>();
			string query = "SELECT key, addDate, currencyPairName, shortPairName FROM coins ORDER BY key ASC";
			OleDbCommand command = new OleDbCommand(query, DBConnection);

			try
			{
				OleDbDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					Currency temp = new Currency(Convert.ToUInt32(reader[0]), Convert.ToDateTime(reader[1]), reader[2].ToString(), reader[3].ToString());
					tempCurrPair.Add(temp);
				}
				return tempCurrPair;
			}
			catch (Exception)
			{
				MessageBox.Show("Ошибка чтения таблицы currencyPair");
				return null;
			}
		}

		//Запись валюты в БД
		public uint addCurrencyNameToDB(Currency currency)
		{
			string query = $"INSERT INTO coins (addDate, currencyPairName, shortPairName) VALUES ('{currency.date}', '{currency.currencyName}', '{currency.shortCurrencyName}')";
			OleDbCommand command = new OleDbCommand(query, DBConnection);
			try
			{
				command.ExecuteNonQuery();

				////string query2 = "SELECT MAX(key) FROM coins";
				string query2 = $"SELECT key FROM coins WHERE currencyPairName ='{currency.currencyName}'";
				OleDbCommand command2 = new OleDbCommand(query2, DBConnection);
				return Convert.ToUInt32(command2.ExecuteScalar().ToString());
			}
			catch (Exception)
			{
				return 0;
			}
		}

		//Обновление записи о валюте
		public uint updateCurrency(Currency curr)
		{
			string query = $"UPDATE coins SET addDate = '{curr.date}', currencyPairName ='{curr.currencyName}', shortPairName = '{curr.shortCurrencyName}' WHERE key = {curr.key}";
			OleDbCommand command = new OleDbCommand(query, DBConnection);
			try
			{
				command.ExecuteNonQuery();

				//string query2 = "SELECT MAX(key) FROM coins";
				//string query2 = $"SELECT key FROM coins WHERE currencyPairName ='{curr.currencyName}'";
				//OleDbCommand command2 = new OleDbCommand(query2, DBConnection);
				//return Convert.ToUInt32(command2.ExecuteScalar().ToString());
				return curr.key;

			}
			catch (Exception)
			{
				return 0;
			}
		}

		//Удаление записи о валюте
		public bool deleteCurrency(Currency curr)
		{
			string query = $"DELETE FROM coins WHERE key = {curr.key}";
			OleDbCommand command = new OleDbCommand(query, DBConnection);
			try
			{
				command.ExecuteNonQuery();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}



		//Запись позиции в БД.
		public bool addPositionToDB(Position inputPos)
		{
			//Неактуально, лечится в dotTocommaRepair()
			//string income = inputPos.income.ToString(), expence = inputPos.expence.ToString(), saldo = inputPos.saldo.ToString();
			//income =income.Replace(',', '.');
			//expence = expence.Replace(',', '.');
			//saldo = saldo.Replace(',', '.');

			// текст запроса
			string query = $"INSERT INTO Positions (myKey, openDate, closeDate, kind, category, income, expence, lotCount, currCoin, saldo, status, tag, notes)" +
			$" VALUES ({inputPos.myKey}, '{inputPos.openDate}', '{inputPos.closeDate}', '{inputPos.kind}', '{inputPos.category}', '{inputPos.income}', '{inputPos.expence}', " +
			$"{inputPos.lotCount}, '{inputPos.currCoin}', '{inputPos.saldo}', '{inputPos.status}', '{inputPos.tag}','{inputPos.notes}')";
			// создаем объект OleDbCommand для выполнения запроса к БД MS Access
			OleDbCommand command = new OleDbCommand(query, DBConnection);
			try
			{
				command.ExecuteNonQuery();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		//Получение максимального значения myKey
		public uint getMyKeyMax()
		{
			try
			{
				string query = "SELECT MAX(myKey) FROM Positions";
				OleDbCommand command = new OleDbCommand(query, DBConnection);
				return Convert.ToUInt32(command.ExecuteScalar().ToString());
			}
			catch (Exception)
			{
				//MessageBox.Show("Ошибка получения максимума или позиции отсутствуют");
				return 0;
			}
		}

		//Чтение позиций из БД
		public List<Position> readPositionsFromBD(DateTime _startDate = new DateTime(), DateTime _endDate = new DateTime())
		{
			List<Position> tempList = new List<Position>();
			string query = "SELECT key, myKey, openDate, closeDate, kind, category, income, expence, lotCount, currCoin, saldo, status, tag, notes FROM Positions ORDER BY openDate DESC";
			OleDbCommand command = new OleDbCommand(query, DBConnection);

			try
			{
				OleDbDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					var temp = new Position(Convert.ToUInt32(reader[0]), Convert.ToUInt32(reader[1]),
						Convert.ToDateTime(reader[2]), Convert.ToDateTime(reader[3]),
						reader[4].ToString(), reader[5].ToString(), Convert.ToDecimal(reader[6]),
						Convert.ToDecimal(reader[7]), Convert.ToUInt32(reader[8]), reader[9].ToString(),
						Convert.ToDecimal(reader[10]), reader[11].ToString(), reader[12].ToString(), reader[13].ToString());
					tempList.Add(temp);
					//Console.WriteLine(temp.openDate);
				}
                //Console.WriteLine("*************");
                return tempList;
			}
			catch (Exception)
			{
				MessageBox.Show("Данные не прочитаны");
				return null;
			}
		}

		//Обновление позиции в БД
		public bool updatePosition(Position pos)
		{


			string income = pos.income.ToString(), expence = pos.expence.ToString(), saldo = pos.saldo.ToString();
			income = income.Replace(',', '.');
			expence = expence.Replace(',', '.');
			saldo = saldo.Replace(',', '.');

			string query = $"UPDATE Positions SET myKey = {pos.myKey}, openDate = '{pos.openDate}', closeDate ='{pos.closeDate}', kind = '{pos.kind}'," +
				$" category = '{pos.category}', income = {income}, expence = {expence}, lotCount = {pos.lotCount}, currCoin = '{pos.currCoin}', saldo = {saldo}," +
				$" status = '{pos.status}', tag = '{pos.tag}', notes = '{pos.notes}' WHERE key = {pos.key}";
			OleDbCommand command = new OleDbCommand(query, DBConnection);
			try
			{
				command.ExecuteNonQuery();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		//Удаление позиции в БД
		public bool deletePosition(Position pos)
		{

			//string query = $"DELETE FROM Positions key = {pos.key}, myKey = {pos.myKey}, openDate = '{pos.openDate}', closeDate ='{pos.closeDate}', kind = '{pos.kind}'," +
			//	$" category = '{pos.category}', income = {pos.income}, expence = {pos.expence}, lotCount = {pos.lotCount}, currCoin = '{pos.currCoin}', saldo = {pos.saldo}," +
			//	$" status = '{pos.status}', tag = '{pos.tag}', notes = '{pos.notes}' WHERE key = {pos.key}";
			string query = $"DELETE FROM Positions WHERE key = {pos.key}";
			OleDbCommand command = new OleDbCommand(query, DBConnection);
			try
			{
				command.ExecuteNonQuery();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}


		//Чтение позиций из старой БД 1_07
		public List<OldDBData_1_07> readPositionsFromOldBD_1_07(DateTime _startDate = new DateTime(), DateTime _endDate = new DateTime())
		{
			List<OldDBData_1_07> tempList = new List<OldDBData_1_07>();

			string queryIncome = $"SELECT Код, Дата, Тип_дохода, Доход, Примечание FROM Tb_доходы";
			string queryExpence = $"SELECT Код, Дата, Тип_расходов, Расходы, Примечание FROM Tb_расходы";

			try
			{
				OleDbCommand commandIncome = new OleDbCommand(queryIncome, DBConnection);
				OleDbDataReader reader = commandIncome.ExecuteReader();
				while (reader.Read())
				{
					var temp = new OldDBData_1_07(Convert.ToUInt32(reader[0]), Convert.ToDateTime(reader[1]), reader[2].ToString(), "null" , Convert.ToDecimal(reader[3]), reader[4].ToString());
					tempList.Add(temp);
					//Console.WriteLine(temp.openDate);
				}
				OleDbCommand commandExpence = new OleDbCommand(queryExpence, DBConnection);
				OleDbDataReader readerExpence = commandExpence.ExecuteReader();
				while (readerExpence.Read())
				{
					var temp = new OldDBData_1_07(Convert.ToUInt32(readerExpence[0]), Convert.ToDateTime(readerExpence[1]), "null", readerExpence[2].ToString(), Convert.ToDecimal(readerExpence[3]), readerExpence[4].ToString());
					tempList.Add(temp);
				}
				//Console.WriteLine("*************");
				return tempList;
			}
			catch (Exception)
			{
				MessageBox.Show("Данные не прочитаны");
				return null;
			}
		}

	}
}
