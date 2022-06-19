//Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.

/*
string[] names = {"hello", "2", "world", ":-)"}; //задал массив строк

void CountEven(string[] words) //создаю метод, который ничего не возвращает
{   
    string[] a = new string[4];  //
    for(int i = 0; i < words.Length; i++)
    {
        if(words[i].Length <= 3) a[i] += words[i];
    }
    a = a.Where(x => x != null).ToArray(); //пересоздаю массив без пустых строк
    for(int j = 0; j < a.Length; j++)
                Console.Write(a[j] + " ");
}

CountEven(names);
*/

string[] names = {"hello", "2", "world", ":-)"}; //задал массив строк

void CountEven(string[] words) //создаю метод, который ничего не возвращает
{     
    words = words.Where(x => x.Length <= 3).ToArray(); //пересоздаю массив, записываю в новый строки, длина которых <= 3
    for(int j = 0; j < words.Length; j++) //вывожу элементы массива
                Console.Write(words[j] + " ");
}

CountEven(names); //запуск метода

