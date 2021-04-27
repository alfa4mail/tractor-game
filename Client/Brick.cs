using System;
using System.Drawing;
namespace WindowsApplication2
{
	[Serializable]
	class Brick: Item
	{
		public Brick(Int32 cageX, Int32 cageY,String namePicture): base(cageX,cageY,namePicture)
		{
			myName = ItemName.Brick;
		}
		public Brick(Int32 cageX, Int32 cageY): base(cageX,cageY)
		{
			myName = ItemName.Brick;
			player = new Bitmap("Brick.bmp");
		}
	}
}
