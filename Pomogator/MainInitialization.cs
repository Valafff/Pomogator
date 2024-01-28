using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;
using System.Security.Cryptography;

namespace Pomogator
{

	partial class Pomogator_MainForm : Form
	{

		public Ini mainIni = new Ini();
		Ini defaultIni = new Ini("DataPomogator.mdb", "no", "RUB");
		void serialization()
		{
			
			string[] files = Directory.GetFiles(Directory.GetCurrentDirectory());
			foreach (var item in files)
			{
				if (item.Contains("inidata.json"))
				{
					try
					{
						using (FileStream fs = new FileStream("inidata.json", FileMode.Open))
						{
							mainIni = JsonSerializer.Deserialize<Ini>(fs);
						}
						return;
					}
					catch (Exception)	{ Console.WriteLine("ошибка десериализации"); }
				}
			}
			using (FileStream fs = new FileStream("inidata.json", FileMode.Create))
			{
				JsonSerializer.Serialize(fs, defaultIni);
			}
			mainIni = defaultIni;
		}

		void reWritePathDB(string _path)
		{
			Ini newIni = (Ini)mainIni.Clone();
			newIni.pathDB = _path;
			using (FileStream fs = new FileStream("inidata.json", FileMode.Create))
			{
				JsonSerializer.Serialize(fs, newIni);
			}
		}
		void reWritePinCode(string _pin)
		{
			Ini newIni = (Ini)mainIni.Clone();
			newIni.pinCode = _pin;
			using (FileStream fs = new FileStream("inidata.json", FileMode.Create))
			{
				JsonSerializer.Serialize(fs, newIni);
			}
		}
		public void reWriteDefaultCoin(string _coin)
		{
			Ini newIni = (Ini)mainIni.Clone();
			newIni.defaultCoin = _coin;
			using (FileStream fs = new FileStream("inidata.json", FileMode.Create))
			{
				JsonSerializer.Serialize(fs, newIni);
			}
		}

	}

	public class Ini: ICloneable
	{
		public string pathDB { get; set; }
		public string pinCode { get; set; }
		public string defaultCoin { get; set; }
		public Ini() { }
		public Ini(string _pathDB, string _pinCode, string _defCoin)
		{
			pathDB = _pathDB;
			pinCode = _pinCode;
			defaultCoin = _defCoin;
		}

		public object Clone()
		{
			return MemberwiseClone();
		}
	}
}
