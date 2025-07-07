//Написати програму, що знаходить другий найбільший елемент масиву.

int[] numbers = { -9, 0, -2, 101, 57, 89, 18 };

int max = numbers[0];

for (int i = 1; i < numbers.Length; i++)
{
  if (numbers[i] > max)
  {
    max = numbers[i];
  }
}

Console.WriteLine(max);

