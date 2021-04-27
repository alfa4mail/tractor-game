using System;
using System.Collections;
namespace WindowsApplication2
{
	[Serializable]
	class Bricks:  IEnumerable
	{
		private ArrayList playerList;
		public Bricks()
		{
			playerList = new ArrayList();
		}
		public void AddPlayer(Brick p)
		{playerList.Add(p);}
		public void ClearAll()
		{playerList.Clear();}
		public void RemovePlayer(int p)
		{playerList.RemoveAt(p);}
		public IEnumerator GetEnumerator()
		{ return playerList.GetEnumerator(); }
	}
}
