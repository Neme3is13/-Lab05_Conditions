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

// using System.Globalization;

// Console.Write("Введите ваш возраст ");
// int age = int.Parse(Console.ReadLine());
// string ageGroup = age >= 18 ? "совершенноелетний" : "несовершеннолетний";
// System.Console.WriteLine($"вы {ageGroup}");
// System.Console.WriteLine("\nВведите температуру за окном (С) ");
// double temp = double.Parse(Console.ReadLine());
// string weather = temp >= 20 ? "teplo" : (temp >= 0 ? "prohladno" : "moroz");
// System.Console.WriteLine($"за окном {weather}");
// Console.Write("\nВведите число");
// int n = int.Parse(Console.ReadLine());
// string parity = n % 2 == 0 ? "4et" : "ne4et";
// System.Console.WriteLine($"число {n} - {parity}");

// System.Console.WriteLine("menu");
// System.Console.WriteLine("1. посмотрите расписание");
// System.Console.WriteLine("2. посмотреть оценки");
// System.Console.WriteLine("3. связаться с преподом");
// System.Console.WriteLine("4. выйти");
// System.Console.WriteLine("выберите пункт 1-4");
// string choice = Console.ReadLine();
// switch (choice) {
//     case "1":
//         System.Console.WriteLine("расписание пам пам");
//         break;
//     case "2":
//         System.Console.WriteLine("ваши оценки - ...");
//         break;
//     case "3":
//         System.Console.WriteLine("почта - ...");
//         break;
//     case "4":
//         System.Console.WriteLine("До свидания!");
//         break;
//     default:
//         System.Console.WriteLine($"ошибка пункт {choice} не сущ");
//         break;
// }

// Console.Write("\nвведитьеномер дня недели (1-7)" );
// int dayNumber = int.Parse(Console.ReadLine());
// switch (dayNumber) {
//     case 1:
//     case 2:
//     case 3:
//     case 4:
//     case 5:
//         System.Console.WriteLine("рабочий день");
//         break;
//     case 6:
//     case 7:
//         System.Console.WriteLine("выходной");
//         break;
//     default:
//         System.Console.WriteLine("такого дня не мущ");
//         break;
// }

Console.Write("Введите название месяца (1-12) ");
int mec = int.Parse(Console.ReadLine());
switch (mec) {
    case 12:
    case 1:
    case 2:
        System.Console.WriteLine("зима");
        break;
    case 3:
    case 4:
    case 5:
        System.Console.WriteLine("весна");
        break;
    case 6:
    case 7:
    case 8:
        System.Console.WriteLine("лето");
        break;
    case 9:
    case 10:
    case 11:
        System.Console.WriteLine("ОСЕНЬ");
        break;
    default:
        System.Console.WriteLine("такого месяца нет");
        break;
}