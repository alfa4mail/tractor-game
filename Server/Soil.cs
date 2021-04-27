//Τΰιλ Soil.cs
using System;
using System.Drawing;
namespace WindowsApplication2
{
	[Serializable]
	class Soil: Item
	{
		public Soil(Int32 cageX, Int32 cageY,String namePicture): base(cageX,cageY,namePicture)
		{
			myName = ItemName.Soil;
		}
		public Soil(Int32 cageX, Int32 cageY): base(cageX,cageY)
		{
			player = new Bitmap("Soil.bmp");
			myName = ItemName.Soil;
		}
	}
}
