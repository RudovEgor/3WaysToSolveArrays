﻿using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = {1,2,2,3,40,5,6,6,7,10,121 };
            Console.WriteLine("Привет выберите что хотите сделать с массивом\n1:Нахождение 2-ух положительных массивов\n2:Есть ли в массиве одинаковые элементы\n3:Заполнение массива случайными числами");
            int UserChoice = 0;
            do
            {
                UserChoice = int.Parse(Console.ReadLine());
                
                if (UserChoice == 1)
                {
                    int MaxValue1 = 0;
                    int MaxValue2 = 0;
                    for (int i = 0; i < myArray.Length; i++)
                    {
                        
                        if (MaxValue1 < myArray[i])
                        {
                            MaxValue2 = MaxValue1;
                            MaxValue1 = myArray[i];

                        }
                        if (MaxValue2 < myArray[i] && MaxValue1 != myArray[i])
                        {
                            MaxValue2 = myArray[i];
                        }
                        
                    }
                    Console.WriteLine(MaxValue1);
                    Console.WriteLine(MaxValue2);
                    break;
                }
                if (UserChoice == 2)
                {
                    for (int i = 0; i < myArray.Length; i++)
                    {
                        
                        for (int j = i+1; j < myArray.Length; j++)
                        {
                            if (myArray[i] == myArray[j])
                            {
                                Console.WriteLine("\n"+myArray[i]);
                                Console.WriteLine("\n" + myArray[j]);
                            }
                        }
                    }
                    break;
                }
                if (UserChoice == 3)
                {
                    Console.WriteLine("Введите кол-во элементов в массиве");
                    int elementCount = int.Parse(Console.ReadLine());
                    int[] Array = new int[elementCount];
                    Random rnd = new Random();
                    
                    for (int i = 0; i < Array.Length; i++)
                    {
                        int r = rnd.Next(1, 10);
                        Array[i] = r;
                        Console.WriteLine("\n"+r);
                        
                    }
                    
                    break;
                }
                else
                {
                    Console.WriteLine("Вы не выбрали способ , повторите еще раз");
                }
            } while (UserChoice != 1 || UserChoice != 2  || UserChoice != 3);
            
            Console.ReadKey();
        }
    }
}