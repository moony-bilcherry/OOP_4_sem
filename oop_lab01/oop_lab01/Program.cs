using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Приложение «Арифметико-мультипликативный калькулятор для целых»
Сложение, вычитание, деление, умножение получение остатка от
деления, получение целой части деления, очистка. Добавьте
операции хранения и извлечения значения в памяти*/

namespace oop_lab01
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
