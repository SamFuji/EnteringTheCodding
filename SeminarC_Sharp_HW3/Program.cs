Console.Clear();

Console.Write("Enter the number:"); 
int number = Convert.ToInt32( Console.ReadLine()); 
if (number %2!=0)
{
    Console.Write("The number " + number + " is: ODD");
}
else        
    Console.WriteLine("The number " + number + " is: EVEN");