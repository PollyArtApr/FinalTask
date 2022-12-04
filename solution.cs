using System;
					
public class Program
{
	public static void Main()
	{
		// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
		// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
		// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
		// лучше обойтись исключительно массивами.
		// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
		// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
		// [“Russia”, “Denmark”, “Kazan”] → []
		
		string[] arr = {"123", "mama", "cold", "445"};
		
		
		int n = 3;
		
		string[] GetShortWordsArray(string[] array)
		{
			int length = array.Length;			
			string[] result = new string[length];
			int count = 0;
			
			for (int i = 0; i < length; i++)
			{
				if(array[i].Length <= n)
				{
					result[count] = array[i];
					count++;
				}
			}
			Array.Resize(ref result, count);
			
			return result;
		}
		
		void PrintArray(string[] array)
		{
			if(array.Length == 0)
			{
				Console.WriteLine("Array is empty");
			}
			else
			{
				Array.ForEach(array, (str) => Console.Write($"{str} "));
				Console.WriteLine();
			}
		}
		
		void PrintTask(string[] array)
		{
			Console.WriteLine("Source array:");
			PrintArray(array);
			string[] shortArray = GetShortWordsArray(array);
			Console.WriteLine($"Result array (words are less or equal than {n} symbols)");
			PrintArray(shortArray);
			Console.WriteLine();
		}
		
		PrintTask(arr);
			}
}