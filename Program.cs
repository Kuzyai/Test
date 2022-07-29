string[] CreateArray(int size)
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

Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] inputArray = CreateArray(size);
Words(inputArray);
int newLen = CountElements(inputArray);
Console.WriteLine(newLen);
string[] outputArray = MainTask(inputArray, newLen);