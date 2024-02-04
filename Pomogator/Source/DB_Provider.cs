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

		//Получение листа данных валютных пар
		public List<CurrencyPair> CurrencyPairReader()
		{
			List<CurrencyPair> tempCurrPair = new List<CurrencyPair>();
			string query = "SELECT key, addDate, currencyPairName, shortPairName, currency_1, currency_2, ratio FROM currencyPair";
			OleDbCommand command = new OleDbCommand(query, DBConnection);

			try
			{
				OleDbDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					CurrencyPair temp = new CurrencyPair(Convert.ToUInt32(reader[0]), Convert.ToDateTime(reader[1]), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), Convert.ToDecimal(reader[6]));
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
