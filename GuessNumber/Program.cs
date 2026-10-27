using System.Reflection.Metadata;

System.Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
if (number > 0)
{
    System.Console.WriteLine("Число положительное");
}
else if (number < 0)
{
    System.Console.WriteLine("число отрицательное");
}
else
{
    System.Console.WriteLine("число равно нулю");
}

Console.Write("Введите балл (0-100) ");
int score = int.Parse(Console.ReadLine());
if (score >= 91) {
    System.Console.WriteLine("5");
}
else if (score >= 71) {
    System.Console.WriteLine("4");
}
else if (score >= 51) {
    System.Console.WriteLine("3");
}
else {
    System.Console.WriteLine("2");
}

Console.Write("Введите кол-во посещений(из 19) ");
int attendance =  int.Parse(Console.ReadLine());
Console.Write("Введите ср балл по практике ");
double practiceGpa = double.Parse(Console.ReadLine());
bool goodAttendanse = attendance >= 14;
bool goodGrades = practiceGpa >= 3.0;
if (goodAttendanse && goodGrades) {
    System.Console.WriteLine("+ допуск к экз разрешен");
}
else if (!goodAttendanse && goodGrades) {
    System.Console.WriteLine("недостаточно посещений");
}
else if (goodAttendanse && !goodGrades) {
    System.Console.WriteLine("низкий балл по пракитке");
}
else {
    System.Console.WriteLine("проблемы с помещаемостью и оценками");
}
