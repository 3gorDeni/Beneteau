using System;

namespace ConsoleApp13
{
	
		class Program
		{
		    static void Main(string[] args)
			{

				Boat Beneteau = new Boat("Beneteau", "White", "ER-256", "100 km/h");
			    Beneteau.name("Benetaeu");
			    Beneteau.color("White");
			    Beneteau.model("ER-256");
			    Beneteau.speed("100 km/h");
			    Beneteau.move(Beneteau);
			    Beneteau.stop(Beneteau);
			} 
		}
}
