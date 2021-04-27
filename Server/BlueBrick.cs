using System;
using System.Drawing;
namespace WindowsApplication2
{
	[Serializable]
	class BlueBrick: Item
	{
		public BlueBrick(Int32 cageX, Int32 cageY,String namePicture): base(cageX,cageY,namePicture)
		{
			myName = ItemName.BlueBrick;
		}
		public BlueBrick(Int32 cageX, Int32 cageY): base(cageX,cageY)
		{
			myName = ItemName.BlueBrick;
		player = new Bitmap("BlueBrick.bmp");
		}
	}
}
