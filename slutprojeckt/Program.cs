using System;

int i;


{
for (i = 1; i <= 100; i++) 
{
  if (i % 3 == 0){
      Console.WriteLine("Fizz");
  }
    

  if (i % 5 == 0) 
  {
      Console.WriteLine("Buzz");
  }

  if ((i % 3 == 0) && (i % 5 == 0))
  {
      Console.WriteLine("FizzBuzz");
  }
  else 
  {
      Console.WriteLine(i);
  }
}

}


try
{
Console.WriteLine("Nu är det en string");
String stringNumber=i.ToString();
Console.WriteLine(stringNumber);
}
catch
{
Console.WriteLine("Error");
}

Console.ReadLine();
