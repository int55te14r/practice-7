using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1: Базовые операции
            int[] numbers = { 12, 45, 23, 8, 34, 56, 21, 9, 78, 15 };

            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            double average = (double)sum / numbers.Length;

            int evenCount = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                    evenCount++;
            }

            Console.WriteLine($"Массив: {string.Join(", ", numbers)}");
            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Среднее арифметическое: {average:F2}");
            Console.WriteLine($"Количество четных чисел: {evenCount}");


            //2: Поиск элементов в массиве строк
            string[] words = { "Программирование", "Массив", "Язык", "Компьютер", "Данные", "Система" };

            // Самая длинная строка
            string longestWord = words[0];
            for (int i = 1; i < words.Length; i++)
            {
                if (words[i].Length > longestWord.Length)
                    longestWord = words[i];
            }

            Console.WriteLine($"Массив слов: {string.Join(", ", words)}");
            Console.WriteLine($"Самая длинная строка: {longestWord} ({longestWord.Length} символов)");

            // Поиск строк с подстрокой
            Console.Write("Введите подстроку для поиска: ");
            string substring = Console.ReadLine();
            Console.Write("Строки с подстрокой '{0}': ", substring);
            bool found = false;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains(substring))
                {
                    Console.Write(words[i] + " ");
                    found = true;
                }
            }
            if (!found)
                Console.Write("не найдены");
            Console.WriteLine();

            // Индекс первого вхождения
            Console.Write("Введите слово для поиска индекса: ");
            string searchWord = Console.ReadLine();
            int index = -1;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == searchWord)
                {
                    index = i;
                    break;
                }
            }
            if (index >= 0)
                Console.WriteLine($"Индекс '{searchWord}': {index}");
            else
                Console.WriteLine($"'{searchWord}' не найдено");
            Console.WriteLine();


            //3: Обработка вещественных чисел
            double[] temperatures = { 12.5, 18.3, 25.7, 14.2, 22.1, 19.8, 26.4,
                         15.9, 20.5, 23.2, 17.6, 24.1, 21.3, 19.2, 27.8 };

            double minTemp = temperatures[0];
            double maxTemp = temperatures[0];
            for (int i = 1; i < temperatures.Length; i++)
            {
                if (temperatures[i] < minTemp)
                    minTemp = temperatures[i];
                if (temperatures[i] > maxTemp)
                    maxTemp = temperatures[i];
            }

            double sum2 = 0;
            for (int i = 0; i < temperatures.Length; i++)
            {
                sum2 += temperatures[i];
            }
            double avgTemp = sum2 / temperatures.Length;

            Console.WriteLine($"Минимальная температура: {minTemp}");
            Console.WriteLine($"Максимальная температура: {maxTemp}");
            Console.WriteLine($"Разность: {maxTemp - minTemp}");
            Console.WriteLine($"Среднее: {avgTemp:F2}");
            Console.Write("Элементы выше среднего: ");
            for (int i = 0; i < temperatures.Length; i++)
            {
                if (temperatures[i] > avgTemp)
                    Console.Write(temperatures[i] + " ");
            }
            Console.WriteLine("\n");


            //4: Удаление нулей из массива
            int[] numbersWithZeros = { 5, 0, 10, 0, 3, 0, 8, 0, 2 };

            // Считаем ненулевые элементы
            int nonZeroCount = 0;
            for (int i = 0; i < numbersWithZeros.Length; i++)
            {
                if (numbersWithZeros[i] != 0)
                    nonZeroCount++;
            }

            // Создаем новый массив без нулей
            int[] cleanArray = new int[nonZeroCount];
            int position = 0;
            for (int i = 0; i < numbersWithZeros.Length; i++)
            {
                if (numbersWithZeros[i] != 0)
                {
                    cleanArray[position] = numbersWithZeros[i];
                    position++;
                }
            }

            Console.WriteLine($"Исходный массив: {string.Join(", ", numbersWithZeros)}");
            Console.WriteLine($"После удаления нулей: {string.Join(", ", cleanArray)}\n");


            //5: Поиск сотрудников
            string[] employees = {
    "Иванов Иван-Разработчик",
    "Петров Петр-Дизайнер",
    "Сидоров Сидор-Разработчик",
    "Алексеев Алекс-Менеджер",
    "Афанасьев Афан-Дизайнер"
};

            // С заданной должностью (Разработчик)
            var developers = employees.Where(e => e.Contains("Разработчик"));
            Console.WriteLine("Разработчики:");
            foreach (var dev in developers)
            {
                Console.WriteLine($"  - {dev}");
            }

            // Фамилия начинается с "А"
            var startsWithA = employees.Where(e => e.StartsWith("А"));
            Console.WriteLine("Фамилии на 'А':");
            foreach (var emp in startsWithA)
            {
                Console.WriteLine($"  - {emp}");
            }

            // Отсортированы по алфавиту
            var sorted = employees.OrderBy(e => e);
            Console.WriteLine("Отсортировано по алфавиту:");
            foreach (var emp in sorted)
            {
                Console.WriteLine($"  - {emp}");
            }
            Console.WriteLine();


            //6: Анализ температур
            double[] monthTemps = { -15, -10, -8, 5, 12, 18, 22, 25, 20, 10, 2, -5 };
            double avgMonthTemp = monthTemps.Average();

            Console.WriteLine("Дни выше средней температуры:");
            var warmDays = monthTemps.Where(t => t > avgMonthTemp);
            foreach (var temp in warmDays)
            {
                Console.WriteLine($"  - {temp}°C");
            }

            // Группировка по категориям
            Console.WriteLine("Группировка по диапазонам:");
            Console.WriteLine("Мороз (< -10): " + monthTemps.Where(t => t < -10).Count() + " дней");
            Console.WriteLine("Холодно (-10 до 0): " + monthTemps.Where(t => t >= -10 && t < 0).Count() + " дней");
            Console.WriteLine("Тепло (0 до 15): " + monthTemps.Where(t => t >= 0 && t < 15).Count() + " дней");
            Console.WriteLine("Жарко (>= 15): " + monthTemps.Where(t => t >= 15).Count() + " дней\n");


            //7: Каталог товаров
            {
                string[] products =
                {
            "Ноутбук-1200-Электроника",
            "Смартфон-800-Электроника",
            "Футболка-25-Одежда",
            "Джинсы-60-Одежда",
            "Кофеварка-150-БытоваяТехника",
            "Микроволновка-200-БытоваяТехника",
            "Наушники-100-Электроника",
            "Кроссовки-80-Одежда",
        };

                Console.WriteLine("КАТАЛОГ ТОВАРОВ");

                // Фильтрация без return
                Console.WriteLine("Товары в диапазоне 50-200:");
                var priceRange = products.Where(p => Convert.ToDouble(p.Split('-')[1]) >= 50 && Convert.ToDouble(p.Split('-')[1]) <= 200);

                foreach (var product in priceRange)
                    Console.WriteLine(product.Replace('-', ' '));

                // Сортировка по возрастанию без return
                Console.WriteLine("\nСортировка по возрастанию:");
                var sortedAsc = products.OrderBy(p => Convert.ToDouble(p.Split('-')[1]));
                foreach (var p in sortedAsc) Console.WriteLine(p);

                // Средняя цена без return
                double avg = products.Average(p => Convert.ToDouble(p.Split('-')[1]));
                Console.WriteLine($"\nСредняя цена: {avg}");

                // Количество по категориям без return
                Console.WriteLine("\nКатегории:");
                products.Select(p => p.Split('-')[2])
                        .Distinct()
                        .ToList()
                        .ForEach(cat => Console.WriteLine($"{cat}: {products.Count(p => p.Contains(cat))}"));

                //8: Анализ результатов тестирования
                int[] testResults = { 85, 92, 78, 95, 88, 76, 91, 87, 94, 81, 89, 77, 90, 86, 93 };

                    // Сортируем для медианы
                    var sorted2 = testResults.OrderBy(x => x).ToArray();
                    double median = sorted2.Length % 2 == 0
                        ? (sorted2[sorted2.Length / 2 - 1] + sorted2[sorted2.Length / 2]) / 2.0
                        : sorted2[sorted2.Length / 2];

                    Console.WriteLine($"Медиана: {median}");

                    // Среднее значение
                    double avgTest = testResults.Average();
                    Console.WriteLine($"Среднее значение: {avgTest:F2}");

                    // Топ 10% (лучших результатов)
                    int topCount = Math.Max(1, testResults.Length / 10);
                    var top10percent = testResults.OrderByDescending(x => x).Take(topCount);
                    Console.WriteLine($"Топ 10% результатов: {string.Join(", ", top10percent)}");

                    // Группировка по интервалам
                    Console.WriteLine("Группировка по интервалам:");
                    Console.WriteLine("70-79: " + testResults.Where(r => r >= 70 && r < 80).Count());
                    Console.WriteLine("80-89: " + testResults.Where(r => r >= 80 && r < 90).Count());
                    Console.WriteLine("90-100: " + testResults.Where(r => r >= 90 && r <= 100).Count());
                    Console.WriteLine();
                }
            }
        }
    }

