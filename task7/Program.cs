void fillArray(double[] collection)
{
  for (int i = 0; i < collection.Length; i++)
  {
    collection[i] = new Random().Next(0, 10);
  }
}
void printArray(double[] col)
{
  for (int i = 0; i < col.Length; i++)
  {
    Console.Write($"{col[i]},");
  }
}

Console.WriteLine("Введите длинну массива:");
int n = int.Parse(Console.ReadLine()!);
double[] array = new double[n];
System.Console.WriteLine("");
fillArray(array);
printArray(array);
System.Console.WriteLine();
double max =array[0];
double min =array[0];
for (int i = 0; i < n; i++)
{
  if (array[i] < min)
  {
    min = array[i];
  }
  else if (array[i] > max)
  {
    max = array[i];
  }
}
Console.WriteLine("Максимальный элемент"+ max);
Console.WriteLine("Минимальный эллемент" + min);
Console.WriteLine("Разница между максимальным и минимальным "+(max-min));
