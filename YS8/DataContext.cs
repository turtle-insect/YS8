using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace YS8
{
	class DataContext
	{
		public Info Info { get; set; } = Info.Instance();
		public ObservableCollection<Item> Items { get; set; } = new ObservableCollection<Item>();
		public ObservableCollection<Charactor> Charactors { get; set; } = new ObservableCollection<Charactor>();

		public DataContext()
		{
			foreach (var item in Info.Instance().Items)
			{
				Items.Add(new Item(item));
			}

			String[] Names = { "Adol", "Laxia" };
			for(uint i = 0; i < Names.Length; i++)
			{
				Charactors.Add(new Charactor(0x7D0 + i * 412, Names[i]));
			}
		}

		public uint PlayTimeHour
		{
			get { return SaveData.Instance().ReadNumber(0x2844, 4) / 108000; }
			set
			{
				uint num = SaveData.Instance().ReadNumber(0x2844, 4);
				num = value * 108000 + (num % 108000);
				SaveData.Instance().WriteNumber(0x2844, 4, num);
			}
		}

		public uint PlayTimeMinute
		{
			get { return SaveData.Instance().ReadNumber(0x2844, 4) / 1800 % 60; }
			set
			{
				if (value > 59) value = 59;
				uint num = SaveData.Instance().ReadNumber(0x2844, 4);
				num = num / 108000 + value * 1800 + (num / 30 % 60) * 30;
				SaveData.Instance().WriteNumber(0x2844, 4, num);
			}
		}

		public uint PlayTimeSecond
		{
			get { return SaveData.Instance().ReadNumber(0x2844, 4) / 30 % 60; }
			set
			{
				if (value > 59) value = 59;
				uint num = SaveData.Instance().ReadNumber(0x2844, 4);
				num = num / 1800 * 1800 + value * 30;
				SaveData.Instance().WriteNumber(0x2844, 4, num);
			}
		}
	}
}
