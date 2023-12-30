
// Тема: Итоговая контрольная работа.
// --- Начало программы ----------------/\---/\------------------------------------------------
// --------------------------------------*---*-------------------------------------------------
// ---------------------------------------\*/--------------------------------------------------


// --- Блок методов ---------------------------------------------------------------------------
// --------------------------------------------------------------------------------------------

static void Pause(string str = "") // Приостановка работы программы до ввода символа с клавиатуры
{

    if (!str.Equals(""))
    {
        System.Console.Write("> " + str + "\n");
    }

    Console.Write("> Нажмите любую кнопку для продолжения... ");
    Console.ReadKey();
    Console.Write("\n");

}

static void ExitProgram() // Досрочное завершение работы программы
{    
 
    Console.Write("> Работа программы завершена досрочно!\n");
    System.Environment.Exit(1);

}
    
static int ReadInt(string text) // Прочитать целое число с консоли
{
    string? str;
    bool check = false;

    System.Console.Write(text);
    str = Console.ReadLine();

    //check = (Int32.TryParse(str, out int num) == false) ? false : true;
    check = Int32.TryParse(str, out int num) != false;

    while (check == false) {
        
        Console.Write("> Неудалось обнаружить число во введенной строке.\n");
        Console.Write("> Повторите ввод или введите символ 'q' для выхода из программы.\n");
        
        System.Console.Write(text);
        str = Console.ReadLine();

        check = Int32.TryParse(str, out num) != false;

        // str = str == null ? "" : str; // до первого упрощения
        // str = str ?? "";              // до второго упрощения

        str ??= "";

        if ((int)str[0] == 113 || (int)str[0] == 81) { ExitProgram(); }     

    }
    
    return num;

}

static string ReadStr(string text) // Прочитать строку с консоли
{
    
    string? str;
    
    System.Console.Write(text);
    str = Console.ReadLine();
 
    return str ?? "";

}

static void InputStrArray(string[] array) // Заполнить массив строками с клавиатуры
{
    
    int lng = array.Length;

    for (int i = 0; i < lng; i++)
    {        
        array[i] = ReadStr("> Введите " + i + " строку массива: ");        
    }
    
}

static void ShowArray(string[] arrayForPrint, string note = "Массив имеет следующий вид:") // Показать массив
{
    System.Console.Write("> " + note);

    int lng = arrayForPrint.Length;

    if (lng > 0)
    {
        for (int i = 0; i < lng; i++)
        {
            System.Console.Write("\n> " + i + ":\t" + arrayForPrint[i]);
        }
    } 
    else
    {
        System.Console.Write("\n> [Массив не содержит ни одного элемента!]");
    }
    System.Console.Write("\n");
}

static string[] ModificStringArray(string[] array, int num = 3) // Модифицировать строковый массив
{

    int lng = array.Length;
    int cnt = 0;
    
    for (int i = 0; i < lng; i++)
    {        
        if (array[i].Length <= num) { cnt++; }
    }

    string[] result = new string[cnt];
    cnt = 0;

    for (int i = 0; i < lng; i++)
    {        
        if (array[i].Length <= num) 
        { 
            result[cnt] = array[i];
            cnt++;         
        }
    }    

    return result;

}

// --- end ------------------------------------------------------------------------------------



// --- Основной блок --------------------------------------------------------------------------
// --------------------------------------------------------------------------------------------

// Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать 
// на старте выполнения алгоритма. При решении не рекомендуется пользоваться
// коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

int num = ReadInt("> Введите количество строк в массиве: ");

string[] strarray = new string[num];

Pause("Принято!");

InputStrArray(strarray);

System.Console.Write("> Принято!\n");

ShowArray(strarray, "Исходный массив имеет следующий вид:");

string[] strarrayNew = ModificStringArray(strarray);

Pause("Модификация завершена!");

ShowArray(strarrayNew, "Модифицированный массив имеет следующий вид:");

Pause();

// --- end ------------------------------------------------------------------------------------