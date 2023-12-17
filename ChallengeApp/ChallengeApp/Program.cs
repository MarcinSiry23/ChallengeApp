var name = "Ewa";
bool female = true;
var age = 30;
if (female)
{
    if (age < 30) 
    {
        Console.WriteLine("Kobieta poniżej 30 lat"); 
    }
    else if (name == "Ewa" && age == 30) 
    {
        Console.WriteLine("Ewa, lat 30");
    }
}
if (!female && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
{
  
}
