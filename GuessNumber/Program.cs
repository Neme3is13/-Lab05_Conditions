// using System.Reflection.Metadata;

// System.Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine());
// if (number > 0)
// {
//     System.Console.WriteLine("Число положительное");
// }
// else if (number < 0)
// {
//     System.Console.WriteLine("число отрицательное");
// }
// else
// {
//     System.Console.WriteLine("число равно нулю");
// }

// Console.Write("Введите балл (0-100) ");
// int score = int.Parse(Console.ReadLine());
// if (score >= 91) {
//     System.Console.WriteLine("5");
// }
// else if (score >= 71) {
//     System.Console.WriteLine("4");
// }
// else if (score >= 51) {
//     System.Console.WriteLine("3");
// }
// else {
//     System.Console.WriteLine("2");
// }

// Console.Write("Введите кол-во посещений(из 19) ");
// int attendance =  int.Parse(Console.ReadLine());
// Console.Write("Введите ср балл по практике ");
// double practiceGpa = double.Parse(Console.ReadLine());
// bool goodAttendanse = attendance >= 14;
// bool goodGrades = practiceGpa >= 3.0;
// if (goodAttendanse && goodGrades) {
//     System.Console.WriteLine("+ допуск к экз разрешен");
// }
// else if (!goodAttendanse && goodGrades) {
//     System.Console.WriteLine("недостаточно посещений");
// }
// else if (goodAttendanse && !goodGrades) {
//     System.Console.WriteLine("низкий балл по пракитке");
// }
// else {
//     System.Console.WriteLine("проблемы с помещаемостью и оценками");
// }

using System.Globalization;

Console.Write("Введите ваш возраст ");
int age = int.Parse(Console.ReadLine());
string ageGroup = age >= 18 ? "совершенноелетний" : "несовершеннолетний";
System.Console.WriteLine($"вы {ageGroup}");
System.Console.WriteLine("\nВведите температуру за окном (С) ");
double temp = double.Parse(Console.ReadLine());
string weather = temp >= 20 ? "teplo" : (temp >= 0 ? "prohladno" : "moroz");
System.Console.WriteLine($"за окном {weather}");
Console.Write("\nВведите число");
int n = int.Parse(Console.ReadLine());
string parity = n % 2 == 0 ? "4et" : "ne4et";
System.Console.WriteLine($"число {n} - {parity}");