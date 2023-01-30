int[] arr =new int[8];
Random rand = new Random();
for(int i =0;i<arr.Length;i++){

arr[i] = rand.Next(0,2);
}
Console.WriteLine(string.Join(" ", arr));