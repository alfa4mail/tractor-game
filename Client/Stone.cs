using System;
using System.Drawing;
namespace WindowsApplication2
{
	[Serializable]
	class Stone: MovePlayer
	{
		private Boolean moveActive = false;
		protected Direction myDirection;
		public Stone(Int32 cageX, Int32 cageY,String namePicture): base(cageX,cageY,namePicture)
		{
			myName = ItemName.Stone;
		}
		public Stone(Int32 cageX, Int32 cageY): base(cageX,cageY)
		{
			myName = ItemName.Stone;
			player = new Bitmap("Stone.bmp");
		}
		public Direction StoneDirec
		{
			get{return myDirection;}
		}
		public Boolean MOVEACTIVE
		{
			get {return moveActive;}
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

			// Камень падает влево
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
			// Камень падает вправо
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
