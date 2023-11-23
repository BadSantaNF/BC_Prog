// int Max(int arg1, int arg2, int arg3)
// {
//     int result=arg1;

//     if(arg2>result) result=arg2;
//     if(arg3>result) result=arg3;
//     return result;
// }



// int a1 = 128;
// int b1 = 341;
// int c1 = 3134;
// int a2 = 13;
// int b2 = 213;
// int c2 = 213;
// int a3 = 000000;
// int b3 = 346;
// int c3 = 0;

// // int max1 =Max(a1,b1,c1);
// // int max2 =Max(a2,b2,c2);
// // int max3 =Max(a3,b3,c3);

// // if(b1> max) max = b1;
// // if(c1> max) max = c1;

// // if(a2> max) max = a2;
// // if(b2> max) max = b2;
// // if(c2> max) max = c2;

// // if(a3> max) max = a3;
// // if(b3> max) max = b3;
// // if(c3> max) max = c3;
// int max= Max(
//     Max(a1,b1,c1), 
//     Max(a2,b2,c2),
//     Max(a3,b3,c3));

// Console.WriteLine(max);


// //            0 1 2 3 4 5 6 7 8    цифра переменной массива
// int[] array ={1,2,3,445,5,6,7,8,9};

// int max= Max(
//     Max(array[0],array[1],array[2]), 
//     Max(array[3],array[4],array[5]),
//     Max(array[6],array[7],array[8]));

//     Console.WriteLine(max);

// int[] array = {1,3,5,0,2,62,2626,23,234,246,234};

// int n = array.Length;
// int find = 18;

// int index = 0;

// while (index < n)
// {   
//     if (array[index] == find)
//     {
//         Console.WriteLine(index);
//         break;
//     }
//     // index= index+1;
//     index++;
// }
// PrinrArray(array)void FillArray(int[] collection)
// {
//     int length= collection.Length;
//     int index =0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next(1,10);
//         index++;
//     }
// }






// void PrinrArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position<col)
//     {
//         Console.WriteLine(col[position]);
//         position++;
//     }
// }


// int[] collection = new int [10];

// FillArray(array);





// public class Answer
// {
//     static void CompareNumbers(int firstNumber, int secondNumber)
//     {   

//         if (firstNumber > secondNumber)
//         {
//             int arg1 = firstNumber;
//             int arg2 = secondNumber;
//             System.Console.Write(" первое число  ");
//             System.Console.Write(arg1);
//             System.Console.Write(" больше второго ");
//             System.Console.Write(arg2);

//         }
//          if (secondNumber > firstNumber)
//         {
//             int arg2 = secondNumber;
//             int arg1 = firstNumber;
//             System.Console.Write("  второе число  ");
//             System.Console.Write(arg2);
//             System.Console.Write(" больше первого ");
//             System.Console.Write(arg1);

//         }
//         if (firstNumber==secondNumber)

//         {
//             int arg2 = secondNumber;
//             int arg1 = firstNumber;
//             System.Console.Write("Введенные числа ");
//             System.Console.Write(arg2);
//             System.Console.Write("  и  ");
//              System.Console.Write(arg1);
//             Console.WriteLine( " равны ");

//         }

//     }
//     // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args)
//     {
//         int firstNumber, secondNumber;

//         if (args.Length >= 2)
//         {
//             firstNumber = int.Parse(args[0]);
//             secondNumber = int.Parse(args[1]);
//         }
//         else
//         {
//             // Здесь вы можете поменять значения для отправки кода на Выполнение
//             firstNumber = 3;
//             secondNumber = 3;
//         }

//         // Не удаляйте строки ниже
//         CompareNumbers(firstNumber, secondNumber);
//     }
// }

// using System;

// public class Answer
// {

//     static int FindMax(int a, int b, int c)
//     {
//         int max = a;

//         if (b > max)
//         {
//             max = b;
//         }
//         if (c > max)
//         {
//             max = c;

//         }
//         return max;



//     }


//     // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args)
//     {
//         int a, b, c;

//         if (args.Length >= 3)
//         {
//             a = int.Parse(args[0]);
//             b = int.Parse(args[1]);
//             c = int.Parse(args[2]);
//         }
//         else
//         {
//             // Здесь вы можете поменять значения для отправки кода на Выполнение
//             a = 5;
//             b = 25;
//             c = 7;
//         }

//         // Не удаляйте строки ниже
//         int result = FindMax(a, b, c);
//         System.Console.WriteLine($"{result}");
//     }

// }

// using System;

class Answer {
    static void CheckIfEven(int number)
    { 
      // Проверка четности или нечетности числа
        if (number % 2 == 0)
        {
            Console.WriteLine("Число четное.");
            System.Console.WriteLine(number);
        }
        else
        {
            Console.WriteLine("Число нечетное.");
        }
        
      
      

    }
  

  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 3;
        }

        // Не удаляйте строки ниже
        CheckIfEven(number);
    }
}