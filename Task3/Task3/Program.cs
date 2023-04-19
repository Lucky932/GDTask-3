using System;
using static System.Math; // Используем библиотеку с мат. функциями

Console.WriteLine("Введите значения a,b,c.");

Console.Write("a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("c: ");
int c = Convert.ToInt32(Console.ReadLine());
// Ввод данных
void heron(int a,int b,int c) // Создал метод ничего не возвращающий и имеющий на вход 3 аргумента
{
    double S; // создаю локальную переменную площадь
    int p; // создаю локальную переменную полупериметра
    p = (a + b + c) / 2; // вычисляем полупериметр
    S = Sqrt(p*(p-a)*(p-b)*(p-c)); // формула Херона (вроде должно быть Герона)
    S = Math.Round(S, 2); // Округляем до 2-х знаков
    Console.WriteLine(Convert.ToString(S)); // выводим результат
} // очищаем память после выполнения метода (функции)

heron(a, b, c); // Вызываем метод засовывая в него аргументы