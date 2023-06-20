// ИТОГОВАЯ КОНТРОЛЬНАЯ РАБОТА ПО ОСНОВНОМУ БЛОКУ
// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// 1. Создать репозиторий на GitHub
// 2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
// 3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)

// Метод генерации массива строк задаваемого пользователем размера
string[] ArrayGenerate()
{
    Console.WriteLine();
    Console.WriteLine("Уважаемый пользователь! Введите размер создаваемого массива (кол-во строк): ");
    int array_size = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[array_size];
    // Запрос у пользователя ввода элементов массива (построчно) с помощью цикла
    for(int i = 0; i < array_size; i++) 
    {
        Console.WriteLine($"Введите строку номер {i+1}: ");
        array[i] = Console.ReadLine();
    }
    return array;
} // Конец метода

// Метод печати массива строк в консоль
void PrintArray(string[] array, string comment)
{
    Console.WriteLine();
    Console.WriteLine(comment + " массив: ");
    for(int i = 0; i < array.Length; i++) {Console.WriteLine($"{array[i]}");}
} // Конец метода

// Метод формирования модифицированного массива
string[] GetNewArray(string[] array)
{
    int mod_array_length = 0;
    // Определяем, сколько строк в полученном массиве имеют больше 3 символов
    for(int i = 0; i < array.Length; i++) {if (array[i].Length <= 3) {mod_array_length++;}}
    // Создаём новый массив нужного размера
    string[] modified_array = new string[mod_array_length];
    // Заполняем его
    int count = 0;
    for(int i = 0; i < array.Length; i++) 
        {
            if (array[i].Length <= 3) 
            {
                modified_array[count] = array[i]; 
                count++;
            }  
        }
    return modified_array;
}

string[] myArray = ArrayGenerate();
PrintArray(myArray, "Исходный");
string[] myModifiedArray = GetNewArray(myArray);
PrintArray(myModifiedArray, "Модифицированный");
