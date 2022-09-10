// Задача номер 36.

/* Console.WriteLine ("Сумма");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray = new int[size];
int result = 0;
for (int i = 0; i < myArray.Length; i++)
{
if (myArray[i] % 2 == 0)
    {
        result += myArray[i];
    }
}
Console.WriteLine(result);
Console.ReadLine(); */


// Задача номер 34.

/* Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Вот наш массив: ");
PrintArray(numbers);
int count = 0;

for (int z = 0; z < numbers.Length; z++)
if (numbers[z] % 2 == 0)
count++;

Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}  */
