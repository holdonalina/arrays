//Написати програму, що знаходить другий найбільший елемент масиву.

int[] numbers = { -9, 0, -2, 101, 57, 89, 18 };

int max = int.MinValue;
int secondMax = int.MinValue;

for (int i = 0; i < numbers.Length; i++)
{
  if (numbers[i] > max)
  {
    secondMax = max;
    max = numbers[i];
  }
  else if (numbers[i] > secondMax && numbers[i] != max)
  {
    secondMax = numbers[i];
  }
}

Console.WriteLine(secondMax);

