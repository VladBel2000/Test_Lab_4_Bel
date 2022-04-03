using System;
using System.Linq;

namespace Test_Lab_4
{
    class Program
    {
        class leader
        {
            String answer;
            int count_users;

            public leader()
            {
                answer = generate_answer();

                //Создание объекта для генерации чисел
                Random rnd = new Random();

                //Получить случайное число (в диапазоне от 0 до 10)
                int p_count_users = rnd.Next(2, 4);
                count_users = p_count_users;
            }

            public String get_answer() 
            {
                return answer;
            }

            public string generate_answer()
            {
                //Создание объекта для генерации чисел
                Random rnd = new Random();

                //Получить случайное число (в диапазоне от 0 до 10)
                int value = rnd.Next(4, 10);

                String now_password = RandomString(value);
                return now_password;
            }
            public string RandomString(int length)
            {
                Random rnd = new Random();
                const string chars = "аеёиоуыэюябвгджзйклмнпрстфхцчшщ)";
                return new string(Enumerable.Repeat(chars, length)
                  .Select(s => s[rnd.Next(s.Length)]).ToArray());
            }

        }
        static void Main(string[] args)
        {
            leader now_leader = new leader();
            Console.WriteLine(now_leader.get_answer());
        }
    }
}
