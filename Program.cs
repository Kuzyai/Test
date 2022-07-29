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
	{
		if (array[i].Length <= 3) count++;
	}
	return count;
}

Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = CreateArray(size);
Words(array);
int count = CountElements(array);
Console.WriteLine(count);