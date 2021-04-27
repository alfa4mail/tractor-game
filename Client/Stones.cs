using System;
using System.Collections;
namespace WindowsApplication2
{
	[Serializable]
	class Stones: IEnumerable //public убрал
	{
		private ArrayList playerList;
		public Stones()
		{
			playerList = new ArrayList();
		}
		public void AddPlayer(Stone p)
		{playerList.Add(p);}
		public void ClearAll()
		{playerList.Clear();}
		public void RemovePlayer(Int32 p)
		{playerList.RemoveAt(p);}

		public int IndexOf(Stone p)
		{return playerList.IndexOf(p);}

		public int CountPlayer
		{get {return playerList.Count;}}

		public IEnumerator GetEnumerator()
		{ return playerList.GetEnumerator(); }
	}
}
