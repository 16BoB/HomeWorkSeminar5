// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] CreateRandomArr (int size, int min, int max) {
    double[] arr = new double[size];
    for (int i = 0; i < size; i++) {
        arr[i] = Math.Round((new Random().Next(min, max + 1)) + new Random().NextDouble(), 2);
    }
    return arr;
}

void ShowArr (double[] arr) {
    for (int i = 0; i < arr.Length; i++) {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

double FindDifferenceMaxMinNumInArray (double[] arr) {
    double minNum = arr[0];
    double maxNum = arr[0];
    for (int i = 1; i < arr.Length; i++) {
        if(arr[i] < minNum) {
            minNum = arr[i];
        }
        if(arr[i] > maxNum) {
            maxNum = arr[i];
        }
    }
    double result = Math.Round(maxNum - minNum, 2);
    return result;
}

Console.WriteLine("Enter the number of elements in the array: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the minimum number in the array: ");
int minNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the maximum number in the array: ");
int maxNum = Convert.ToInt32(Console.ReadLine());

double[] userArr = CreateRandomArr(size, minNum, maxNum);

ShowArr(userArr);

Console.WriteLine("The difference between the maximum and minimum number in the array is: " + FindDifferenceMaxMinNumInArray(userArr));