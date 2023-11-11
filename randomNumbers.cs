using System;

namespace shambalaWpfWorkReestr_11_11_2023
{
    // класс для создания случайного числа
    public class randomNumbers
    {
        // поле для ввода числа пользователем
        private int numUser;
        // поле для генерации случайного числа
        private int numRand;
        // конструктор без параметров
        public randomNumbers()
        {
            numUser = 0;
            numRand = 0;
        }
        // конструктор с параметрами
        public randomNumbers(int num, int numrand)
        {
            this.numUser = num;
            this.numRand = numrand;
        }
        // генератор случайного числа
        public int getRand(int num) 
        {
            Random random = new Random();
            int numrand = random.Next(num);
            return numrand;
        }
    }
}
