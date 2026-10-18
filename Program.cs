// PrintHeader();
// PrintHeader();
// Console.WriteLine("Основная часть программы");
// PrintFooter();

// void PrintHeader()
// {
//     Console.WriteLine("^_^");
//     Console.WriteLine("Лабораторная работа 13");
//     Console.WriteLine("0_0");
// }
// void PrintFooter()
// {
//     Console.WriteLine(">_<");
//     Console.WriteLine("   Конец программы");
//     Console.WriteLine("X_X");
//     Console.WriteLine("Дата формирования отчёта");
// } 

// //2
// void PrintStudentCard(string name, int age, string groupnum)
// {
//     Console.Write($"Студент: {name}, возраст: {age}, номер группы: {groupnum}");
// }

// PrintStudentCard("Егор", 18, "ИСП-251 ");
// PrintStudentCard("Валерия", 17, "ЮСП-242");

// //3
// double CalculateScholarship(double baseAmount, double bonusPercent)
// {
//     return baseAmount + baseAmount * bonusPercent / 100;
// }
// bool IsEligibleForBonus(double averageGrade)
// {
//     return averageGrade >= 4.5;
// }
// double a = 2000;
// double studentaverageGrade = 4.7;
// double result = 0;
// if (IsEligibleForBonus(studentaverageGrade))
// {
//     result = CalculateScholarship(a, 15);
//     Console.WriteLine($"Стипендия с надбавкой: {result}");
// }
// else
// {
//     result = CalculateScholarship(a, 0);
//     Console.WriteLine($"Надбавки нет: {result}");
// }

// //4 
// Console.WriteLine();
// double CalculateAverageGrade(int[] grades)
// {
//     int sum = 0;
//     foreach (int grade in grades)
//     {
//         sum += grade;
//     }
//     return (double)sum / grades.Length;
// }

// int CountFives(int[] grades)
// {
//     int count = 0;
//     foreach (int grade in grades)
//     {
//         if (grade == 5) count++;
//     }
//     return count;
// }

// int[] grades = { 4, 5, 3, 5, 4 };
// double average = CalculateAverageGrade(grades);
// int fives = CountFives(grades);
// Console.WriteLine($"Средний балл: {average}");
// Console.WriteLine($"Количество пятёрок: {fives}");


// //5
// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine(Add(2, 3));           // 5
//         Console.WriteLine(Add(2.5, 3.5));       // 6.0
//         Console.WriteLine(Add(2, 3, 4));        // 9
//     }

//     static int Add(int a, int b)
//     {
//         return a + b;
//     }

//     static double Add(double a, double b)
//     {
//         return a + b;
//     }

//     static int Add(int a, int b, int c)
//     {
//         return a + b + c;
//     }
// }

// // Задача А
// void PrintDivider()
// {
//     Console.WriteLine("----------");
// }

// Console.WriteLine("Первый абзац");
// PrintDivider();
// Console.WriteLine("Второй абзац");
// PrintDivider();

// // Задача В
// bool IsEven(int number)
// {
//     return number % 2 == 0;
// }

// int something = 10;
// if (IsEven(something))
// {
//     Console.WriteLine($"Число {something} является четным");
// } else
// {
//     Console.WriteLine($"Число {something} является нечетным");
// }

// //Индивидуальный вариант ★★
// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
// Console.WriteLine("Фамилия не введена. Завершение работы.");return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
// .OrderBy(_ => rnd.Next())
// .Take(2)
// .OrderBy(x => x)
// .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

// // Вариант 8
// double CelsiusToFahrenheit(double celsius)
// {
//     return celsius * 9 / 5 + 32;
// }

// double c = 23.0;
// double f = CelsiusToFahrenheit(c);
// Console.WriteLine($"{c}°C = {f}°F");

// // Вариант 10 (я плаки плаки)
// bool IsPalindrome(string word)
// {
//     word = word.ToLower();

//     int left = 0;
//     int right = word.Length - 1;

//     while (left < right)
//     {
//         if (word[left] != word[right])
//         {
//             return false;
//         }
//         left++;
//         right--;
//     }
//     return true;

// }
// string word1 = "шалаш";
// string word2 = "привет";

// Console.WriteLine($"Слово '{word1}' - палидром? {IsPalindrome(word1)}");
// Console.WriteLine($"Слово '{word2}' - палидром? {IsPalindrome(word2)}");