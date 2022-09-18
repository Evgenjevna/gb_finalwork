/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []*/

using static System.Console;
Clear();

string[] firstarray;
WriteLine("Введите массив из строк через пробел");
string keyword = ReadLine(); //Запись введённых с клавиатуры данных в переменную
firstarray = keyword.Split(' '); //Преобразование в массив строк данные из переменной, разделитель - пробел
string[] secondarray = new string[firstarray.Length]; //Второй массив строк с количеством элементов равному первому массиву

TransformArray(firstarray, secondarray);
WriteLine();
PrintArray(secondarray); //Вывод в консоль второго массива строк, элементы которого имеют не более 3 символов
WriteLine();

void TransformArray(string[] firstarray, string[] secondarray) //Передаём в метод оба массива строк
{
    int carrent = 0; //Текущий индекс равен 0
    for (int i = 0; i < firstarray.Length; i++)
    {
        if (firstarray[i].Length <= 3)  //Найти значения элементов массива меньше или равному 3ём символам
        {
            secondarray[carrent] = firstarray[i];
            carrent++; //Увеличиваем текущий индекс на еденицу
        }
    }
}
void PrintArray(string[] array) //Метод вывода массива в консоль 
{
    for (int i = 0; i < array.Length; i++)
    {
        Write($"{array[i]} ");
    }
    WriteLine();
}