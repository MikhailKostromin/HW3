// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

string cube()  
{     
    Console.WriteLine("Введите число ");             
    int N = Convert.ToInt32(Console.ReadLine());             
    int i=1;             
    string res = string.Empty;   //пустая строка             
    
       while (i <= N )             
    {                 
        res = res + i*i*i+", ";                 
        i++;                               
    }     
    return res; 
 }
 
try 
{    
    Console.WriteLine($"Таблица кубов чисел " +cube ()); 
} 
catch 
{     
    Console.WriteLine("Необходимо вводить целые числа");     
}


