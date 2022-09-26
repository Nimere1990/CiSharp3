/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

string PoliTest(int num)
{
    if (10000 <= num && num < 100000)
    {
        if (num / 10000 == num % 10 && (num / 1000) % 10 == (num / 10) % 10)

            return "Число полиндром";

        else 
        return"Число не полиндром";
    }
    else 
    return"Число не пятизначное";
}

void PrintData(string prefix, string value)
{
    Console.WriteLine(prefix + value);
}

int number = ReadData("Введите число: "); 
string PoliAnswer = PoliTest(number);
PrintData("", PoliAnswer);