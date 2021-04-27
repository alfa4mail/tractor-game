using System;

namespace WindowsApplication2
{
	enum Direction {Left,Right,Up,Down};
	[Serializable]
	abstract class MovePlayer: Item
	{	
		public MovePlayer(Int32 cageX, Int32 cageY,String namePicture): base(cageX,cageY,namePicture)
		{
		}
		public MovePlayer(Int32 cageX, Int32 cageY): base(cageX,cageY)
		{
		}		
	}
}
