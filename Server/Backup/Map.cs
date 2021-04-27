//Τΰιλ Map.cs
using System;

namespace WindowsApplication2
{
	enum ItemName {Null,Player,Skier,Stone,Bomb,Soil,Brick,BlueBrick,Trac};
	 class Map
	{
		private static ItemName[,] field;
		static Map()
		{
			field = new ItemName[28,41];
		}
		public static void SetItem(Item pl)
		{
			field[pl.TOP/25,pl.LEFT/25] = pl.MyName;
		}
		public static ItemName GetItem(Item pl)
		{
			ItemName item = field[pl.TOP/25,pl.LEFT/25];
			return item;
		}
		public static ItemName GetItem(Int32 line,Int32 col)
		 {
			ItemName item = field[line, col];
			 return item;
		 }
		public static void SetItem(Int32 line,Int32 col,ItemName Name)
		{
			field[line, col] = Name;
		}
		 public static void ClearMap()
		 {
			 for (Int32 line=0; line<field.GetLength(0);line++)
				 for (Int32 col=0; col<field.GetLength(1);col++)
					field[line, col] = ItemName.Null;
		 }
	}
}
