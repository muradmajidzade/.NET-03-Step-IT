// 1
//int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//foreach(int num in array)
//{
//    Console.Write($"{num} ");
//}

//Console.WriteLine();

//int sum = 0;

//foreach(int num in array)
//{
//    sum += num;
//}

//Console.WriteLine($"Sum = {sum}");

//double count = array.Length;

//double result = sum / count;

//Console.WriteLine($"Avg = {result}");

//int minNum = array[0];
//int maxNum = array[0];

//foreach(int num in array)
//{
//    if (num > maxNum)
//    {
//        maxNum = num;
//    }
//    else if (num < minNum)
//    {
//        minNum = num;
//    }
//}

//Console.WriteLine($"Min num = {minNum}, Max num = {maxNum}");

//int countOdd = 0;
//int countEven = 0;


//foreach(int num in array)
//{
//    if (num % 2 == 0)
//    {
//        countOdd += 1;
//    }
//    else if(num % 2 != 0)
//    {
//        countEven += 1;
//    }
//}

//Console.WriteLine($"Odd = {countOdd}, Even = {countEven}");


// 1 (var 2)
//int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//foreach (int num in array)
//{
//    Console.Write($"{num} ");
//}

//Console.WriteLine();

//Console.WriteLine($"Sum = {array.Sum()}");

//Console.WriteLine($"Avg = {array.Average()}");

//Console.WriteLine($"Min num = {array.Min()}, Max num = {array.Max()}");

//int countOdd = 0;
//int countEven = 0;

//foreach (int num in array)
//{
//    if (num % 2 == 0)
//    {
//        countOdd += 1;
//    }
//    else if (num % 2 != 0)
//    {
//        countEven += 1;
//    }
//}

//Console.WriteLine($"Odd = {countOdd}, Even = {countEven}");

// 2
//int[] array = new int[15];
//Random random = new Random();

//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = random.Next(-67, 67);
//    Console.Write($"{array[i]} ");
//}
//Console.WriteLine();

//int positiveCount = 0;
//int negativeCount = 0;
//int zeroCount = 0;

//foreach(int num in array)
//{
//    if (num == 0)
//    {
//        zeroCount += 1;
//    }
//    else if (num > 0)
//    {
//        positiveCount += 1;
//    }
//    else if (num < 0)
//    {
//        negativeCount += 1;
//    }
//}

//Console.WriteLine($"Positive count = {positiveCount}, Negative count = {negativeCount}, Zero count = {zeroCount}");

//for (int i = 0; i < array.Length; i++)
//{
//    if (array[i] < 0)
//    {
//        array[i] = 0;
//    }
//}

//int maxNum = array[0];
//int index = 0;

//for (int i = 1; i < array.Length; i++)
//{
//    if (array[i] > maxNum)
//    {
//        maxNum = array[i];
//        index = i;
//    }
//}

//Console.WriteLine($"Max number index - {index}");

//for (int i = 0; i < array.Length; i++)
//{
//    Console.Write($"{array[i]} ");
//}


// 2 (var 2)
//using System.Linq;
//int[] array = new int[15];
//Random random = new Random();

//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = random.Next(-67, 67);
//    Console.Write($"{array[i]} ");
//}
//Console.WriteLine();

//int positiveCount = 0;
//int negativeCount = 0;
//int zeroCount = 0;

//foreach (int num in array)
//{
//    if (num == 0)
//    {
//        zeroCount += 1;
//    }
//    else if (num > 0)
//    {
//        positiveCount += 1;
//    }
//    else if (num < 0)
//    {
//        negativeCount += 1;
//    }
//}

//Console.WriteLine($"Positive count = {positiveCount}, Negative count = {negativeCount}, Zero count = {zeroCount}");

//for (int i = 0; i < array.Length; i++)
//{
//    if (array[i] < 0)
//    {
//        array[i] = 0;
//    }
//}

//Console.WriteLine($"Max number index - {Array.IndexOf(array, array.Max())}");

//for (int i = 0; i < array.Length; i++)
//{
//    Console.Write($"{array[i]} ");
//}


// 3
//int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//foreach (int num in array)
//{
//    Console.Write($"{num} ");
//}
//Console.WriteLine();
//int first1 = array[0];

//int size = array.Length - 1;

//for (int i = 0; i < size / 2; i++)
//{
//    int temp = array[i];
//    array[i] = array[size - i];
//    array[size - i] = temp;
//}
//int first2 = array[0];

//foreach (int num in array)
//{
//    Console.Write($"{num} ");
//}
//Console.WriteLine();

//if (first1 == first2)
//{
//    Console.WriteLine("First value did not change!");
//}
//else
//{
//    Console.WriteLine("First value changed!");
//}

// 3 (var 2)
int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

foreach (int num in array)
{
    Console.Write($"{num} ");
}
Console.WriteLine();
int first1 = array[0];

Array.Reverse(array);
int first2 = array[0];

foreach (int num in array)
{
    Console.Write($"{num} ");
}
Console.WriteLine();

if (first1 == first2)
{
    Console.WriteLine("First value did not change!");
}
else
{
    Console.WriteLine("First value changed!");
}