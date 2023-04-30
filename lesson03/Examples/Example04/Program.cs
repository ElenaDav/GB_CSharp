// Задача 2. Упорядочить массив

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PtintArray(int[] array)
{
	int count = array.Length;
	for (int i = 0; i < count; i++)
	{
	Console.Write($"{array[i]} ");
	}
	Console.WriteLine();
}

void selectionSort(int[] array)
{
	for (int i = 0; i < array.Length - 1; i++)
	{
	  int minPosition = i;
		  for (int j = i + 1; j < array.Length; j++)
		  {
			  if(array[j] < array[minPosition]) minPosition = j;
      }
  int temporary = array[i];
	array[i] = array[minPosition];
	array[minPosition] = temporary;
	}
}

PtintArray(arr);
selectionSort(arr);
PtintArray(arr);