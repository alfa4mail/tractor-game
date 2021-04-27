//Τΰιλ Soils.cs
using System;
using System.Collections;
namespace WindowsApplication2
{
	[Serializable]
	class Soils:  IEnumerable
	{
		private ArrayList playerList;
		public Soils()
		{
			playerList = new ArrayList();
		}
		public void AddPlayer(Soil p)
		{playerList.Add(p);}
		public int IndexOf(Soil p)
		{
			return playerList.IndexOf(p);
		}
		public void ClearAll()
		{playerList.Clear();}
		public void RemovePlayer(int p)
		{playerList.RemoveAt(p);}
		public IEnumerator GetEnumerator()
		{ return playerList.GetEnumerator(); }
	}
}
