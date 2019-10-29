using System;

namespace Задача_про_машины
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пользовательские переменные

            double speed_1 = 0; //начальная скорость 1 авто
            double speed_2 = 0; //начальная скорость 2 авто

            double speed_up_1 = 0; //ускорение первой машины
            double speed_up_2 = 0; //ускорение второй машины

            double dist = 0; //начальное расстояние

            double benz_rash_1 = 0; //расход первой машины
            double benz_rash_2 = 0; //расход второй машины

            double benz_1 = 0; //цена бензина первой машины
            double benz_2 = 0; //цена бензина второй машины

            //Расчётные переменные

            bool b; //для проверки введенных данных пользователем

            double time_1 = 0; //время
            double time_2 = 0; //время

            double s1 = 0; //сколько проехала первая машина
            double s2 = 0; //сколько проехала вторая машина

            double speed_up = 0; //для общего ускорение и пополам
            double speed = 0; //сума двух скоростей

            double d; //дискрименант

            double v_benz_1 = 0; //объем топлива для первой машины
            double v_benz_2 = 0; //объем топлива для второй машины
            double summ_benz_1 = 0; //итоговая сумма на бензин для первой машины
            double summ_benz_2 = 0; //итоговая сумма на бензин для второй машины

            int exit; //это для зацикливания или выхода из программы




            //Вступительная часть
            main:
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("-              Привет!                 -");
            Console.WriteLine("-                                      -");
            Console.WriteLine("-      Следуйте подсказкам и у Вас     -");
            Console.WriteLine("-           всё получиться!            -");
            Console.WriteLine("-                                      -");
            Console.WriteLine("-               2019 г.                -");
            Console.WriteLine("----------------------------------------");



           //Ввод и проверка вводимых переменных
        enter1:Console.WriteLine("Введите начальное расстояние: ");
            b = double.TryParse(Console.ReadLine(), out dist); 
            if (b == true && dist >= 0)
            {
                Console.Clear();
                Console.WriteLine("Пока что вы ввели:  ");
                Console.WriteLine($"Начальное расстояние: {dist}");

                Console.WriteLine("---------------------------");

                enter2:Console.WriteLine("Введите начальную скорость 1-ого авто: ");
                b = double.TryParse(Console.ReadLine(), out speed_1);
                if (b == true && speed_1 >=0)
                {
                    Console.Clear();
                    Console.WriteLine("Пока что вы ввели:  ");
                    Console.WriteLine($"Начальное расстояние: {dist}");
                    Console.WriteLine("                                            ");
                    Console.WriteLine($"Начальное начальную скорость 1-ого авто: {speed_1}");

                    Console.WriteLine("---------------------------");

                    enter3:Console.WriteLine("Введите начальную скорость 2-ого авто: ");
                    b = double.TryParse(Console.ReadLine(), out speed_2);
                    if (b == true && speed_2 >= 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Пока что вы ввели:  ");
                        Console.WriteLine($"Начальное расстояние: {dist}");
                        Console.WriteLine("                                            ");
                        Console.WriteLine($"Начальное начальную скорость 1-ого авто: {speed_1}");
                        Console.WriteLine($"Начальное начальную скорость 2-ого авто: {speed_2}");

                        Console.WriteLine("---------------------------");

                        enter4:Console.WriteLine("Введите ускорение 1-ого авто: ");
                        b = double.TryParse(Console.ReadLine(), out speed_up_1);
                        if (b == true)
                        {
                            Console.Clear();
                            Console.WriteLine("Пока что вы ввели:  ");
                            Console.WriteLine($"Начальное расстояние: {dist}");
                            Console.WriteLine("                                            ");
                            Console.WriteLine($"Начальное начальную скорость 1-ого авто: {speed_1}");
                            Console.WriteLine($"Начальное начальную скорость 2-ого авто: {speed_2}");
                            Console.WriteLine("                                            ");
                            Console.WriteLine($"Начальное ускорение 1-ого авто: {speed_up_1}");

                            Console.WriteLine("---------------------------");

                            enter5:Console.WriteLine("Введите ускорение 2-ого авто: ");
                            b = double.TryParse(Console.ReadLine(), out speed_up_2);
                            if (b == true)
                            {
                                Console.Clear();
                                Console.WriteLine("Пока что вы ввели:  ");
                                Console.WriteLine($"Начальное расстояние: {dist}");
                                Console.WriteLine("                                            ");
                                Console.WriteLine($"Начальное начальную скорость 1-ого авто: {speed_1}");
                                Console.WriteLine($"Начальное начальную скорость 2-ого авто: {speed_2}");
                                Console.WriteLine("                                            ");
                                Console.WriteLine($"Начальное ускорение 1-ого авто: {speed_up_1}");
                                Console.WriteLine($"Начальное ускорение 2-ого авто: {speed_up_2}");

                                Console.WriteLine("---------------------------");

                                enter6:Console.WriteLine("Введите расход топлива 1-ого авто за 100 км: ");
                                b = double.TryParse(Console.ReadLine(), out benz_rash_1);
                                if (b == true && benz_rash_1 > 0)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Пока что вы ввели:  ");
                                    Console.WriteLine($"Начальное расстояние: {dist}");
                                    Console.WriteLine("                                            ");
                                    Console.WriteLine($"Начальное начальную скорость 1-ого авто: {speed_1}");
                                    Console.WriteLine($"Начальное начальную скорость 2-ого авто: {speed_2}");
                                    Console.WriteLine("                                            ");
                                    Console.WriteLine($"Начальное ускорение 1-ого авто: {speed_up_1}");
                                    Console.WriteLine($"Начальное ускорение 2-ого авто: {speed_up_2}");
                                    Console.WriteLine("                                            ");
                                    Console.WriteLine($"Расход топлива 1-ого авто: {benz_rash_1} л / 100 км");

                                    Console.WriteLine("---------------------------");

                                    enter7:Console.WriteLine("Введите расход топлива 2 авто за 100 км: ");
                                    b = double.TryParse(Console.ReadLine(), out benz_rash_2);
                                    if (b == true && benz_rash_2 > 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Пока что вы ввели:  ");
                                        Console.WriteLine($"Начальное расстояние: {dist}");
                                        Console.WriteLine("                                            ");
                                        Console.WriteLine($"Начальное начальную скорость 1-ого авто: {speed_1}");
                                        Console.WriteLine($"Начальное начальную скорость 2-ого авто: {speed_2}");
                                        Console.WriteLine("                                            ");
                                        Console.WriteLine($"Начальное ускорение 1-ого авто: {speed_up_1}");
                                        Console.WriteLine($"Начальное ускорение 2-ого авто: {speed_up_2}");
                                        Console.WriteLine("                                            ");
                                        Console.WriteLine($"Расход топлива 1-ого авто: {benz_rash_1} л / 100 км");
                                        Console.WriteLine($"Расход топлива 2-ого авто: {benz_rash_2} л / 100 км");

                                        Console.WriteLine("---------------------------");

                                        enter8:Console.WriteLine("Введите цену топлива 1-ого авто (за литр): ");
                                        b = double.TryParse(Console.ReadLine(), out benz_1);
                                        if (b == true && benz_1 > 0)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Пока что вы ввели:  ");
                                            Console.WriteLine($"Начальное расстояние: {dist}");
                                            Console.WriteLine("                                            ");
                                            Console.WriteLine($"Начальное начальную скорость 1-ого авто: {speed_1}");
                                            Console.WriteLine($"Начальное начальную скорость 2-ого авто: {speed_2}");
                                            Console.WriteLine("                                            ");
                                            Console.WriteLine($"Начальное ускорение 1-ого авто: {speed_up_1}");
                                            Console.WriteLine($"Начальное ускорение 2-ого авто: {speed_up_2}");
                                            Console.WriteLine("                                            ");
                                            Console.WriteLine($"Расход топлива 1-ого авто: {benz_rash_1} л / 100 км");
                                            Console.WriteLine($"Расход топлива 2-ого авто: {benz_rash_2} л / 100 км");
                                            Console.WriteLine("                                            ");
                                            Console.WriteLine($"Цена топлива 1-ого авто (за литр): {benz_1}");

                                            Console.WriteLine("---------------------------");

                                            enter9:Console.WriteLine("Введите цену топлива 2-ого авто (за литр): ");
                                            b = double.TryParse(Console.ReadLine(), out benz_2);
                                            if (b == true && benz_2 > 0)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                                Console.WriteLine("Вводные данные:  ");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Console.WriteLine($"Начальное расстояние: {dist}");
                                                Console.WriteLine("                                            ");
                                                Console.WriteLine($"Начальное начальную скорость 1-ого авто: {speed_1}");
                                                Console.WriteLine($"Начальное начальную скорость 2-ого авто: {speed_2}");
                                                Console.WriteLine("                                            ");
                                                Console.WriteLine($"Начальное ускорение 1-ого авто: {speed_up_1}");
                                                Console.WriteLine($"Начальное ускорение 2-ого авто: {speed_up_2}");
                                                Console.WriteLine("                                            ");
                                                Console.WriteLine($"Расход топлива 1-ого авто: {benz_rash_1} л / 100 км");
                                                Console.WriteLine($"Расход топлива 2-ого авто: {benz_rash_2} л / 100 км");
                                                Console.WriteLine("                                            ");
                                                Console.WriteLine($"Цена топлива 1-ого авто (за литр): {benz_1}");
                                                Console.WriteLine($"Цена топлива 2-ого авто (за литр): {benz_2}");
                                                Console.WriteLine("          ");
                                                Console.WriteLine("---------------------------");
                                                Console.WriteLine("          ");

                                                //отрисовка типо загрузки
                                                Console.Clear();
                                                string Loading = "Loading...";
                                                string ProgressBar = "";
                                                Console.WriteLine(Loading);
                                                int Counter = 20;
                                                while (Counter >= 0)
                                                {
                                                    Console.Write("[{0}", ProgressBar);
                                                    Console.SetCursorPosition(20 + 1, 1);
                                                    Console.Write("] {0}%", 100 - Counter * 5);
                                                    Console.SetCursorPosition(0, 1);
                                                    ProgressBar += "|";
                                                    System.Threading.Thread.Sleep(1000);
                                                    Counter--;
                                                }
                                                Console.SetCursorPosition(Loading.Length, 0);
                                                Console.WriteLine("OK\n");
                                                Console.ReadKey(true);
                                                //всё что относиться к ней, здесь

                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                                Console.WriteLine("Вводные данные:  ");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Console.WriteLine($"Начальное расстояние: {dist}");
                                                Console.WriteLine("                                            ");
                                                Console.WriteLine($"Начальное начальную скорость 1-ого авто: {speed_1}");
                                                Console.WriteLine($"Начальное начальную скорость 2-ого авто: {speed_2}");
                                                Console.WriteLine("                                            ");
                                                Console.WriteLine($"Начальное ускорение 1-ого авто: {speed_up_1}");
                                                Console.WriteLine($"Начальное ускорение 2-ого авто: {speed_up_2}");
                                                Console.WriteLine("                                            ");
                                                Console.WriteLine($"Расход топлива 1-ого авто: {benz_rash_1} л / 100 км");
                                                Console.WriteLine($"Расход топлива 2-ого авто: {benz_rash_2} л / 100 км");
                                                Console.WriteLine("                                            ");
                                                Console.WriteLine($"Цена топлива 1-ого авто (за литр): {benz_1}");
                                                Console.WriteLine($"Цена топлива 2-ого авто (за литр): {benz_2}");
                                                Console.WriteLine("          ");
                                                Console.WriteLine("---------------------------");
                                                Console.WriteLine("          ");


                                                goto start; //прокидывает на начало расчётов
                                                

                                            }
                                            else
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("Вы ввели не корекные данные!");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Console.WriteLine("Проверьте еще раз пожалуйста =)");
                                                Console.WriteLine("---------------------------");
                                                goto enter9;
                                            }
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("Вы ввели не корекные данные!");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("Проверьте еще раз пожалуйста =)");
                                            Console.WriteLine("---------------------------");
                                            goto enter8;
                                        }
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Вы ввели не корекные данные!");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Проверьте еще раз пожалуйста =)");
                                        Console.WriteLine("---------------------------");
                                        goto enter7;
                                    }
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Вы ввели не корекные данные!");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("Проверьте еще раз пожалуйста =)");
                                    Console.WriteLine("---------------------------");
                                    goto enter6;
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Вы ввели не корекные данные!");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Проверьте еще раз пожалуйста =)");
                                Console.WriteLine("---------------------------");
                                goto enter5;
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Вы ввели не корекные данные!");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Проверьте еще раз пожалуйста =)");
                            Console.WriteLine("---------------------------");
                            goto enter4;
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Вы ввели не корекные данные!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Проверьте еще раз пожалуйста =)");
                        Console.WriteLine("---------------------------");
                        goto enter3;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вы ввели не корекные данные!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Проверьте еще раз пожалуйста =)");
                    Console.WriteLine("---------------------------");
                    goto enter2;
                }
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Вы ввели не корекные данные!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Проверьте еще раз пожалуйста =)");
                Console.WriteLine("---------------------------");
                goto enter1;
            }

        start:
            speed_up = (speed_up_1 + speed_up_2) / 2; //коф "a" 
            speed = (speed_1 + speed_2); //коф "b" 


            d = (Math.Pow(speed, 2)) - 4 * speed_up * (-dist); //дискрименант

            if (d >= 0) //ветвление квадратного уравнения
            {
                if (d > 0)
                {
                    time_1 = ((-speed) - Math.Sqrt(d)) / (2 * speed_up);
                    time_2 = ((-speed) + Math.Sqrt(d)) / (2 * speed_up);
                }
                else
                {
                    time_1 = (-speed) / (2 * speed_up);
                }
            }
            else
            {
                Console.WriteLine("Ситуация не возможна =(");
                Console.WriteLine("Возникла ошибка, попробуйте сначала");
                goto main; //отправляет в самое начало
                
            }

            if (time_1 > time_2) //тут отбираем время, чтобы оно было положительное
            {
                s1 = (speed_1 * time_1) + (speed_up_1 * Math.Pow(time_1, 2)) / 2;
                s2 = (speed_2 * time_1) + (speed_up_2 * Math.Pow(time_1, 2)) / 2;

                v_benz_1 = 100 / benz_rash_1;
                v_benz_1 = s1 / v_benz_1;
                summ_benz_1 = v_benz_1 * benz_1;

                v_benz_2 = 100 / benz_rash_2;
                v_benz_2 = s2 / v_benz_2;
                summ_benz_2 = v_benz_2 * benz_2;

                v_benz_1 = Math.Round(v_benz_1, 2);
                v_benz_2 = Math.Round(v_benz_2, 2);

                summ_benz_1 = Math.Round(summ_benz_1, 2);
                summ_benz_2 = Math.Round(summ_benz_2, 2);

                s1 = Math.Round(s1, 2);
                s2 = Math.Round(s2, 2);

                time_1 = Math.Round(time_1, 2);
                Console.WriteLine($"Время на сближение составит: {time_1} часа") ;
                Console.WriteLine("                                            ");
                Console.WriteLine($"Расстояние которое проедит первая машина: {s1} км.");
                Console.WriteLine($"Столько потребуется топлива: {v_benz_1} л.");
                Console.WriteLine($"И обойдётся оно в: {summ_benz_1} руб.");
                Console.WriteLine("                                            ");
                Console.WriteLine($"Расстояние которое проедит вторая машина: {s2} км.");
                Console.WriteLine($"Столько потребуется топлива: {v_benz_2} л.");
                Console.WriteLine($"И обойдётся оно в: {summ_benz_2} руб.");

            }
            else
            {
                s1 = (speed_1 * time_2) + (speed_up_1 * Math.Pow(time_2, 2)) / 2; //тут считаем растояние которое проделала первая машина всё это по формулам из класса 
                s2 = (speed_2 * time_2) + (speed_up_2 * Math.Pow(time_2, 2)) / 2; //тут считаем растояние которое проделала вторая машина всё это по формулам из класса 

                v_benz_1 = 100 / benz_rash_1; //тут смотри на сколько км хватит 1л топлива
                v_benz_1 = s1 / v_benz_1; //теперь делем растояние которое проедет машина на км 
                summ_benz_1 = v_benz_1 * benz_1; //далее полученное умножаем на цену топлива

                v_benz_2 = 100 / benz_rash_2;
                v_benz_2 = s2 / v_benz_2;
                summ_benz_2 = v_benz_2 * benz_2;

                v_benz_1 = Math.Round(v_benz_1, 2); //тут тупо округляем до 2 цифр после запятой
                v_benz_2 = Math.Round(v_benz_2, 2);

                summ_benz_1 = Math.Round(summ_benz_1, 2);
                summ_benz_2 = Math.Round(summ_benz_2, 2);

                s1 = Math.Round(s1, 2);
                s2 = Math.Round(s2, 2);

                time_2 = Math.Round(time_2, 2);
                Console.WriteLine($"Время на сближение составит: {time_2} часа");
                Console.WriteLine("                                            ");
                Console.WriteLine($"Расстояние которое проедит первая машина: {s1} км.");
                Console.WriteLine($"Столько потребуется топлива: {v_benz_1} л.");
                Console.WriteLine($"И обойдётся оно в: {summ_benz_1} руб.");
                Console.WriteLine("                                            ");
                Console.WriteLine($"Расстояние которое проедит вторая машина: {s2} км.");
                Console.WriteLine($"Столько потребуется топлива: {v_benz_2} л.");
                Console.WriteLine($"И обойдётся оно в: {summ_benz_2} руб.");
            }

          
            Console.ReadKey(true); //не обязательный модуль выхода из программыы

            last: 
            Console.Clear();
            Console.WriteLine("Запустить программу заново?");
            Console.WriteLine("                                            ");
            Console.WriteLine("1. Да");
            Console.WriteLine("2. Нет");
            b = int.TryParse(Console.ReadLine(), out exit);
            if (b == true)
            {
                if (exit == 1)
                {
                    Console.Clear();
                    goto main;
                }
                else if (exit == 2)
                {
                    goto exit1;
                }
                else if (exit > 2)
                {
                    goto last;
                }
                     
            }
            else
            {
                Console.WriteLine("Ну как тут можно ошибиться, давай еще раз");
                goto last;
            }
            exit1: Console.WriteLine("До новых встреч!");

        }
    }
}
