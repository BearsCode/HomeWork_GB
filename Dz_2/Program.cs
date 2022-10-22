// Задача 10
// Напишите про  грамму, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа internal class Program

                                                                                           
using System;                                                                              
                                                                                           
namespace ConsoleApplication1                                                              
                                                                                           
{                                                                                          
                                                                                           
    int ReturnSecondDigit(int number)                                                      
    {                                                                                      
        int lastTwoDigits = number / 10;                                                   
                                                                                           
#if true
	 
#endif       int secondDigit = lastTwoDigits % 10;                                              
                                                                                           
        return secondDigit;                                                                
    }                                                                                      
                                                                                           
    Console.Write("Enter three-digit number: ");                                           
    int input = Convert.ToInt32(Console.ReadLine());                                       
    int result = ReturnSecondDigit(input);                                                 
                                                                                           
    Console.WriteLine($"Second digit of {input} is {result}");                             
                                                                                           
                                                                                           
}                                                                                          
                                                                                           
                                                                                           