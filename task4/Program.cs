int[] array = new int[123];
void fillArray(int[] arr)
{
  int r = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = r+1;
    r++;
    Console.Write("{0,4}", arr[i]);
  }
  Console.WriteLine();
}
int quantityRange(int[] array)
{
  int A = 10;
  int B = 99;
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if ((array[i] >= A) && (array[i] <= B))
    {
      count++;
    }
  }
  return count;

}
fillArray(array);
System.Console.WriteLine();
int quantity = quantityRange(array);
System.Console.WriteLine(quantity);
System.Console.WriteLine(array[10]);
System.Console.WriteLine(array[99]);

