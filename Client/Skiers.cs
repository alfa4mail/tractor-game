using System;
using System.Collections;
namespace WindowsApplication2
{
	[Serializable]
	class Skiers:  IEnumerable
	{
		protected static Int32 numberSkiers = 0;
		private ArrayList playerList;
		public Skiers()
		{
			playerList = new ArrayList();
		}
		public static Int32 NumberOfSkiers
		{
			get{return numberSkiers;}
			set {numberSkiers = value;}
		}
		public void AddPlayer(Skier p)
		{
			playerList.Add(p);
			numberSkiers++;
		}
		public void ClearAll()
		{
			playerList.Clear();
			numberSkiers = 0;
		}
		public void RemovePlayer(Int32 p)
		{
			playerList.RemoveAt(p);
			numberSkiers--;
		}
		public int IndexOf(Skier p)
		{
			return playerList.IndexOf(p);
		}
		public IEnumerator GetEnumerator()
			{ return playerList.GetEnumerator(); }
	}
}
