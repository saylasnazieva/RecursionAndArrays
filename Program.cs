//  Задача 41. Пользователь вводит с клавиатуры М чисел.Посчитайте , сколько чисел больше 0 ввел пользовватель.
// 0,7,8,-2,-2,-> 2.      1,-7,567,89,223 -> 3;
/*
Console.WriteLine ("Enter a number :");
string numbers = Console.ReadLine();


string [] newNumbers = new string [numbers.Length];

int M = 0;

for (int i = 0; i < newNumbers.Length; i++)

{

  if (numbers[i] == ',')

  {

    M++;

  }

  else

  {

    newNumbers[M] = newNumbers[M]+$"{numbers[i]}";

  }

}

M++;

int [] resultNumbers = new int[M];

PrintArray (resultNumbers, newNumbers);

int sum = 0;

for (int i = 0; i < M; i++)

{

  if (resultNumbers[i]>0)

  {

    sum++;

  }

}

Console.WriteLine ("Number of count 0: "+sum);




void PrintArray (int [] array, string [] string1)

{

  for (int i = 0; i < array.Length; i++)

  {

  array[i] = Convert.ToInt32(string1[i]);

  Console.Write (array[i]+"  ");

  }

Console.WriteLine();
}
*/

// Задача 43. Напишите программу , которая найдет точку пересечения двух прямых , заданных уравнениями y = k 1 * x + b1, y = k2 * x + b2;
// и k2 задаются пользователем.
// b1 = 2, k1 = 5 , b2 = 4 , k2 = 9 -> (-0,5; -0,5)
/*
Console.Write("Enter k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());

var  x = -(b1 - b2) / (k1 - k2);
var  y = k1 * x + b1;

x = Math.Round(x, 3);
y = Math.Round(y, 3);

Console.WriteLine($" intersection of points : ({x};{y})");
*/