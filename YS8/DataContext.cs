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
		public ObservableCollection<Item> Items { get; set; } = new ObservableCollection<Item>();

		public DataContext()
		{
			foreach (var item in Info.Instance().Items)
			{
				Items.Add(new Item(item));
			}
		}
	}
}
