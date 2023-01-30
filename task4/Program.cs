int[] array = new int[123];
void fillArray(int[] arr)
{
  Random r = new Random();
  for (int i = 0; i < 123; i++)
  {
    arr[i] = r.Next(1, 999);
    Console.Write("{0}", arr[i]);
  }
  Console.WriteLine();
}
int quantityRange(int[] array)
{
  int botton = 10;
  int top = 99;
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if ((array[i] >= botton) && (array[i] <= top))
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

