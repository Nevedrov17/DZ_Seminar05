Console.Clear();

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] arr;
arr = new int[size];
int sum = 0;

for( int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(0,100);
    Console.Write(arr[i] + " ");
}
Console.WriteLine();

for( int i = 0; i < arr.Length; i++)
{
    if(i % 2 > 0)
    {
        sum = sum + arr[i];
    }
}
Console.WriteLine(sum);