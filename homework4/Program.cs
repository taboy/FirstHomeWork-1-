//Показать чётные числа от 1 до N.
int CountA = 2;
int CountB = 0;
int CountC = 0;
Console.WriteLine("please write first number");
int FirstNum = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("please write second number");
int SecondNum = Convert.ToInt16(Console.ReadLine());
if(SecondNum % 2 == 0){
    while(CountC < SecondNum -2 ){
        if(FirstNum % 2 ==0){
            CountC = FirstNum +CountA;
            FirstNum = CountC;
            Console.WriteLine(CountC);
        }
        else if(FirstNum % 2 == 1){
            CountB = FirstNum - 1;
            CountC = CountB +CountA;
            FirstNum = CountC;
            Console.WriteLine(CountC);
        }
    }
}    
else if(SecondNum % 2 == 1){
    while(CountC < SecondNum -1 ){
        if(FirstNum % 2 ==0){
            CountC = FirstNum +CountA;
            FirstNum = CountC;
            Console.WriteLine(CountC);
        }
        else if(FirstNum % 2 == 1){
            CountB = FirstNum - 1;
            CountC = CountB +CountA;
            FirstNum = CountC;
            Console.WriteLine(CountC);
        }
    }
}    
