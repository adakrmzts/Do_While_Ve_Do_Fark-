/*
int sayac = 0;
int Limitdegeri = 0;

Console.WriteLine("Bir limit değeri girer misiniz ? ");
Limitdegeri = Convert.ToInt32(Console.ReadLine());


while (sayac <= Limitdegeri)
{
    Console.WriteLine("Ben bir patikalıyım.");
    sayac = sayac + 1;
}
*/

int sayac = 0;
int Limitdegeri = 0;

Console.WriteLine("Bir limit değeri girer misiniz ? ");
Limitdegeri = Convert.ToInt32(Console.ReadLine());

do
{
    Console.WriteLine("Ben bir patikalıyım.");
    sayac = sayac + 1;

}
 while (sayac <= Limitdegeri); 