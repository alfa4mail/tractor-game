using System;
using System.Drawing;
namespace WindowsApplication2
{
	[Serializable]
	class Bomb: MovePlayer
	{
		private Boolean moveActive = false;
		protected Direction myDirection;
		public Bomb(Int32 cageX, Int32 cageY,String namePicture): base(cageX,cageY,namePicture)
		{
			myName = ItemName.Bomb;
		}
		public Bomb(Int32 cageX, Int32 cageY): base(cageX,cageY)
		{
			myName = ItemName.Bomb;
			player = new Bitmap("Bomb.bmp");
		}
		public Direction BombDirec
		{
			get{return myDirection;}
		}
		public Boolean Moving(Player trac)
		{
			if ((Map.GetItem(this.TOP/25+1,this.LEFT/25) == ItemName.Trac) && (moveActive == true))
			{
				trac.LIFE--;
				return false;
			}
			else moveActive = false;
			if (Map.GetItem(this.TOP/25+1,this.LEFT/25) == ItemName.Null)	//down
			{
				myDirection = Direction.Down;
				this.top += size;
				moveActive = true;  //!!!!
				return true;
			}
			else moveActive = false;

			// Бомба падает влево
			if ((Map.GetItem(this.TOP/25,this.LEFT/25-1) == ItemName.Null) && 
				(Map.GetItem(this.TOP/25+1,this.LEFT/25-1) == ItemName.Null) && 
				((Map.GetItem(this.TOP/25+1,this.LEFT/25) == ItemName.Bomb) ||
				(Map.GetItem(this.TOP/25+1,this.LEFT/25) == ItemName.Brick) ||
				(Map.GetItem(this.TOP/25+1,this.LEFT/25) == ItemName.Stone)))			
			{
				myDirection = Direction.Left;
				this.left -= size;
				moveActive = true; 
				return true;
			}
			// Бомба падает вправо
			if ((Map.GetItem(this.TOP/25,this.LEFT/25+1) == ItemName.Null) &&
				(Map.GetItem(this.TOP/25+1,this.LEFT/25+1) == ItemName.Null) && 
				((Map.GetItem(this.TOP/25+1,this.LEFT/25) == ItemName.Bomb) ||
				(Map.GetItem(this.TOP/25+1,this.LEFT/25) == ItemName.Brick) ||
				(Map.GetItem(this.TOP/25+1,this.LEFT/25) == ItemName.Stone)))			
			{
				myDirection = Direction.Right;
				this.left += size;
				moveActive = true; 
				return true;
			}
			return false;
		}
	}
}
