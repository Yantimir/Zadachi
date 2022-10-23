// Console.Clear();
// Console.WriteLine("введите первое число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num == num2 * num2)
// {
//   Console.WriteLine($"Первое число является квадратом второго");
// }
// else
// {
//   Console.WriteLine($"Первое число не является квадратом второго");
// }



// Console.Clear();
// Console.WriteLine("введите число: ");
// int numDay = Convert.ToInt32(Console.ReadLine());
// string d1 = "Понедельник";
// string d2 = "Вторник";
// string d3 = "Среда";
// string d4 = "Четверг";
// string d5 = "Пятница";
// string d6 = "Суббота";
// string d7 = "Воскресенье";

// if(numDay == 1)
// {
//   Console.WriteLine(d1);
// }
// if(numDay == 2)
// {
//   Console.WriteLine(d2);
// }
// if(numDay == 3)
// {
//   Console.WriteLine(d3);
// }
// if(numDay == 4)
// {
//   Console.WriteLine(d4);
// }
// if(numDay == 5)
// {
//   Console.WriteLine(d5);
// }
// if(numDay == 6)
// {
//   Console.WriteLine(d6);
// }
// if(numDay == 7)
// {
//   Console.WriteLine(d7);
// }

// Console.Clear();
// Console.WriteLine("введите трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Последнее число {number % 10}");


// Задача 2: Напишите программу, которая на вход принимает 
// два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Clear();
// Console.WriteLine("Введите первое число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num > num2)
// {
//   Console.WriteLine("Первое число больше второго");
// }
// else
// {
//   Console.WriteLine("Второе число больше первого");
// }





// Задача 4: Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.Clear();
// Console.WriteLine("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите третье число: ");
// int num3 = Convert.ToInt32(Console.ReadLine());

// int max = num1;

// if (num2 > num1) max = num2;
// if (num3 > max) max = num3;

// Console.WriteLine($"Максимальноеиз из трех чисел: {max}");









// Задача 6: Напишите программу, которая на вход принимает число 
// и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.Clear();
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if(num % 2 == 0){
//   Console.WriteLine("Введеное число четное");
// }else{
//   Console.WriteLine("Введеное число не четное");
// }









// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.Clear();
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int i = 1;

// while (i < num)
// {
//   if (i % 2 == 0)
//   {
//     Console.WriteLine(i);
//   }
//   i++;
// }








// Напишите программу. которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа
// 78 -> 8
// 12 -> 2
// 85 -> 8

// int num = new Random().Next(10, 100);
// int num1 = num / 10;
// int num2 = num % 10;
// Console.WriteLine(num);
// if (num1 > num2)
// {
//   Console.WriteLine(num1);
// }
// else
// {
//   Console.WriteLine(num2);
// }








// **Задача 11:**
// Напишите программу, которая выводит случайное трёхзначное 
// число и удаляет вторую цифру этого числа.

// 456 -> 46

// 782 -> 72

// 918 -> 98

// int randomNumber = new Random().Next(100, 1000);
// Console.WriteLine(randomNumber);
// int firstNumber = randomNumber / 100;
// // Console.WriteLine(firstNumber);
// int secondNumber = randomNumber % 10;
// // Console.WriteLine(secondNumber);
// int result = firstNumber * 10 + secondNumber;
// Console.WriteLine(result);







// **Задача 12:** 
// Напишите программу, которая будет принимать на 
// вход два числа и выводить, является ли второе число кратным первому. 
// Если второе число не кратно числу первому, то программа выводит 
// остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4  -> кратно

// Console.Clear();
// Console.WriteLine("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int result = 0;

// if (num1 % num2 == 0)
// {
//   Console.WriteLine("Второе число кратно первому");
// }
// else
// {
//   result = num1 % num2;
//   Console.WriteLine($"Остаток от деления: {result}");
// }





// **Задача 14:**
// Напишите программу, которая принимает на вход число и 
// проверяет, кратно ли оно одновременно 7 и 23.

// 14  ->  нет
// 46  ->  нет
// 161 ->  да

// Console.Clear();
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num % 7 == 0 &&  num % 23 == 0)
// {
//   Console.WriteLine("Число кратно 7 и 23");
// }
// else 
// {
//   Console.WriteLine("Число не кратно 7 и 23");
// }





// **Задача 16:**
// Напишите программу, которая принимает на вход два числа 
// и проверяет, является ли одно число квадратом другого.


// Console.Clear();
// Console.WriteLine("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if(num1 == num2 * num2 || num2 == num1 * num1)





// Дополнительное задание

// У нас есть график, где даны отрезок 1 -  (х1; x2) и отрезок 2 (х3, x4)
// 	​Необходимо составить код, который находит их пересечение.
// 	Пересечением двух отрезка 1 и 2 могут быть  - отрезок, 
//   точка или ничего
// 	С клавиатуры вводим х1, x2, х3, x4 и выводим ответ - 
//   границы пересечений отрезков, общую точку или «не пересекаются».









// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// Console.Clear();
// Console.WriteLine("Введите число от 1 до 7: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num == 6 || num == 7)
// {
//   Console.WriteLine("Этот день выходной");
// }
// else
// {
//   Console.WriteLine("Этот день не выходной");
// }








// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Clear();
// Console.WriteLine("Введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int result = num % 100 / 10;
// Console.WriteLine($"Вторая цифра этого числа {result}");








// Задача 13: Напишите программу, которая выводит третью цифру СЛЕВА 
// заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 3267912 -> 6

// Console.Clear();
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// string numToText = Convert.ToString(num);
// if (numToText.Length > 2){
//   Console.WriteLine($"Третья цифра {numToText[2]}");
// }
// else {
//   Console.WriteLine("Третьей цифры нет");
// }



// 17. Напишите программу, которая принимает на вход координаты точки (X и Y)
// причем X != 0 и Y != 0
// и выдает номер четверти плоскости, в которой находится эта точка

// Console.WriteLine("Введите значение координаты x: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение координаты y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && y > 0)
// {
//   Console.WriteLine("Точка лежит в первой четверти");
// }
// else if (x < 0 && y > 0)
// {
//   Console.WriteLine("Точка лежит во второй четверти");
// }
// else if (x < 0 && y < 0)
// {
//   Console.WriteLine("Точка лежит в третьей четверти");
// }
// else if (x > 0 && y < 0)
// {
//   Console.WriteLine("Точка лежит в четвертой четверти");
// }
// else
// {
//   Console.WriteLine("Точка лежит вна оси координат");
// }





// 18. Напишите программу, которая по заданному номеру четверти, показывает диапазон 
// возможных координат точек в этой четверти (X и Y)

// Console.WriteLine("Введите номер четверти: ");
// int quarter = Convert.ToInt32(Console.ReadLine());

// if (quarter == 1)
// {
//   Console.WriteLine("x > 0, y > 0");
// }
// else if (quarter == 2)
// {
//   Console.WriteLine("x < 0, y > 0");
// }
// else if (quarter == 3)
// {
//   Console.WriteLine("x < 0, y < 0");
// }
// else if (quarter == 4)
// {
//   Console.WriteLine("x > 0, y < 0");
// }
// else
// {
//   Console.WriteLine("Неверно введена четверть");
// }



// 21. Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 2D пространстве
// A(3, 6); B(2, 1) -> 5,09
// A(7, -5); B(1, -1) -> 7,21

// Console.WriteLine("Введите значение координаты х первой точки: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение координаты y первой точки: ");
// int у1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение координаты х второй точки: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение координаты y второй точки: ");
// int у2 = Convert.ToInt32(Console.ReadLine());

// int sum = ((x2 - x1) * (x2 - x1)) + ((у2 - у1) * (у2 - у1));
// double distance = Math.Round(Math.Sqrt(sum), 2);

// Console.WriteLine($"Расстояние между точками = {distance}");





// 22. Напишите программу, которая принимает на вход число (N)
// и выдает таблицу квадратов чисел от 1 до N
// 5 -> 1, 4, 9, 16, 25
// 2 -> 1, 4

// Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int i = 1;

// while (i <= n)
// {
//   Console.Write(i * i + ",");
//   i++;
// }

// for (int i = 1; i <= n; i++)
// {
//     Console.Write(i * i + ",");
// }





// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// Console.Write("Введите пятизначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int number1 = number / 10000;
// int number2 = (number / 1000) % 10;
// int number4 = (number / 10) % 10;
// int number5 = number % 10;

// if (number1 == number5 && number2 == number4)
// {
//   Console.WriteLine($"Введеное число является палиндромом");
// }
// else
// {
//   Console.WriteLine($"Введеное число не является палиндромом");
// }














// Задача 21

// Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите значение координаты х первой точки: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение координаты y первой точки: ");
// int у1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение координаты z первой точки: ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение координаты х второй точки: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение координаты y второй точки: ");
// int у2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение координаты z второй точки: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// int sum = ((x2 - x1) * (x2 - x1)) + ((у2 - у1) * (у2 - у1)) + ((z2 - z1) * (z2 - z1));
// double distance = Math.Round(Math.Sqrt(sum), 2);

// Console.WriteLine($"Расстояние между точками = {distance}");










// Задача 23

// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= n; i++)
// {
//     Console.Write(i * i * i + ", ");
// }







// Задача 24. напишите программу, которая принимает на вход число А и выдает сумму
// чисел от 1 до А

// int sumNumber(int a)
// {
//   int result = 0;
//   for(int i = 1; i <= a; i++)
//   {
//     result += i;
//   }
//   return result;
// }

// Console.WriteLine(sumNumber(8));






// Задача 26. Написать программу, которая принимает на вход число
// и выдает колличесвтво цифр в числе

// int countNumber(int a)
// {
//   int count = 0;
//   while(a > 0)
//   {
//     a = a / 10;
//     count = count + 1;
//   }
//   return count;
// }

// Console.WriteLine(countNumber(89126));






// Задача 28. Написать программу, которая принимает на вход число N
// и выдает произведение чисел от 1 до N

// int getNumber(int n)
// {
//   int result = 1;
//   for(int i = 1; i <= n; i++)
//   {
//     result = result * i;
//   }
//   return result;
// }

// Console.WriteLine(getNumber(5));







// Задача 30. Написать программу, которая выводит массив
//  из 8 элементов, заполненный нулями и еденицами в случайном порядке.
//  [1, 0, 1, 1, 0, 1, 0, 0]

// Console.WriteLine("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] fillArray()
// {
//   int[] array = new int[size];
//   for (int i = 0; i < size; i++)
//   {
//     array[i] = new Random().Next(0, 2);
//   }
//   return array;
// }

// void printArray(int[] array)
// {
//   for (int i = 0; i < size; i++)
//   {
//     if (i < size - 1)
//     {
//       Console.WriteLine($"{array[i]}, ");
//     }
//     else
//     {
//       Console.WriteLine($"{array[i]}");
//     }
//   }
// }
// int [] massiv = fillArray();
// printArray(massiv);








// Задача 25: Напишите цикл, который 
// принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


// void powResult(int a, int b)
// {
//   int result = 1;
//   for (int i = 0; i < b; i++)
//   {
//     result *= a;
//   }
//   Console.WriteLine($"Результат возведения в степень: {result}");
// }

// powResult(3, 5);
// powResult(2, 4);







// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


// void sumNumber(int number)
// {
//   int sum = 0;
//   while (number > 0)
//   {
//     sum = sum + number % 10;
//     number = number / 10;
//   }
//   Console.WriteLine($"Сумма чисел в числе: {sum}");
// }

// sumNumber(452);
// sumNumber(82);
// sumNumber(9012);







// Задача 29: Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

// void getArray(int sizeArray)
// {
//   int[] array = new int[sizeArray];
//   // Random myRandom = new Random();

//   for (int i = 0; i < array.Length; i++)
//   {
//     array[i] = new Random().Next(0, sizeArray);
//     Console.Write($"{array[i]}, ");
//   }
// }
// getArray(8);





// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами 
// из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных 
// чисел равна 29, сумма отрицательных равна -20.
// заполнение случайными числами
// void getArray(int sizeArray)
// {

//   int[] array = new int[sizeArray];
//   int sumMinusNumber = 0;
//   int sumPlusNumber = 0;

//   for (int i = 0; i < array.Length; i++)
//   {
//     array[i] = new Random().Next(-9, 10);
//     Console.Write($"{ array[i]} ");

//     if(array[i] < 0)
//     {
//       sumMinusNumber += array[i];
//     }
//     else
//     {
//       sumPlusNumber += array[i];
//     }
//   }    
//   Console.WriteLine();
//   Console.WriteLine($"Сумма отрицательных чисел: {sumMinusNumber}");
//   Console.WriteLine($"Сумма положительных чисел: {sumPlusNumber}");
// }
// getArray(12);

// Задача 32: Напишите программу замена элементов массива: положительные элементы 
// замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 
// void getArray(int sizeArray)
// {
//   int[] array = new int[sizeArray];
//   int minusNumber = 0;
//   int plusNumber = 0;

//   for (int i = 0; i < array.Length; i++)
//   {
//     array[i] = new Random().Next(-99, 100);
//     Console.Write($"{array[i]} ");

//     if(array[i] < 0)
//     {
//       minusNumber = array[i] * -1;
//       Console.WriteLine($"{minusNumber} ");

//     }
//     else
//     {
//       plusNumber = array[i] * -1;
//       Console.WriteLine($"{plusNumber} ");
//     }
//   }    
// }
// getArray(4);



// Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, -3] -> да
// Console.WriteLine("Введите размер массива: ");
// int sizeArray = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число для поиска: ");
// int searchNumber = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[sizeArray];
// for (int i = 0; i < array.Length; i++)
// {
//   array[i] = new Random().Next(-9, 10);
//   Console.Write(array[i] + " ");
//   if(array[i] == searchNumber)
//   {
//     Console.WriteLine("Заданное число есть в массиве");
//   }
//   else
//   {
//     Console.WriteLine("Заданного числа нет в массиве");
//   }
// }


// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// Console.WriteLine("Введите размер массива: ");
// int sizeArray = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// int[] array = new int[sizeArray];
// for (int i = 0; i < array.Length; i++)
// {
//   array[i] = new Random().Next(0, 101);
//   Console.Write(array[i] + " ");
//   if (array[i] >= 10 && array[i] <= 99)
//   {
//     count++;
//   }
// }
// Console.WriteLine();
// Console.WriteLine($"количество элементов массива, значения которых лежат в отрезке [10,99]: {count}");


// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// Console.WriteLine("Введите размер массива: ");
// int sizeArray = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[sizeArray];

// for (int i = 0; i < array.Length; i++)
// {
//   array[i] = new Random().Next(0, 11);
//   if (i != array.Length - 1)
//   {
//     Console.Write($"{array[i]}, ");
//   }
//   else
//   {
//     Console.WriteLine($"{array[i]}");
//   }
// }
// int[] newArray = new int[sizeArray / 2 + sizeArray % 2];
// Console.WriteLine("Новый массив: ");
// for(int i = 0; i < newArray.Length; i++)
// {
//   newArray[i] = array[i] * array[array.Length - 1 - i];
//   if(i != newArray.Length - 1) Console.Write($"{newArray[i]}, ");
//   else Console.WriteLine($"{newArray[i]}");
// }





// Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
// числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// Console.WriteLine("Введите размер массива: ");
// int sizeArray = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[sizeArray];
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//   array[i] = new Random().Next(100, 1000);
//   Console.Write(array[i] + " ");
//   if (array[i] % 2 == 0) count += 1;
// }
// Console.WriteLine();
// Console.WriteLine($"количество чётных чисел в массиве: {count}");












// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// Console.WriteLine("Введите размер массива: ");
// int sizeArray = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[sizeArray];
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//   array[i] = new Random().Next(100, 1000);
//   Console.Write(array[i] + " ");
//   if (i % 2 != 0) count += array[i];
// }
// Console.WriteLine();
// Console.WriteLine($"сумма элементов, стоящих на нечётных позициях: {count}");










// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// Console.WriteLine("Введите размер массива: ");
// int sizeArray = Convert.ToInt32(Console.ReadLine());
// double[] array = new double[sizeArray];
// double minNumber = 0;
// double maxNumber = 0;
// double result = 0;
// for (int i = 0; i < array.Length; i++)
// {
//   array[i] = Math.Round(new Random().Next(-100, 100) + new Random().NextDouble(), 2); 
//   Console.Write(array[i] + " ");
//   if(minNumber > array[i]) minNumber = array[i];
//   if(maxNumber < array[i]) maxNumber = array[i];
// }
// result = maxNumber - minNumber;
// Console.WriteLine();
// Console.WriteLine($"минимальное число в массиве: {minNumber}");
// Console.WriteLine($"максимальное число в массиве: {maxNumber}");
// Console.WriteLine($"разница между максимальным и минимальным элементами массива: {result}");





// Задача 39: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
// Console.WriteLine("Введите размер массива: ");
// int sizeArray = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[sizeArray];
// int temp = 0;
// Console.WriteLine("Исходный массив: ");
// for (int j = 0; j < array.Length; j++)
// {
//     array[j] = new Random().Next(0, 10);
//     Console.Write($"{array[j]} ");
// }

// Console.WriteLine("Развернутый массив: ");
// for (int i = 0; i < array.Length / 2; i++)
// {
//     temp = array[i];
//     array[i] = array[array.Length - 1 - i];
//     array[array.Length - 1 - i] = temp;
// }

// for (int j = 0; j < array.Length; j++)
// {
//     Console.Write($"{array[j]} ");
// }
// Console.WriteLine();





// Задача 40: Напишите программу, которая принимает на вход три числа и 
// проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше 
// суммы двух других сторон
// void Main()
// {
//   int a = GetNumber();
//   int b = GetNumber();
//   int c = GetNumber();
//   CheckForTriangle(a, b, c);
// }
// int GetNumber()
// {
//   Console.WriteLine("Введите число");
//   int num = int.Parse(Console.ReadLine()!);
//   return num;
// }

// void CheckForTriangle(int a, int b, int c)

// {
//   if (a < (b + c) && b < (c + a) && c < (a + b))
//   {
//     Console.WriteLine("Может существовать треугольник с сторонами такой длины");
//   }
//   else
//   {
//     Console.WriteLine("Не может существовать треугольник с сторонами такой длины");
//   }
// }

// Main();



// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10
// void Main()
// {
//   int a = GetNumber();
//   ChangeToBinary(a);

// }

// int GetNumber()
// {
//   Console.WriteLine("Введите число");
//   int num = int.Parse(Console.ReadLine()!);
//   return num;
// }

// void ChangeToBinary(int number)
// {

//   int SIZE = 0;
//   int tempNumber = number;
//   for (int j = 0; tempNumber > 0; j++)
//   {
//     tempNumber = tempNumber / 2;
//     SIZE = j;

//   }

//   int[] arr = new int[SIZE + 1];
//   //Console.Write($" SIZE+1 = {SIZE + 1} ");

//   for (int i = 0; number > 0; i++)
//   {
//     arr[SIZE - i] = number % 2;

//     number = number / 2;

//   }

//   Console.WriteLine("\nНаше число = ");
//   for (int i = 0; i < arr.Length; i++)
//   {
//     Console.Write($" {arr[i]} ");
//   }
// }
// Main();

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
// System.Console.WriteLine("Введите число: ");
// int fib = Convert.ToInt32(Console.ReadLine());

// int[] fibo = new int[fib];
// fibo[0] = 0;
// fibo[1] = 1;
// for (int i = 2; i < fibo.Length; i++)
// {
//   fibo[i] = fibo[i - 1] + fibo[i - 2];
// }

// for (int j = 0; j < fibo.Length; j++)
// {
//   System.Console.Write($"{fibo[j]} ");
// }



// Задача 45: Напишите программу, которая будет создавать копию заданного массива 
// с помощью поэлементного копирования.


// Console.WriteLine("Введите размер массива: ");
// int sizeArray = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[sizeArray];
// int[] newArray = new int[sizeArray];

// for (int i = 0; i < sizeArray; i++)
// {
//   array[i] = new Random().Next(10, 100);
//   Console.Write(array[i] + " ");


// }
// Console.WriteLine();
// for(int j = 0; j < array.Length; j++)
// {
//   newArray[j] = array[j];
//   Console.Write(newArray[j] + " ");
// }







// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3
// Console.Clear();
// Console.Write("Введите элементы(через пробел): ");
// int[] arr = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
// int count = 0;

// for (int i = 0; i < arr.Length; i++)
// {
//   if (arr[i] > 0)
//   {
//     count++;
//   }
// }

// Console.WriteLine($"Количество элементов больше нуля: {count}");









// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// Console.Clear();
// Console.Write("Введите k1: ");
// var k1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите b1: ");
// var b1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите k2: ");
// var k2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите b2: ");
// var b2 = Convert.ToDouble(Console.ReadLine());

// var x = -(b1 - b2) / (k1 - k2);
// var y = k1 * x + b1;  
// x = Math.Round(x, 3);
// y = Math.Round(y, 3);

// Console.WriteLine($"Пересечение в точке: ({x};{y})");








// Задача 46: Задайте двумерный массив размером m×n, 
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1
// int[,] matrix = new int[3, 4];
// void getArray(int[,] matrix)
// {
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//       matrix[i, j] = new Random().Next(-100, 100);
//       Console.Write($"{matrix[i, j]}\t");
//     } 
//     Console.WriteLine();
//   }
// }
// getArray(matrix);





// Задача 48: Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// int[,] matrix = new int[3, 4];
// void getArray(int[,] matrix)
// {
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//       matrix[i, j] = i + j;
//       Console.Write($"{matrix[i, j]}\t");
//     } 
//     Console.WriteLine();
//   }
// }
// getArray(matrix);



// Задача 49: Задайте двумерный массив. Найдите элементы, у которых 
// оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть 
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4
// int[,] matrix = new int[3, 4];
// void getArray(int[,] matrix)
// {
//   int[,] newArray = new int[3, 4];
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//       matrix[i, j] = new Random().Next(0, 10);
//       // Console.Write($"{matrix[i, j]}\t");
//       if (i > 0 && i % 2 == 0 && j > 0 && j % 2 == 0)
//       {
//         newArray[i, j] = matrix[i, j] * matrix[i, j];
//         Console.Write($"{newArray[i, j]}\t");
//       }
//       else
//       {
//         newArray[i, j] = matrix[i, j];
//         Console.Write($"{newArray[i, j]}\t");
//       }
//     }
//     Console.WriteLine();
//   }
// }
// getArray(matrix);


//  + Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
// int[,] matrix = new int[3, 4];
// void getArray(int[,] matrix)
// {
//   int[,] newArray = new int[3, 4];
//   int sum = 0;
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//       matrix[i, j] = new Random().Next(0, 10);
//       Console.Write($"{matrix[i, j]}\t");
//       if (i == j)
//       {
//         sum = sum + matrix[i, j];
//       }
//     }
//     Console.WriteLine();
//   }
//   Console.WriteLine($"Сумма равна: {sum}");
// }
// getArray(matrix); 






// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
// Console.WriteLine("Введите количество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// double[,] matrix = new double[m, n];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//   for (int j = 0; j < matrix.GetLength(1); j++)
//   {
//     matrix[i, j] = Math.Round(new Random().Next(-10, 10) + new Random().NextDouble(), 1);
//     Console.Write($"{matrix[i, j]}\t");
//   }
//   Console.WriteLine();
// }






// Задача 50. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента или 
// же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
// Console.WriteLine("Введите количество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// double[,] matrix = new double[m, n];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//   for (int j = 0; j < matrix.GetLength(1); j++)
//   {
//     matrix[i, j] = Math.Round(new Random().Next(0, 100) + new Random().NextDouble(), 2);
//     Console.Write($"{matrix[i, j]}\t");

//   }
//   Console.WriteLine();
// }
// Console.WriteLine("Введите позицию элемента");
// Console.WriteLine("Строка: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Столбец: ");
// int y = Convert.ToInt32(Console.ReadLine());
// if (x > m && y > n)
//   Console.WriteLine("такого числа нет");
// else
// {
//   Console.WriteLine($"Значение числа: {matrix.GetValue(x, y)}");
// }






// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
for (int i = 0; i < matrix.GetLength(0); i++)
{
  double sum = 0;
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    matrix[i, j] = new Random().Next(1, 10);
    Console.Write($"{matrix[i, j]}\t");
    sum += matrix[i, j];
  }
  Console.WriteLine();
  Console.WriteLine($"Cреднее арифметическое элементов строки {i + 1} = {sum / n}");
}

