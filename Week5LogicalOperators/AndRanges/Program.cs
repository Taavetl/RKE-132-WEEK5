Console.WriteLine(" mis temp on?");
int temp = Int32.Parse(Console.ReadLine());

if (temp >= 30) 
{
    Console.WriteLine("jube kuum");

}
else if (temp > 30 && temp >= 20)
{

    Console.WriteLine("kuum");
}
else if (temp < 20 && temp >= 15)
{
    Console.WriteLine("soe");

}
else if (temp < 15 && temp >= 10)
{
    Console.WriteLine(" jahe");
}
else if ( temp < 10 && temp > 0)
{
    Console.WriteLine("brrrrr");
}
else
{
    Console.WriteLine(" jube brrrr");

}