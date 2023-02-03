Console.WriteLine("Введите длину массива:");
int n = int.Parse(Console.ReadLine()!);

int[] array = new int[n];
void fillArray(int[] collection)
{
  for (int i = 0; i < collection.Length; i++)
  {
    collection[i] = new Random().Next(0, 10);
  }
}
void printArray(int[] col)
{
  for (int i = 0; i < col.Length; i++)
  {
    Console.WriteLine(col[i]);
  }
}
int sumFunction(int[] arr)
{
  int sum = 0;
  for(int i = 0;i < arr.Length;i++){
    if(i%2!=0){
      sum=sum+arr[i];
    }
  }
  return sum;
}
System.Console.WriteLine("");
fillArray(array);
printArray(array);
System.Console.WriteLine("");
int sum = sumFunction(array);
System.Console.WriteLine(sum);