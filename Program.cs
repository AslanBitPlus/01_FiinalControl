﻿// Итоговая контрольная работа по основному блоку

// 1. Создать репозиторий на GitHub
// 2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
// 3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
// 4. Написать программу, решающую поставленную задачу
// 5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

// Заполнение текстового массива элементами с клавиатуры
string[] CreateTextArray(int rows)
{
    string[] arr = new string[rows];
    for (int i = 0; i < rows; i ++)
    {
        Console.Write($"Введите {i}-й элемент массива: ");
        arr[i] = Console.ReadLine();
    }
    return arr;
}
// Печать текстового массива
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i ++)
    {
        Console.Write($"{array[i]}  ");     
    }
    Console.Write("]");
}
// Подсчет элементов массива с длиной символов меньше или равно 3
int TextCountArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i ++)
    {
        if (array[i].Length <= 3) count ++;
    }
    return count;
}
// Записываем элементы массива с длиной символов меньше или равно 3 в новый массив
void ChangeTextArray(string[] array1, string[] array2)
{
    int n = 0;
    for (int i = 0; i < array1.Length; i ++)
    {
        if (array1[i].Length <= 3)
        {
            array2[n] = array1[i];
            n ++; 
        }
    }
}

// =======================
Console.Write("Введите размерность массива :");
int arrSize = Convert.ToInt32(Console.ReadLine());

string[] txtArr = CreateTextArray(arrSize);
PrintArray(txtArr);

int txtCount = TextCountArray(txtArr);

string[] changeTxtArr = new string[txtCount];
ChangeTextArray(txtArr, changeTxtArr);

Console.Write(" -> ");
PrintArray(changeTxtArr);
