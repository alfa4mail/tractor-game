using System;
using System.Drawing;
using System.Collections;
namespace WindowsApplication2
{
	[Serializable]
	abstract class Item
	{
		protected ItemName myName;
		protected Image player;	
		protected const SByte size = 25;
		protected Int32 top;
		protected Int32 left;
		public Item(Int32 cageX, Int32 cageY, String namePicture)
		{
			top  = cageY*size;
			left = cageX*size;
			player = new Bitmap(namePicture);
		}
		public Item(Int32 cageX, Int32 cageY)
		{
			top  = cageY*size;
			left = cageX*size;
		}
		public Int32 TOP
		{
			get {return top;}
			set {top = value;}
		}
		public ItemName MyName
		{
			get {return myName;}
			set {myName = value;}
		}

		public Int32 LEFT
		{
			get {return left;}
			set {left = value;}
		}
		public void Drawing(System.Windows.Forms.PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			g.DrawImage(this.player, this.left, this.top,25,25);
		}
	}
}
