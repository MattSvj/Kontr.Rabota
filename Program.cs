//Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.

string[] names = {"hello", "2", "world", ":-)"};

void CountEven(string[] words)
{   
    string[] a = new string[4]; 
    for(int i = 0; i < words.Length; i++)
    {
        if(words[i].Length <= 3) a[i] += words[i];
    }
    a = a.Where(x => x != null).ToArray();
    for(int j = 0; j < a.Length; j++)
                Console.Write(a[j] + " ");
}

CountEven(names);