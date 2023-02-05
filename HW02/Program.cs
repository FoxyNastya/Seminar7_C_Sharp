/*
Задача 50. Напишите программу, которая на вход принимает позиции 
элемента в двумерном массиве, и возвращает значение этого элемента 
или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
пользователь вводит индексы 10, 10 - такого элемента нет.
пользователь вводите индексы 0, 2 - выводим элеменет 7
*/


int[,] array = new int[3, 4]; // создаем массив согласно условию задачи: 3 строки, 4 столбца
Random random = new Random(); // рандомное заполнение массива
Console.WriteLine("Исходный массив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = random.Next(10, 99);
    Console.Write("{0} ", array[i, j]);
    }
    Console.WriteLine();
    }

Console.WriteLine("Введите позицию в строке массива");
int row = Convert.ToInt32(Console.ReadLine()) - 1;
Console.WriteLine("Введите позицию в столбце массива");
int column = Convert.ToInt32(Console.ReadLine()) - 1;
    if (row < 0 | row > array.GetLength(0) - 1 | column < 0 | column > array.GetLength(1) - 1)
    {
    Console.WriteLine("Элемент не существует  ");
    }
        else
    {
        Console.WriteLine("Значение элемента массива = {0}", array[row, column]);
    }
    
