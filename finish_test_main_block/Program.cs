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

// Метод формирования новой матрицы
string[] GetNewArray(string[] array)
{
    int mod_array_length = 0;
    // Определяем, сколько строк в полученном массиве имеют больше 3 символов
    for(int i = 0; i < array.Length; i++) 
    {
        int string_length = array[i].Length;
        if (string_length <= 3) {mod_array_length++;}  
    }
    // Создаём новый массив нужного размера
    string[] modified_array = new string[mod_array_length];
    // Заполняем его
    for(int i = 0; i < array.Length; i++) 
        {
            int string_length = array[i].Length;
            if (string_length <= 3) {modified_array[i] = array[i];}  
        }
    return modified_array;
}

string[] myArray = ArrayGenerate();
PrintArray(myArray, "Исходный");
string[] myModifiedArray = GetNewArray(myArray);
PrintArray(myModifiedArray, "Модифицированный");
