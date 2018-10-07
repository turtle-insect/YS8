using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YS8
{
    class Charactor
    {
		private uint mBaseAddress;
		public String Name { get; set; }

		public Charactor(uint address, String name)
		{
			mBaseAddress = address;
			Name = name;
		}

		public uint Weapon
		{
			get { return SaveData.Instance().ReadNumber(mBaseAddress, 2); }
			set { SaveData.Instance().WriteNumber(mBaseAddress, 2, value); }
		}

		public uint Body
		{
			get { return SaveData.Instance().ReadNumber(mBaseAddress + 2, 2); }
			set { SaveData.Instance().WriteNumber(mBaseAddress + 2, 2, value); }
		}

		public uint Arm
		{
			get { return SaveData.Instance().ReadNumber(mBaseAddress + 4, 2); }
			set { SaveData.Instance().WriteNumber(mBaseAddress + 4, 2, value); }
		}

		public uint Accesory1
		{
			get { return SaveData.Instance().ReadNumber(mBaseAddress + 6, 2); }
			set { SaveData.Instance().WriteNumber(mBaseAddress + 6, 2, value); }
		}

		public uint Accesory2
		{
			get { return SaveData.Instance().ReadNumber(mBaseAddress + 8, 2); }
			set { SaveData.Instance().WriteNumber(mBaseAddress + 8, 2, value); }
		}
	}
}
