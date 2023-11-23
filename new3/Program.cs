// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да 

// System.Console.Write("Введите количетво элементов в массиве: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] myArray = new int[size];
// Random rand = new Random();

// for (int i = 0; i < size; i++)
//     myArray[i] = rand.Next(-10, 11);

// for (int i = 0; i < size; i++)
//     System.Console.Write(myArray[i] + " ");


// Console.Write("\nВведите искомое число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// for (int i = 0; i < size; i++)
// {
//     if (myArray[i] == number)
//     {
//         System.Console.WriteLine("Да");
//         return;
//     }
// }

// System.Console.WriteLine("Нет");

// int j = 0;
// while(j < size)
// {
//     myArray[j] = rand.Next(10);
//     j++;
// }

// j = 0;
// while(j < size)
// {
//     System.Console.Write(myArray[j] + " ");
//     j++;
// }

System.Console.WriteLine("введите длинну массива");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];
Random rand = new Random();

for (int i = 0; i < size; i++)

    array[i] = rand.Next(-10, 11);

for (int i = 0; i < size; i++)

    System.Console.Write(array[i] + "\t");

for (int i = 0; i < size; i++)

    array[i] = -array[i];

System.Console.WriteLine();

for (int i = 0; i < size; i++)

    System.Console.Write(array[i] + "\t");



// Ввод размера массива
Console.WriteLine("Введите длину масива");
int size = Convert.ToInt32(Console.ReadLine());

// Выделение памяти под массив
int[] array = new int[size];
Random r = new Random();

//  Заполнение массива
for (int i = 0; i < size; i++)
    array[i] = r.Next(-10, 11); // [10; 11)

// Вывод массива
for (int i = 0; i < size; i++)
    Console.Write(array[i] + "\t");

Console.WriteLine();

for (int i = 0; i < size; i++)
    array[i] = -array[i];

for (int i = 0; i < size; i++)
    Console.Write(array[i] + "\t");