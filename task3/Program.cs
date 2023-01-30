void fillArray(int[] collection)
{
  int lenght = collection.Length;
  int index = 0;
  while (index < lenght)
  {
    collection[index] = new Random().Next(100, 999);
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

int positivNumbers(int[] number)
{
  int lenght = number.Length;
  int index = 0;
  int quantity = 0;
  while (index < lenght)
  {
    if(number[index]%2==0){
      quantity++;
    }
    index++;
  }
  return quantity;
}

int negativNumber(int[]num){
  int lenght = num.Length;
  int i =0;
  int quantity = 0;
  while(i<lenght){
    if(num[i]%2>0){
      quantity++;
    }
    i++;
  }
  return quantity;
}

int[] array = new int[20];

fillArray(array);
printArray(array);
System.Console.WriteLine();

int positiv = positivNumbers(array);
System.Console.WriteLine(positiv);
System.Console.WriteLine();

int negativ = negativNumber(array);
System.Console.WriteLine(negativ);