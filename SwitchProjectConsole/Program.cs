using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchProjectConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            do {
                Console.Clear(); 
                Console.WriteLine("Меню:\n1) Решить квадратное уравнение;\n2) Расшифровать день недели;\n3) Посчитать площать и периметр прямоугольника;\n4) Выход.");
            int A = int.Parse(Console.ReadLine());
                
            switch(A)
            { case 1: 
                    Console.Clear();
                    Console.WriteLine("Введите А: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите B: ");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите C: ");
                    int c = int.Parse(Console.ReadLine());
                    if (a == -0 || b == -0 || c == -0)
                        Console.WriteLine("Error.");
                    else
                    {
                        double D;
                        D = b * b - 4 * a * c;
                        if (D > 0)
                        {
                            double x1, x2;
                            x1 = (-b + Math.Sqrt(D)) / (2 * a);
                            x2 = (-b - Math.Sqrt(D)) / (2 * a);
                            Console.WriteLine("X1 = " + x1);
                            Console.WriteLine("X2 = " + x2);
                        }
                        else if (D == 0)
                        {
                            double x = (-b) / (2 * a);
                            Console.WriteLine("X = " + x);
                        }
                        else Console.WriteLine("Решений не существует");
                    }
                                       
                    break;
                case 2: 
                    
                    Console.Clear();
                    Console.WriteLine("Введите число от 1 до 7: ");
                    int W = int.Parse(Console.ReadLine());
                    switch(W)
                    {                           
                            case 1: Console.WriteLine("Понедельник."); break;
                            case 2: Console.WriteLine("Вторник."); break;
                            case 3: Console.WriteLine("Среда."); break;
                            case 4: Console.WriteLine("Четверг."); break;
                            case 5: Console.WriteLine("Пятница."); break;
                            case 6: Console.WriteLine("Суббота."); break;
                            case 7: Console.WriteLine("Воскресенье."); break;
                            default: Console.WriteLine("Eror."); break;
                            }
                           
                    
                     
                    break;
                    

                case 3: Console.Clear();
                    Console.WriteLine("Введите A: ");
                    int q = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите B: ");
                    double p = int.Parse(Console.ReadLine());
                    double S, P;
                    if (q > 0 && p > 0)
                    {
                        P = 2 * (q + p);
                        S = q * p;
                        Console.WriteLine("Площадь: " + S);
                        Console.WriteLine("Периметр: " + P);
                    }
                    else Console.WriteLine("Error.");                   
                    break;


                case 4: Console.Clear(); break;
                default: Console.WriteLine("ERROR! AAAAAAAAAAAAAAAAAAAAAA!!!!!!!!!! SOS!!!!!!!!!!! HELP!");
                    
                    break;
                   
            }
            Console.WriteLine("0) Вернуться в меню.");
            i = int.Parse(Console.ReadLine());
            } while (i == 0);
            Console.Clear();
                    
 


                    


        
    }
    }
    }



