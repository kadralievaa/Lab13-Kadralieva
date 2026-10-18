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

//4 
Console.WriteLine();
double CalculateAverageGrade(int[] grades)
{
    int sum = 0;
    foreach (int grade in grades)
    {
        sum += grade;
    }
    return (double)sum / grades.Length;
}

int CountFives(int[] grades)
{
    int count = 0;
    foreach (int grade in grades)
    {
        if (grade == 5) count++;
    }
    return count;
}

int[] grades = { 4, 5, 3, 5, 4 };
double average = CalculateAverageGrade(grades);
int fives = CountFives(grades);
Console.WriteLine($"Средний балл: {average}");
Console.WriteLine($"Количество пятёрок: {fives}");
