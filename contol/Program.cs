// Написать программу, которая из имеющегося массива строк формирует ассив из строк, длина которыхменьше либо равно 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

using System;
class MainClass{
   static void Main()
   {
      object[] arr = new object[] { "hello", "2", "1567", "Kazan" };
      foreach(var item in arr)
      Console.WriteLine(item);
   }
}