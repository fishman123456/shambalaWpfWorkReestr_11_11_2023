using System;
using System.Timers;
using System.Windows;

namespace shambalaWpfWorkReestr_11_11_2023
{
    public  class userTimer
    {
        //Шаг 1: Импорт библиотеки
        //Первым шагом в создании таймера является импорт необходимых библиотек в ваш проект.
        //Вам понадобится библиотека System.Timers, чтобы создать таймер.
        public static void TimeUser()
        {
            //Шаг 2: Создайте экземпляр таймера
            Timer timer = new Timer();
            //Шаг 3: Установите интервал и обработчик событий
            timer.Interval = 5000;
            timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            timer.Enabled = true;
        }
        // Шаг 4: Создайте метод обработки события
        public static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            MessageBox.Show("Прошло 5 секунд");
            
        }
    }
}

//Шаг 5: Запустите таймер
//После установки интервала и обработчика событий, вы готовы запустить таймер.
//timer.Enabled = true;
//Шаг 6: Остановите таймер
//Вы можете остановить таймер в любое время, установив его свойство Enabled в значение false.
//timer.Enabled = false;
//Шаг 7: Проверьте состояние таймера
//Вы можете проверить состояние таймера, установив свойство AutoReset в значение true.
//Это означает, что таймер будет продолжать запускать код через указанный интервал времени, если не установлено свойство Enabled в значение false.
//timer.AutoReset = true;
//Шаг 8: Освободите ресурсы
//Не забудьте освободить ресурсы, занятые таймером, когда он больше не нужен.
//timer.Dispose();
//Пример
//Приведенный ниже пример демонстрирует, как создать таймер, который будет выводить сообщение каждые 5 секунд.
//using System;
//using System.Timers;
//class Program
//{
//    static void Main(string[] args)
//    {
//        Timer timer = new Timer();
//        timer.Interval = 5000;
//        timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
//        timer.Enabled = true;
//        Console.WriteLine("Нажмите клавишу \'q\' для выхода.");
//        while (Console.Read() != 'q') ;
//    }

//    private static void OnTimedEvent(object source, ElapsedEventArgs e)
//    {
//        Console.WriteLine("Прошло 5 секунд");
//    }
//}

//Вывод:
//Прошло 5 секунд
//Прошло 5 секунд
//Прошло 5 секунд
//Заключение
//Таймеры в C# — это мощный инструмент, который может быть использован для широкого спектра задач.
//Важно знать, как создать таймер в C# и установить его интервал и обработчик событий.
//Следуя описанным выше шагам и примеру, вы можете быть уверены, что будете использовать таймеры правильно в вашем проекте C#.