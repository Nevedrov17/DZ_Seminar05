Console.Clear();

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] arr;
arr = new int[size];
int count = 0;

for( int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(100,1000);
    Console.Write(arr[i] + " ");
}
Console.WriteLine();

for( int i = 0; i < arr.Length; i++)
{
    if(arr[i] % 2 == 0)
    {
       count++;
    }
}
Console.WriteLine(count);