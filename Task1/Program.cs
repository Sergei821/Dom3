Console.Write("Введите положительное пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
while (number < 10000 || number > 99999)
{
    Console.Write("Вас просили ввести положительное пятизначное число: ");
    number = Convert.ToInt32(Console.ReadLine());
}

int[] arr = new int[5];
int i = 0;
while (number > 10)
{
    arr[i] = number%10;
    number /= 10;
    i++;
}
arr[4] = number;
bool pal = true;
for (int j = 0; j < (arr.Length / 2); j++)
{
    if (arr[j] != arr[arr.Length - j - 1])
    {
        Console.WriteLine("Введенное число не палиндром!");
        pal = false;
        break;
    }
}
if (pal)
{
    Console.WriteLine("Введенное число палиндром!");
}