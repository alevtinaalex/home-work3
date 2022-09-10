//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число и нажмите Enter");
string N = Console.ReadLine();

string Palindrom(string num)
{
   int length = num.Length;
    if(length == 5)
    {
        if(num[0] == num[4] && num[1] == num[3])
            return "Это палиндром";
        else return "Это не палиндром";
    }
return"Надо ввести именно пятизначное число";
} 

System.Console.WriteLine(Palindrom(N));
