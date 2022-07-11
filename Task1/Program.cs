// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateRandomArr (int size) {
    int[] arr = new int[size];
    for (int i = 0; i < size; i++) {
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}

void ShowArr (int[] arr) {
    for (int i = 0; i < arr.Length; i++) {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

int CountEvenNumbersinArray(int[] arr) {
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Enter the size of the array:");
int sizeArr = Convert.ToInt32(Console.ReadLine());

int[] userArr = CreateRandomArr(sizeArr);

ShowArr(userArr);

Console.WriteLine("In an array of even numbers: " + CountEvenNumbersinArray(userArr));