using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandSetName = "1";
            const string CommandChangeConsoleColor = "2";
            const string CommandSetPassword = "3";
            const string CommandWriteName = "4";
            const string CommandEsc = "5";
            const string CommandDateBirth = "6";
            const string CommandEnterNumber = "7";
            const string CommandEnterAmountMoney = "8";
            const string CommandShowAmountMoneySafe = "9";

            string password;
            string userName = "";
            string userPassword = "";
            bool canExamination = true;
            int enterAmountMoney = 0;
            string userInput;

            Console.WriteLine(" Выберите одну из следующих команд ");

            while (canExamination)
            {
                Console.WriteLine(CommandSetName + " - установить имя ");
                Console.WriteLine(CommandChangeConsoleColor + " - изменить цвет консоли ");
                Console.WriteLine(CommandSetPassword + " - установить пароль ");
                Console.WriteLine(CommandWriteName + " - вывести имя, после ввода пароля ");
                Console.WriteLine(CommandEsc + " - выход из программы ");
                Console.WriteLine(CommandDateBirth + " - установите дату рождения ");
                Console.WriteLine(CommandEnterNumber + " - введите число ");
                Console.WriteLine(CommandEnterAmountMoney + " - введите количество денег ");
                Console.WriteLine(CommandShowAmountMoneySafe + " - показать количество денег в сейфе ");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case CommandEsc:
                        canExamination = false;
                        break;

                    case CommandSetName:
                        Console.WriteLine(" Введите ваше имя ");
                        userName = Console.ReadLine();
                        break;

                    case CommandSetPassword:
                        Console.WriteLine(" Введите любой пароль ");
                        userPassword = Console.ReadLine();
                        break;

                    case CommandWriteName:
                        Console.WriteLine(" Введите пароль ");
                        password = Console.ReadLine();

                        if (userPassword == password)
                        {
                            Console.WriteLine(" Ваше имя - " + userName);
                        }
                        else
                        {
                            Console.WriteLine(" Неверный пароль ");
                        }
                        break;

                    case CommandDateBirth:
                        string dateBirth;

                        Console.WriteLine(" Введите дату рождения ");
                        dateBirth = Console.ReadLine();
                        break;

                    case CommandEnterNumber:
                        int userNumber;

                        Console.WriteLine(" Введите любое число ");
                        userNumber = Convert.ToInt32(Console.ReadLine());
                        break;

                    case CommandEnterAmountMoney:
                        Console.WriteLine(" Введите любое количество денег ");
                        enterAmountMoney = Convert.ToInt32(Console.ReadLine());
                        break;

                    case CommandShowAmountMoneySafe:
                        Console.WriteLine(" У вас денег в сейфе " + enterAmountMoney + " рублей ");
                        break;

                    case CommandChangeConsoleColor:
                        int consoleColor;
                        int colorNumber = 15;
                        int colorNumber2 = 1;

                        Console.WriteLine(" Выберите цвет консоли от " + colorNumber2 + " до " + colorNumber);
                        consoleColor = Convert.ToInt32(Console.ReadLine());

                        if (consoleColor > colorNumber || consoleColor <= colorNumber2)
                        {
                            Console.WriteLine(" Такого цвета нету ");
                        }
                        else
                        {
                            Console.ForegroundColor = (ConsoleColor)consoleColor;
                        }
                        break;

                    default:
                        Console.WriteLine(" Вы ввели неверную команду ");
                        break;
                }
            }
        }
    }
}