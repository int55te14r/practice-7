using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_задание
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string[] students =
            {
            "Аскар-5,2,5",
            "Элина-3,4,3",
            "Дина-4,5,3",
            "Артем-5,3,2",
            "Равиль-4,4,5"
        };

            string[] subjects = { "Математика", "Физика", "Программирование" };
            Console.WriteLine("=== СИСТЕМА УЧЕТА СТУДЕНТОВ ===");
            Console.Write("Введите минимальный средний балл: ");
            double minAvg = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Студенты со средним баллом > {minAvg}:");
            foreach (string student in students)
            {
                string[] parts = student.Split('-');
                string[] grades = parts[1].Split(',');
                double sum = 0;
                foreach (string grade in grades)
                {
                    sum += Convert.ToDouble(grade);
                }
                double avg = sum / grades.Length;

                if (avg > minAvg)
                {
                    Console.WriteLine($"{parts[0]} - {avg:F1}");
                }
            }
            double maxSubjectAvg = 0;
            string bestSubject = "";

            for (int i = 0; i < subjects.Length; i++)
            {
                double subjectSum = 0;
                foreach (string student in students)
                {
                    string[] grades = student.Split('-')[1].Split(',');
                    subjectSum += Convert.ToDouble(grades[i]);
                }
                double subjectAvg = subjectSum / students.Length;

                if (subjectAvg > maxSubjectAvg)
                {
                    maxSubjectAvg = subjectAvg;
                    bestSubject = subjects[i];
                }
            }
            Console.WriteLine($"Предмет с наивысшим средним баллом: {bestSubject} ({maxSubjectAvg:F2})");
            Console.WriteLine("Рейтинг студентов:");
            for (int i = 0; i < students.Length - 1; i++)
            {
                for (int j = i + 1; j < students.Length; j++)
                {
                    string[] grades1 = students[i].Split('-')[1].Split(',');
                    string[] grades2 = students[j].Split('-')[1].Split(',');

                    double sum1 = 0, sum2 = 0;
                    foreach (string grade in grades1) sum1 += Convert.ToDouble(grade);
                    foreach (string grade in grades2) sum2 += Convert.ToDouble(grade);

                    double avg1 = sum1 / grades1.Length;
                    double avg2 = sum2 / grades2.Length;

                    if (avg1 < avg2)
                    {
                        string temp = students[i];
                        students[i] = students[j];
                        students[j] = temp;
                    }
                }
            }
            foreach (string student in students)
            {
                string[] parts = student.Split('-');
                string[] grades = parts[1].Split(',');

                double sum = 0;
                foreach (string grade in grades) sum += Convert.ToDouble(grade);
                double avg = sum / grades.Length;

                Console.WriteLine($"{parts[0]} - {avg:F1}");
            }
            Console.WriteLine("Отличники средний балл >= 4.5:");
            foreach (string student in students)
            {
                string[] parts = student.Split('-');
                string[] grades = parts[1].Split(',');

                double sum = 0;
                foreach (string grade in grades) sum += Convert.ToDouble(grade);
                double avg = sum / grades.Length;

                if (avg >= 4.5) Console.WriteLine($"{parts[0]:F2}");
            }
            Console.WriteLine("Двоечники средний балл < 3.0:");
            foreach (string student in students)
            {
                string[] parts = student.Split('-');
                string[] grades = parts[1].Split(',');
                double sum = 0;
                foreach (string grade in grades) sum += Convert.ToDouble(grade);
                double avg = sum / grades.Length;

                if (avg < 3.0) Console.WriteLine($"{parts[0]:F2}");
            }
        }
    }
}
