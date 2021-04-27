//Файл Skier.cs
using System;
using System.Drawing;
namespace WindowsApplication2
{
	[Serializable]
	class Skier: MovePlayer
	{
		protected Direction myDirection;
		public Skier(Int32 cageX, Int32 cageY,String namePicture, Direction myDirec): base(cageX, cageY,namePicture)
		{
			myName = ItemName.Skier;
			myDirection = myDirec;
		}
		public Skier(Int32 cageX, Int32 cageY): base(cageX, cageY)
		{
			myName = ItemName.Skier;
			player = new Bitmap("SkierUp.bmp");
			myDirection = Direction.Up;
		}
		public Direction Direc
		{
			get{return myDirection;}
		}

		public  Boolean Moving(Stones stoneList,Bombs bombList)
		{
			switch (myDirection)
			{
				case Direction.Up:
					if (Map.GetItem(this.TOP/25-1,this.LEFT/25) == ItemName.Stone) return false;
					if (Map.GetItem(this.TOP/25-1,this.LEFT/25) == ItemName.Bomb) return false;

					// Дописать проверку игрока

					if (Map.GetItem(this.TOP/25-1,this.LEFT/25) == ItemName.Null)//up
					{
						player = new Bitmap("SkierUp.bmp");
						myDirection = Direction.Up;
						top -= size;
						return true;
					}
					else if (Map.GetItem(this.TOP/25,this.LEFT/25+1) == ItemName.Null)//right
					{
						left += size;
						player = new Bitmap("SkierRight.bmp");
						myDirection = Direction.Right;
						return true;
					}
					else if (Map.GetItem(this.TOP/25+1,this.LEFT/25) == ItemName.Null)	//down
					{
						player = new Bitmap("SkierDown.bmp");
						myDirection = Direction.Down;
						top += size;
						return true;
					}
					else if (Map.GetItem(this.TOP/25,this.LEFT/25-1) == ItemName.Null)//left
					{
						player = new Bitmap("SkierLeft.bmp");
						myDirection = Direction.Left;
						left -= size;
						return true;
					}
					break;
				case Direction.Down:
					if (Map.GetItem(this.TOP/25-1,this.LEFT/25) == ItemName.Stone) return false;
					if (Map.GetItem(this.TOP/25-1,this.LEFT/25) == ItemName.Bomb) return false;
					if (Map.GetItem(this.TOP/25+1,this.LEFT/25) == ItemName.Null)	//down
					{
						player = new Bitmap("SkierDown.bmp");
						myDirection = Direction.Down;
						top += size;
						return true;
					}
					else if (Map.GetItem(this.TOP/25,this.LEFT/25-1) == ItemName.Null)//left
					{
						player = new Bitmap("SkierLeft.bmp");
						myDirection = Direction.Left;
						left -= size;
						return true;
					}
					else if (Map.GetItem(this.TOP/25-1,this.LEFT/25) == ItemName.Null)//up
					{
						player = new Bitmap("SkierUp.bmp");
						myDirection = Direction.Up;
						top -= size;
						return true;
					}
					else if (Map.GetItem(this.TOP/25,this.LEFT/25+1) == ItemName.Null)//right
					{
						left += size;
						player = new Bitmap("SkierRight.bmp");
						myDirection = Direction.Right;
						return true;
					}
					break;
				case Direction.Left:
					if (Map.GetItem(this.TOP/25-1,this.LEFT/25) == ItemName.Stone) return false;
					if (Map.GetItem(this.TOP/25-1,this.LEFT/25) == ItemName.Bomb) return false;

					if (Map.GetItem(this.TOP/25,this.LEFT/25-1) == ItemName.Null)//left
					{
						player = new Bitmap("SkierLeft.bmp");
						myDirection = Direction.Left;
						left -= size;
						return true;
					}
					else if (Map.GetItem(this.TOP/25-1,this.LEFT/25) == ItemName.Null)//up
					{
						player = new Bitmap("SkierUp.bmp");
						myDirection = Direction.Up;
						top -= size;
						return true;
					}
					else if (Map.GetItem(this.TOP/25,this.LEFT/25+1) == ItemName.Null)//right
					{
						left += size;
						player = new Bitmap("SkierRight.bmp");
						myDirection = Direction.Right;
						return true;
					}
					else if (Map.GetItem(this.TOP/25+1,this.LEFT/25) == ItemName.Null)	//down
					{
						player = new Bitmap("SkierDown.bmp");
						myDirection = Direction.Down;
						top += size;
						return true;
					}
					break;
				case Direction.Right:
					if (Map.GetItem(this.TOP/25-1,this.LEFT/25) == ItemName.Stone) return false;
					if (Map.GetItem(this.TOP/25-1,this.LEFT/25) == ItemName.Bomb) return false;

					if (Map.GetItem(this.TOP/25,this.LEFT/25+1) == ItemName.Null)//right
					{
						left += size;
						player = new Bitmap("SkierRight.bmp");
						myDirection = Direction.Right;
						return true;
					}
					else if (Map.GetItem(this.TOP/25+1,this.LEFT/25) == ItemName.Null)	//down
					{
						player = new Bitmap("SkierDown.bmp");
						myDirection = Direction.Down;
						top += size;
						return true;
					}
					else if (Map.GetItem(this.TOP/25,this.LEFT/25-1) == ItemName.Null)//left
					{
						player = new Bitmap("SkierLeft.bmp");
						myDirection = Direction.Left;
						left -= size;
						return true;
					}
					else if (Map.GetItem(this.TOP/25-1,this.LEFT/25) == ItemName.Null)//up
					{
						player = new Bitmap("SkierUp.bmp");
						myDirection = Direction.Up;
						top -= size;
						return true;
					}
					break;
			}
			return false;
		}
	}
}
