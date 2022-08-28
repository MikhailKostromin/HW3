// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

String Polinrome ()
{
    Console.WriteLine("Введите пятизначное число ");
    int x= Convert.ToInt32(Console.ReadLine());
    string res = string.Empty;   //пустая строка
    if (x%10==x/10000%10 & x/10%10==x/1000%10)
    {
        Console.WriteLine("Палиндром ");
    }
    else 
    { 
        Console.WriteLine(" Не Палиндром ");
    }
    return res;
}

try 
{    
    Console.WriteLine(Polinrome ()); 
} 
catch 
{     
    Console.WriteLine("Необходимо ввести пять положительных целых числа");     
}
