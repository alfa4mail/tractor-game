using System;
using System.Collections;
namespace WindowsApplication2
{
	[Serializable]
	class Bombs: IEnumerable
	{
		private ArrayList playerList;
		public Bombs()
		{
			playerList = new ArrayList();
		}
		public void AddPlayer(Bomb p)
		{playerList.Add(p);}
		public void ClearAll()
		{playerList.Clear();}
		public void RemovePlayer(Int32 p)
		{playerList.RemoveAt(p);}

		public int IndexOf(Bomb p)
		{return playerList.IndexOf(p);}

		public int CountPlayer
		{get {return playerList.Count;}}

		public IEnumerator GetEnumerator()
		{ return playerList.GetEnumerator(); }
	}
}
