using System;
using System.Collections;
namespace WindowsApplication2
{
	[Serializable]
	class BlueBricks:  IEnumerable
	{
		private ArrayList playerList;
		public BlueBricks()
		{
			playerList = new ArrayList();
		}
		public void AddPlayer(BlueBrick p)
		{playerList.Add(p);}
		public void ClearAll()
		{playerList.Clear();}
		public void RemovePlayer(int p)
		{playerList.RemoveAt(p);}
		public IEnumerator GetEnumerator()
		{ return playerList.GetEnumerator(); }
	}
}
