var name = "Ewa";
var male = "Kobieta";
var age = 30;

if (age < 30 && male == "Kobieta")
{
    Console.WriteLine("Kobieta ponizej 30 lat");
}
else if (name == "Ewa" &&  age == 30)
{
    Console.WriteLine("Ewa, lat 30");
}
else if (male == "Mezczyzna" && age < 18)
{
    Console.WriteLine("Niepelnoletni mezczyzna");
}
else
{
    Console.WriteLine("");
}