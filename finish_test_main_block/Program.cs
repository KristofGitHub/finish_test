// Метод генерации массива строк задаваемого пользователем размера
string[] ArrayGenerate()
{
    // Запрос у пользователя размера создаваемого массива
    Console.WriteLine("Уважаемый пользователь! Введите размер создаваемого массива (кол-во строк): ");
    int array_size = Convert.ToInt32(Console.ReadLine());
    // Создание одномерного массива строк нужного размера
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
void PrintArray(string[] array)
{
    Console.WriteLine("Итоговый массив: ");
    for(int i = 0; i < array.Length; i++) {Console.WriteLine($"{array[i]}");}
}

string[] myArray = ArrayGenerate();
PrintArray(myArray);