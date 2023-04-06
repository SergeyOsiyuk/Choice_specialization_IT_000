// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

// Алгоритм: запрашиваем количество строк массива → вводим посточно элементы массива с клавиатуры → выводим на печать введенный массив → 
// формируем массив с учётом условия задачи (меньше или равно 3 символа) → выводим на печать полученный массив → end;

Console.WriteLine("Введите количество строк массива: ");
int rows  = int.Parse(Console.ReadLine());

string[] arr1 = new string[rows];

for (int i = 0; i < rows; i++){
    Console.Write($"Введите элементы массива в строке {i+1} из {rows}: ");
    string result = Console.ReadLine();
    arr1[i] = result;  
}
Console.WriteLine();
Console.Write("Введенный массив: [");
Console.Write(string.Join(",", arr1));
Console.Write("]");

int count = 0;
int maxSymbols = 3;

for (int i = 0; i < arr1.Length; i++){
    if(arr1[i].Length <= maxSymbols){
        count++;
    }   
}
Console.WriteLine();
Console.Write("Полученный массив: [");
string[] arr2 = new string[count];
int j = 0;
for (int i = 0; i < arr1.Length; i++){
    if(arr1[i].Length <= maxSymbols){
        arr2[j] = arr1[i];
        Console.Write(arr2[j] + ",");
        j++;
    }
}
Console.Write("]");

