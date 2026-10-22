using System;

namespace PR_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = 1;
            while (answer == 1)
            {
                bool error;
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.Title = "Массивы";

                const int count = 10;
                int[] array = new int[count];

                // Выбор способа заполнения массива
                int choice = 0;
                while (choice != 1 && choice != 2)
                {
                    Console.WriteLine("Здравствуйте!\nВыберите способ заполнения массива:");
                    Console.WriteLine("1 — Ввод вручную с клавиатуры");
                    Console.WriteLine("2 — Случайные числа в диапазоне");
                    Console.Write("Ваш выбор: ");
                    try
                    {
                        choice = Convert.ToInt32(Console.ReadLine());
                        if (choice != 1 && choice != 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ошибка! Введите 1 или 2.");
                            Console.ForegroundColor = ConsoleColor.Black;
                        }
                    }
                    catch (FormatException ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Возникла ошибка. Детали: {ex.Message}");
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    catch (OverflowException ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Возникла ошибка. Детали: {ex.Message}");
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                }

                // Заполнение массива
                if (choice == 1)
                {
                    Console.WriteLine($"\nВведите {count} целых чисел:");
                    for (int i = 0; i < count; i++)
                    {
                        error = false;
                        Console.Write($"Элемент [{i + 1}]: ");
                        try
                        {
                            array[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (FormatException ex)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            error = true;
                            Console.WriteLine($"Возникла ошибка. Детали: {ex.Message}");
                            Console.ForegroundColor = ConsoleColor.Black;
                        }
                        catch (OverflowException ex)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            error = true;
                            Console.WriteLine($"Возникла ошибка. Детали: {ex.Message}");
                            Console.ForegroundColor = ConsoleColor.Black;
                        }

                        if (error) i--;
                    }
                }
                else
                {
                    int min = 0;
                    int max = 0;
                    error = true;

                    while (error)
                    {
                        try
                        {
                            Console.Write("\nВведите начало диапазона: ");
                            min = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Введите конец диапазона: ");
                            max = Convert.ToInt32(Console.ReadLine());

                            if (min > max)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Ошибка! Начало диапазона не может быть больше конца.");
                                Console.ForegroundColor = ConsoleColor.Black;
                            }
                            else
                            {
                                error = false;
                            }
                        }
                        catch (FormatException ex)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"Возникла ошибка. Детали: {ex.Message}");
                            Console.ForegroundColor = ConsoleColor.Black;
                        }
                        catch (OverflowException ex)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"Возникла ошибка. Детали: {ex.Message}");
                            Console.ForegroundColor = ConsoleColor.Black;
                        }
                    }

                    Random rnd = new Random();
                    for (int i = 0; i < count; i++)
                    {
                        array[i] = rnd.Next(min, max + 1);
                    }
                }

                // Вывод сформированного массива
                Console.WriteLine("\nСформированный массив:");
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine($"Порядковый номер {i + 1}: {array[i]}");
                }

                // Ввод порядкового номера первого элемента
                int position1 = 0;
                error = true;
                while (error)
                {
                    Console.Write($"\nВведите порядковый номер первого элемента (от 1 до {count}): ");
                    try
                    {
                        position1 = Convert.ToInt32(Console.ReadLine());
                        if (position1 < 1 || position1 > count)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"Ошибка! Номер {position1} выходит за пределы массива (1-{count}).");
                            Console.ForegroundColor = ConsoleColor.Black;
                        }
                        else
                        {
                            error = false;
                        }
                    }
                    catch (FormatException ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Возникла ошибка. Детали: {ex.Message}");
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    catch (OverflowException ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Возникла ошибка. Детали: {ex.Message}");
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                }

                // Ввод порядкового номера второго элемента
                int position2 = 0;
                error = true;
                while (error)
                {
                    Console.Write($"Введите порядковый номер второго элемента (от 1 до {count}): ");
                    try
                    {
                        position2 = Convert.ToInt32(Console.ReadLine());
                        if (position2 < 1 || position2 > count)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"Ошибка! Номер {position2} выходит за пределы массива (1-{count}).");
                            Console.ForegroundColor = ConsoleColor.Black;
                        }
                        else
                        {
                            error = false;
                        }
                    }
                    catch (FormatException ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Возникла ошибка. Детали: {ex.Message}");
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    catch (OverflowException ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Возникла ошибка. Детали: {ex.Message}");
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                }

                // Подсчет суммы элементов
                int sum = array[position1 - 1] + array[position2 - 1];
                Console.WriteLine($"\nСумма элементов #{position1} ({array[position1 - 1]}) и #{position2} ({array[position2 - 1]}): {sum}");

                // Повтор программы
                answer = -1;
                while (answer != 0 && answer != 1)
                {
                    Console.Write("\nХотите начать заново? (1 — да, 0 — нет): ");
                    try
                    {
                        answer = Convert.ToInt32(Console.ReadLine());
                        if (answer != 0 && answer != 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ошибка! Введите 1 или 0.");
                            Console.ForegroundColor = ConsoleColor.Black;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ошибка! Введите 1 или 0.");
                        Console.ForegroundColor = ConsoleColor.Black;
                        answer = -1;
                    }
                    catch (OverflowException)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ошибка! Введите 1 или 0.");
                        Console.ForegroundColor = ConsoleColor.Black;
                        answer = -1;
                    }
                }
            }
        }
    }
}