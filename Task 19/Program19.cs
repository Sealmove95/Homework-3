// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int num = Convert.ToInt32(Console.ReadLine());
int num1 = (num / 10000);
int num2 = (num / 1000) % 10;
int num4 = (num / 10) % 10;
int num5 = num % 10;
if ((num1 == num5) && (num2 == num4))
  {
    Console.WriteLine("Является палиндромом");
  }
//if ((num1 != num5) | (num2 != num4))
else
  {
   Console.WriteLine("Не является палиндромом"); 
  }
