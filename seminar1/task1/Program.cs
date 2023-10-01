Console.WriteLine("введите число А");
string numberAstring = Console.ReadLine()!;
int numberA = Convert.ToInt32(numberAstring);
Console.WriteLine("введите число B");
string numberBstring = Console.ReadLine()!;
int numberB = Convert.ToInt32(numberBstring);
if (numberA == numberB * numberB)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}