// Задача 36: Задайте массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateRandomArr (int size, int min, int max) {
    int[] arr = new int[size];
    for (int i = 0; i < size; i++) {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}

void ShowArr (int[] arr) {
    for (int i = 0; i < arr.Length; i++) {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

int CalculateSumElementsOddIndex (int[] arr) {
    int sum = 0;
    for (int i = 0; i < arr.Length; i++) {
        if (i % 2 != 0) {
            sum = sum + arr[i];
        }
    }
    return sum;
}

Console.WriteLine("Enter the size of the array:");
int sizeArr = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the minimum number in the array:");
int minNumInArr = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the maximum number in the array:");
int maxNumInArr = Convert.ToInt32(Console.ReadLine());

int[] userArr = CreateRandomArr(sizeArr, minNumInArr, maxNumInArr);

ShowArr(userArr);

Console.WriteLine("The sum of the numbers in odd positions is: " + CalculateSumElementsOddIndex(userArr));