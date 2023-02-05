Console.WriteLine("Введите длинну массива:");
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
System.Console.WriteLine("");

fillArray(array);

printArray(array);

int[] numbersPairs(int[] arr)
{
  int[] productNumber = new int[arr.Length/2];
  for (int i = 0; i < arr.Length / 2 ; i++)
  {
    int sum = 0;
    sum = arr[i] * arr[arr.Length - 1 - i];
    productNumber[i]= sum;
  }
  return productNumber;
}

int[] productNum = numbersPairs(array);
System.Console.WriteLine("");
System.Console.WriteLine(string.Join(",",productNum));