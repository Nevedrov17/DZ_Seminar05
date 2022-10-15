Console.Clear();

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] arr;
arr = new int[size];

for( int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(0,100);
    Console.Write(arr[i] + " ");
}
Console.WriteLine();

int max = arr[0];
int min= arr[1];
for( int i = 0; i < arr.Length; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
    else if ( arr[i] < min)
    {
         min = arr[i];
    }
}

Console.WriteLine(max - min);