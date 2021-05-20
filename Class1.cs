using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
	class Boat
	{
		public Boat(string v1, string v2, string v3, string v4)
		{
			V1 = v1;
			V2 = v2;
			V3 = v3;
			V4 = v4;
		}

		public string V1 { get; }
		public string V2 { get; }
		public string V3 { get; }
		public string V4 { get; }
		internal void name (string v)
		{
			Console.WriteLine( V1 + ":" + v);
		}
		internal void color(string v)
		{
			Console.WriteLine(V1 +  ":" + v);
		}
		internal void model(string v)
		{
			Console.WriteLine(V1 + ":" + v);
		}
		internal void speed (string v)
		{
			Console.WriteLine(V1 + ":" + v);
		}
		internal void move (Boat v)
		{
			Console.WriteLine("Beneteau move");
		}
		internal void stop (Boat v)
		{
			Console.WriteLine("Beneteau stope");
		}
	}   
}
