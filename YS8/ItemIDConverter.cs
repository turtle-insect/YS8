using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace YS8
{
	class ItemIDConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			uint id = (uint)value;
			for (uint i = 0; i < Info.Instance().Items.Count; i++)
			{
				if (Info.Instance().Items[(int)i].Value == id) return i;
			}
			return -1;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			int index = (int)value;
			if (Info.Instance().Items.Count > index) return Info.Instance().Items[index].Value;
			return 0xFFFF;
		}
	}
}
