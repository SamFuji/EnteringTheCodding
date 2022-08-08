Console.Clear();

// Программа, получающая на вводе два числа, а на выходе показывающая максимальное значение

// Console.Write("Enter the number1:"); //Консоль пишет:
// int number1 = Convert.ToInt32( Console.ReadLine()); //Консоль считывает введённое число
// Console.Write("Enter the number2:"); //после этого консоль запрашивает второе число
// int number2 = Convert.ToInt32( Console.ReadLine()); //Вводим второе
// int max;
// if(number1 >= number2)
// {
//    Console.WriteLine("The max number is:" + max);
// }
// else       
//    Console.WriteLine("The max number is:" + number2);

//Второй вариант решения:

Console.Write("Enter the number1:"); //Консоль пишет:
int number1 = Convert.ToInt32( Console.ReadLine()); //Консоль считывает введённое число
Console.Write("Enter the number2:"); //после этого консоль запрашивает второе число
int number2 = Convert.ToInt32( Console.ReadLine()); //Вводим второе
int max;
if(number1 >= number2)
    max=number1;
else max=number2;       
    Console.WriteLine("The max number is:" + max);




