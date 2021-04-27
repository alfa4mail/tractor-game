//Τΰιλ PlaceList.cs
using System;
namespace WindowsApplication2
{
	[Serializable]
	class PlaceList
	{
		private Skiers skiers = new Skiers();
		private Soils soils  = new Soils();
		private Bricks bricks = new Bricks();
		private Bombs bombs = new Bombs();
		private BlueBricks blueBricks = new BlueBricks();
		private Stones stones = new Stones();
		private Player thisPlayer = new Player(0,0);
		private Player thisPlayer2 = new Player(0,0);
		public PlaceList(Bricks brickList,BlueBricks blueBrickList,Soils soilList,
			Stones stoneList, Skiers skiList,Bombs bombList,Player trac,Player trac2)
		{
			foreach (Brick br in brickList)
				bricks.AddPlayer(br);
			foreach (BlueBrick br in blueBrickList)
				blueBricks.AddPlayer(br);
			foreach (Soil br in soilList)
				soils.AddPlayer(br);
			foreach (Stone br in stoneList)
				stones.AddPlayer(br);
			foreach (Skier br in skiList)
				skiers.AddPlayer(br);
			foreach (Bomb br in bombList)
				bombs.AddPlayer(br);
			thisPlayer = trac;
			thisPlayer2 = trac2;
		}
		public void SetList(ref Bricks brickList,ref BlueBricks blueBrickList,ref Soils soilList,
			ref Stones stoneList, ref Skiers skiList,ref Bombs bombList,ref Player trac,ref Player trac2)
		{
			foreach (Brick br in bricks)
				brickList.AddPlayer(br);
			foreach (BlueBrick br in blueBricks)
				blueBrickList.AddPlayer(br);
			foreach (Soil br in soils)
				soilList.AddPlayer(br);
			foreach (Stone br in stones)
				stoneList.AddPlayer(br);
			foreach (Skier br in skiers)
				skiList.AddPlayer(br);
			foreach (Bomb br in bombs)
				bombList.AddPlayer(br);
			trac = thisPlayer;
			trac2 = thisPlayer2;
		}
	}
}