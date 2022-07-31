/* string[] CreateArray(int size)
{
	string[] array = new string[size];
	return array;
}

void Words(string[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		Console.Write($"Введите {i + 1} слово: ");
		array[i] = Console.ReadLine();
	}
}

int CountElements(string[] array)
{
	int count = 0;
	for (int i = 0; i < array.Length; i++)
		if (array[i].Length <= 3) count++;
	return count;
}

string[] MainTask(string[] array, int newLen)
{
	int len = array.Length;
	int index = 0;
	string[] outputArray = new string[newLen];
	for (int i = 0; i < len; i++)
		if (array[i].Length <= 3)
		{
			outputArray[index] = array[i];
			index = index + 1;
		}
	return outputArray;
}

string Print(string[] array)
{
	string words = string.Empty;
	for (int i = 0; i < array.Length; i++)
		words += $"{array[i]}, ";
	return words;
}

Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] inputArray = CreateArray(size);
Words(inputArray);
int newLen = CountElements(inputArray);
string[] outputArray = MainTask(inputArray, newLen);
Console.WriteLine(Print(inputArray));
Console.WriteLine(Print(outputArray)); */

using System;
using System.Text;

string[] CreateArray(int size)
{
	string[] array = new string[size];
	return array;
}

void GenerateArray(string[] array)
{
	Random rnd = new Random();
	for (int i = 0; i < array.Length; i++)
	{
		char[] ch = array[i].ToCharArray();
		StringBuilder sb = new StringBuilder();
		for (int j = 0; i < ch.Length; j++)
		{
			ch[j] = Convert.ToChar(rnd.Next('a', 'a' + 27));
		}
		sb.Append(ch);
		array[i] = sb.ToString();
		Console.Write($"{array[i]} ");
	}
}

Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] inputArray = CreateArray(size);
GenerateArray(inputArray);
foreach (var i in inputArray) Console.WriteLine(i);