using System;
using System.Drawing;
namespace WindowsApplication2
{
	[Serializable]
	class Player: MovePlayer
	{
		protected Direction myDirection;
		protected Boolean bombNowCreate = false;
		protected Int32 life =1;
		public Player(Int32 cageX, Int32 cageY,String namePicture): base(cageX, cageY,namePicture)
		{
			myName = ItemName.Trac;
			myDirection = Direction.Right;
		}
		public Player(Int32 cageX, Int32 cageY): base(cageX, cageY)
		{
			myName = ItemName.Trac;
			myDirection = Direction.Right;
			player = new Bitmap("PlayerRight.bmp");
		}
		public Int32 LIFE
		{
			get{return life;}
			set{life = value;}
		}
		public Direction Direc
		{
			get{return myDirection;}
		}
		public Boolean BombNowCreate
		{
			get{return bombNowCreate;}
			set{bombNowCreate = value;}
		}
		public   Boolean Moving(System.Windows.Forms.KeyPressEventArgs e, 
			Soils soilList,Stones stoneList,Bombs bombList)
		{
			if ((e.KeyChar.ToString() == "p") || (e.KeyChar.ToString() == "ç"))
			{
				BombNowCreate = true;
				if ((myDirection == Direction.Left) &&
					(Map.GetItem(this.TOP/25,this.LEFT/25-1) == ItemName.Null))//left
					bombList.AddPlayer(new Bomb(left/25-1, top/25));
				if ((myDirection == Direction.Right) &&
					(Map.GetItem(this.TOP/25,this.LEFT/25+1) == ItemName.Null))//right
					bombList.AddPlayer(new Bomb(left/25+1, top/25));
				if ((myDirection == Direction.Up) &&
					(Map.GetItem(this.TOP/25-1,this.LEFT/25) == ItemName.Null))//up
					bombList.AddPlayer(new Bomb(left/25, top/25-1));
				if ((myDirection == Direction.Down) &&
					(Map.GetItem(this.TOP/25+1,this.LEFT/25) == ItemName.Null))	//down
					bombList.AddPlayer(new Bomb(left/25, top/25+1));
			}
			else if ((e.KeyChar.ToString() == "a") || (e.KeyChar.ToString() == "ô"))
			{	
				RemoveLeftSoil(soilList);
				if (Map.GetItem(this.TOP/25,this.LEFT/25-1) == ItemName.Null)//left
				{	
					left -= size;
					player = new Bitmap("ClientLeft.bmp");
					myDirection = Direction.Left;
					return true;
				}
			}
			else if ((e.KeyChar.ToString() == "d") || (e.KeyChar.ToString() == "â"))
			{
				RemoveRightSoil(soilList);
				if (Map.GetItem(this.TOP/25,this.LEFT/25+1) == ItemName.Null)//right
				{	
					left += size;
					player = new Bitmap("ClientRight.bmp");
					myDirection = Direction.Right;
					return true;
				}
			}
			else if ((e.KeyChar.ToString() == "w") || (e.KeyChar.ToString() == "ö"))
			{
				RemoveUpSoil(soilList);
				if (Map.GetItem(this.TOP/25-1,this.LEFT/25) == ItemName.Null)//up
				{
					top -= size;
					player = new Bitmap("ClientUp.bmp");
					myDirection = Direction.Up;
					return true;
				}
			}
			else if ((e.KeyChar.ToString() == "s") || (e.KeyChar.ToString() == "û"))
			{
				RemoveDownSoil(soilList);
				if (Map.GetItem(this.TOP/25+1,this.LEFT/25) == ItemName.Null)	//down
				{
					top += size;
					player = new Bitmap("ClientDown.bmp");
					myDirection = Direction.Down;
					return true;
				}
			}
			return false;
		}

		public   Boolean Moving(String str,Soils soilList,Stones stoneList,Bombs bombList)
		{
			if (str == "Bomb") 
			{
				if ((myDirection == Direction.Left) &&
					(Map.GetItem(this.TOP/25,this.LEFT/25-1) == ItemName.Null))//left
					bombList.AddPlayer(new Bomb(left/25-1, top/25));
				if ((myDirection == Direction.Right) &&
					(Map.GetItem(this.TOP/25,this.LEFT/25+1) == ItemName.Null))//right
					bombList.AddPlayer(new Bomb(left/25+1, top/25));
				if ((myDirection == Direction.Up) &&
					(Map.GetItem(this.TOP/25-1,this.LEFT/25) == ItemName.Null))//up
					bombList.AddPlayer(new Bomb(left/25, top/25-1));
				if ((myDirection == Direction.Down) &&
					(Map.GetItem(this.TOP/25+1,this.LEFT/25) == ItemName.Null))	//down
					bombList.AddPlayer(new Bomb(left/25, top/25+1));
			}
		else	if (str == "Left")
			{	
				RemoveLeftSoil(soilList);
				if ((Map.GetItem(this.TOP/25,this.LEFT/25-1) == ItemName.Stone) &&
					(Map.GetItem(this.TOP/25,this.LEFT/25-2) == ItemName.Null))//left stone
				{	
					foreach (Stone st in stoneList)
					{
						if ((st.LEFT == this.LEFT - 25) && (st.TOP == this.TOP))
						{
							Map.SetItem(st.TOP/25,st.LEFT/25,ItemName.Null);
							st.LEFT -= 25;
							Map.SetItem(st.TOP/25,st.LEFT/25,ItemName.Stone);
						}
					}
				}
				else if ((Map.GetItem(this.TOP/25,this.LEFT/25-1) == ItemName.Bomb) &&
					(Map.GetItem(this.TOP/25,this.LEFT/25-2) == ItemName.Null))//left bomb
				{	
					foreach (Bomb st in bombList)
					{
						if ((st.LEFT == this.LEFT - 25) && (st.TOP == this.TOP))
						{
							Map.SetItem(st.TOP/25,st.LEFT/25,ItemName.Null);
							st.LEFT -= 25;
							Map.SetItem(st.TOP/25,st.LEFT/25,ItemName.Bomb);
						}
					}
				}
				if (Map.GetItem(this.TOP/25,this.LEFT/25-1) == ItemName.Null)//left
				{	
					left -= size;
					player = new Bitmap("PlayerLeft.bmp");
					myDirection = Direction.Left;
					return true;
				}
			}
			else if(str == "Right")
			{
				RemoveRightSoil(soilList);
				if ((Map.GetItem(this.TOP/25,this.LEFT/25+1) == ItemName.Stone) &&
					(Map.GetItem(this.TOP/25,this.LEFT/25+2) == ItemName.Null))//left stone or bomb
				{	
					foreach (Stone st in stoneList)
					{
						if ((st.LEFT == this.LEFT + 25) && (st.TOP == this.TOP))
						{
							Map.SetItem(st.TOP/25,st.LEFT/25,ItemName.Null);
							st.LEFT += 25;
							Map.SetItem(st.TOP/25,st.LEFT/25,ItemName.Stone);
						}
					}
				}
				else if ((Map.GetItem(this.TOP/25,this.LEFT/25+1) == ItemName.Bomb) &&
					(Map.GetItem(this.TOP/25,this.LEFT/25+2) == ItemName.Null))//left bomb
				{	
					foreach (Bomb st in bombList)
					{
						if ((st.LEFT == this.LEFT + 25) && (st.TOP == this.TOP))
						{
							Map.SetItem(st.TOP/25,st.LEFT/25,ItemName.Null);
							st.LEFT += 25;
							Map.SetItem(st.TOP/25,st.LEFT/25,ItemName.Bomb);
						}
					}
				}
				if (Map.GetItem(this.TOP/25,this.LEFT/25+1) == ItemName.Null)//right
				{	
					left += size;
					player = new Bitmap("PlayerRight.bmp");
					myDirection = Direction.Right;
					return true;
				}
			}
			else if (str == "Up")
			{
				RemoveUpSoil(soilList);
				if (Map.GetItem(this.TOP/25-1,this.LEFT/25) == ItemName.Null)//up
				{
					top -= size;
					player = new Bitmap("PlayerUp.bmp");
					myDirection = Direction.Up;
					return true;
				}
			}
			else if (str == "Down")
			{
				RemoveDownSoil(soilList);
				if (Map.GetItem(this.TOP/25+1,this.LEFT/25) == ItemName.Null)	//down
				{
					top += size;
					player = new Bitmap("PlayerDown.bmp");
					myDirection = Direction.Down;
					return true;
				}
			}
			return false;
		}
		#region Remove Soil
		private void RemoveLeftSoil(Soils soilList)
		{
			if (Map.GetItem(this.TOP/25,this.LEFT/25-1) == ItemName.Soil)//left
			{
				Int32 indexSoil=0;
				Boolean deleteTrue = false;
				foreach (Soil so in soilList)
					if ((this.LEFT == (so.LEFT+25)) && (this.TOP == so.TOP))
					{
						deleteTrue = true;
						indexSoil = soilList.IndexOf(so);
						Map.SetItem(so.TOP/25,so.LEFT/25,ItemName.Null);
					}
				if (deleteTrue == true) soilList.RemovePlayer(indexSoil);
			}
		}
		private void RemoveRightSoil(Soils soilList)
		{
			if (Map.GetItem(this.TOP/25,this.LEFT/25+1) == ItemName.Soil)//right
			{
				Int32 indexSoil=0;
				Boolean deleteTrue = false;
				foreach (Soil so in soilList)
					if ((this.LEFT == (so.LEFT-25)) && (this.TOP == so.TOP))
					{
						deleteTrue = true;
						indexSoil = soilList.IndexOf(so);
						Map.SetItem(so.TOP/25,so.LEFT/25,ItemName.Null);
					}
				if (deleteTrue == true) soilList.RemovePlayer(indexSoil);
			}
		}
		private void RemoveUpSoil(Soils soilList)
		{
			if (Map.GetItem(this.TOP/25-1,this.LEFT/25) == ItemName.Soil)//up
			{
				Int32 indexSoil=0;
				Boolean deleteTrue = false;
				foreach (Soil so in soilList)
					if ((this.LEFT == so.LEFT) && (this.TOP == (so.TOP+25)))
					{
						deleteTrue = true;
						indexSoil = soilList.IndexOf(so);
						Map.SetItem(so.TOP/25,so.LEFT/25,ItemName.Null);
					}
				if (deleteTrue == true) soilList.RemovePlayer(indexSoil);
			}
		}
		private void RemoveDownSoil(Soils soilList)
		{
			if (Map.GetItem(this.TOP/25+1,this.LEFT/25) == ItemName.Soil)	//down
			{
				Int32 indexSoil=0;
				Boolean deleteTrue = false;
				foreach (Soil so in soilList)
					if ((this.LEFT == so.LEFT) && (this.TOP == (so.TOP-25)))
					{
						deleteTrue = true;
						indexSoil = soilList.IndexOf(so);
						Map.SetItem(so.TOP/25,so.LEFT/25,ItemName.Null);
					}
				if (deleteTrue == true) soilList.RemovePlayer(indexSoil);
			}
		}
		#endregion
	}
}