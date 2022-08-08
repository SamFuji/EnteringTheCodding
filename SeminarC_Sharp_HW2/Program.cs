Console.Clear();

// Console.Write("Enter the number1:"); 
// int number1 = Convert.ToInt32( Console.ReadLine()); 
// Console.Write("Enter the number2:"); 
// int number2 = Convert.ToInt32( Console.ReadLine()); 
// Console.Write("Enter the number3:"); 
// int number3 = Convert.ToInt32( Console.ReadLine()); 
// int max;
// if(number1 >= number2)
//     max = number1
// {
//    Console.WriteLine("The max number is:" + max);
// }
// else       
//    Console.WriteLine("The max number is:" + number2);


// нахождение максимального числа из трёх чисел

int number1 = new Random().Next(1,1000001);
int number2 = new Random().Next(1,1000001); 
int number3 = new Random().Next(1,1000001);
Console.WriteLine(number1); 
Console.WriteLine(number2);
Console.WriteLine(number3);
int max = number1;

if (number2 >= max) max = number2;
if (number3 >= max) max = number3;

Console.WriteLine("Maximum is: " + max);


