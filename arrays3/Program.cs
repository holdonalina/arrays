//Написати програму, що буде знаходити суму елементів по діагоналі у двовимірному масиві.

int[,] numbers = new int[4, 4] {
    { 89, 7, 94, 8 },
    { 9, -4, 0, 27 },
    { 36, 28, 3, 9 },
    { 72, 89, 90, 1 },
};

// int sum = numbers[0, 0] + numbers[1, 1] + numbers[2, 2];
// Console.WriteLine(sum);
//переробити

int size = numbers.GetLength(0);
int sum = 0;

for (int i = 0; i < size; i++)
{
    sum += numbers[i, i];
}
Console.WriteLine(sum);