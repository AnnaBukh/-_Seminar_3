
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Write("Введите число :");
int number = Convert.ToInt32(Console.ReadLine());

int digit = number; 
int result1 = 0;
int result2 = number;

while ( number > 0 )// цикл для формирования числа наоборот 
     {
        digit = number % 10;
        result1 = result1 * 10 + digit; 
        number = number / 10; 
     }
//Console.WriteLine($" итоговое число {result1}");
//сравниванием, если число исходное и новое равны, то число является полиндромом
//Console.WriteLine($" исходное число {result2}");
if
   (result2 == result1) 
    Console.WriteLine("Число является полиндромом");
else 
    Console.WriteLine("Число не является полиндромом");
