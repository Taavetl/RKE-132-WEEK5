int math, biology, chemistry;

Console.WriteLine("Mata tulemus:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("bio tulemus:");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Kema tulemus:");
chemistry = Int32.Parse(Console.ReadLine());

if(( math >= 90 && chemistry >= 90 || (math >= 90 && biology >= 90) || chemistry>= 90 && biology >= 90))
{
    Console.WriteLine("oled sees");

}
else
{
    Console.WriteLine("luuser");
}