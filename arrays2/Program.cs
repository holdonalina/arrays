//Написати програму, що буде сортувати за зростанням елементи двовимірного масиву.
//Написати програму, що буде видаляти з масиву елемент за вказаним індексом.

int[,] numbers = new int[6, 3] {
    { 89, 7, 94 },
    { 9, -4, 0 },
    { 36, 28, 3 },
    { 64, 8, -21 },
    { 23, 8, 0 },
    { 9, 37, 92 },
};

int rows = numbers.GetLength(0);
int cols = numbers.GetLength(1);

for (int i = 0; i < rows; i++)
{
  int[] row = new int[cols];

  for (int j = 0; j < cols; j++)
  {
    row[j] = numbers[i, j];
  }

  Array.Sort(row);

  for (int j = 0; j < cols; j++)
  {
    numbers[i, j] = row[j];
  }
}

for (int i = 0; i < rows; i++)
{
  for (int j = 0; j < cols; j++)
  {
    Console.Write(numbers[i, j] + " ");
  }
  Console.WriteLine();
}

Console.WriteLine("Enter the row of an element you want to delete(1-6): ");
int rowToDelete = int.Parse(Console.ReadLine()) - 1;
Console.WriteLine("Enter the column of an element you want to delete(1-3): ");
int colToDelete = int.Parse(Console.ReadLine()) - 1;

if (rowToDelete >= 0 && rowToDelete < numbers.GetLength(0) &&
    colToDelete >= 0 && colToDelete < numbers.GetLength(1))
{
  numbers[rowToDelete, colToDelete] = int.MinValue;
}


for (int i = 0; i < numbers.GetLength(0); i++)
{
  for (int j = 0; j < numbers.GetLength(1); j++)
  {
    if (numbers[i, j] == int.MinValue)
      Console.Write(" ");
    else
      Console.Write(numbers[i, j] + " ");
  }
  Console.WriteLine();
}