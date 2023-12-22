using System;
using System.IO;
using System.Linq;
class work_5_1
{
    static void Main()
    {
        string[] use = File.ReadAllLines("numsTask1.txt"); // чтение данных из файла и запись в массим
        int[] chosenUse = use[0].Split(' ').Select(int.Parse).ToArray(); // разделяем строку проблеами, перобразуем в числа, кладём в массив 
        int min = chosenUse[0]; // минимальное
        int numbers = 1; //
        
        for (int i = 0; i < chosenUse.Length; i++)
        {
            if (chosenUse[i] < min) // если число из списка меньше минимального
            {
                min = i; // присваиваем
            }
        }

        for (int i = min + 1; i < chosenUse.Length; i++) // считаем всё, что посли минимального
        {
            numbers *= chosenUse[i]; // умножаем
        }
        Console.WriteLine($"Произведение элементов после минимального числа: {numbers}"); // вывод
    }
}