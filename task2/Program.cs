void fillArray(int[] collection)
{
  int lenght = collection.Length;
  int index = 0;
  while (index < lenght)
  {
    collection[index] = new Random().Next(1, 10);
    index++;
  }
}

void printArray(int[] col)
{
  int count = col.Length;
  int position = 0;
  while (position < count)
  {
    Console.WriteLine(col[position]);
    position++;
  }
}

int indexOf(int[] collection, int find)
{
  int count = collection.Length;
  int index = 0;
  int position = 0;
  while (index < count)
  {
    if (collection[index] == find)
    {
      position = index;
      break;
    }
    index++;
  }
  return position;
}
int[] arr = new int[20];

fillArray(arr);
printArray(arr);
Console.WriteLine();

int position = indexOf(arr, 4);
Console.WriteLine(position);