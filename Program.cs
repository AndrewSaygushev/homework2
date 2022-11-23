// TASK 10

/*int number = new Random().Next(100,1000);
Console.WriteLine(number);
int result = (number/10 %10);
Console.WriteLine(result);*/


// TASK 13

/*int Number = new Random().Next(1, 1500);
System.Console.WriteLine();
System.Console.WriteLine($"Entered the number {Number}");
if (Number / 100 < 1)
{
    Console.WriteLine($"There is no third digit");
}
else
{
    if (Number / 1000 >= 1)
    {
        Console.WriteLine($"The third digit of number {Number} is {Number / 10 % 10}");
    }
    else 
    {
        Console.WriteLine($"The third digit of number {Number} is {Number % 10}");
    }
}
System.Console.WriteLine();*/


// TASK15

Console.WriteLine("Please enter the number");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number < 1 || Number > 7)
{
    Console.WriteLine($"{Number} - There is no such day of the week");
}
else 
{
    if (Number == 6 || Number == 7 )
    {
        Console.WriteLine($"{Number} - This is a holiday:)");
    }
    else
    {
        Console.WriteLine($"{Number} - This is a weekday;(");
    }
}
Console.WriteLine();

