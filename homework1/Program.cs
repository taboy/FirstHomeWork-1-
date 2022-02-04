//Задача 2: Даны два числа. Показать большее и меньшее число



Console.WriteLine("write first number");
int first_number = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("write second number");
int second_number = Convert.ToInt16(Console.ReadLine());
if(first_number> second_number)
{
    Console.WriteLine("The first number is greater than the second. " + "Lesser number: "+ second_number+ " Highest number: "+ first_number);
}
else if( first_number< second_number)
{
    Console.WriteLine("The second number is greater than the first."+ "Lesser number: "+ first_number+ " Highest number: "+ second_number);
}
else{
    Console.WriteLine("First number equals second number");