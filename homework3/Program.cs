//Задача 6: Выяснить является ли число чётным
Console.WriteLine("Write a number:");
int number = Convert.ToInt16(Console.ReadLine());
if( number % 2 == 0)
{
    Console.WriteLine("cislo cetnoe");
}
else{
    Console.WriteLine("necotnoe");
}