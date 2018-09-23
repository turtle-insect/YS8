using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YS8
{
	class Item : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		public ItemValueInfo Info { get; private set; }
		public Item(ItemValueInfo info)
		{
			Info = info;
		}

		public uint Count
		{
			get { return SaveData.Instance().ReadNumber(0xB4EC + Info.Value * 2, 2); }
			set
			{
				if (!Info.isCount) return;
				if (value > 999) value = 999;
				SaveData.Instance().WriteNumber(0xB4EC + Info.Value * 2, 2, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Count)));
			}
		}

		public bool Look
		{
			get { return SaveData.Instance().ReadBit(0xC0B4 + Info.Value / 4, (Info.Value % 4) * 2); }
			set
			{
				SaveData.Instance().WriteBit(0xC0B4 + Info.Value / 4, (Info.Value % 4) * 2, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Look)));
			}
		}
	}
}
