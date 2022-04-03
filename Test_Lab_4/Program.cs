using System;
using System.Linq;

namespace Test_Lab_4
{
    class Program
    {
        class leader
        {
            String answer;
            String now_answer;
            int count_users;
            int now_user;

            public leader()
            {
                answer = generate_answer();
                answer = "папа";

                now_answer = generate_now_answer(answer.Length);

                //Создание объекта для генерации чисел
                Random rnd = new Random();

                //Получить случайное число (в диапазоне от 0 до 10)
                int p_count_users = rnd.Next(2, 4);
                count_users = p_count_users;
                now_user = 0;
            }

            public String get_answer() 
            {
                return answer;
            }
            public int get_now_user()
            {
                if (now_user == count_users)
                    now_user = 1;
                else
                    now_user++;
                return now_user;
            }
            public bool check_answer()
            {
                if (answer == now_answer)
                    return true;
                else
                    return false;
            }


            public string generate_now_answer(int count_char)
            {
                return new String('*', count_char);
            }

            public String get_now_answer()
            {
                return now_answer;
            }

            public void check_now_answer(String vvod)
            {
                for(int i = 0; i < answer.Length; i++)
                {
                    if (answer[i] == Convert.ToChar(vvod))
                    {
                        string help = now_answer;
                        char[] chars = help.ToCharArray();
                        chars[i] = answer[i];
                        help = new string(chars);
                        now_answer = help;
                    }
                }
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

            while (now_leader.check_answer() == false)
            {
                Console.WriteLine("Загаданное слово: " + now_leader.get_now_answer());
                Console.Write("Игрок №" + now_leader.get_now_user() + ", введите букву:");
                String vvod_char = Console.ReadLine();
                now_leader.check_now_answer(vvod_char);
            }
            Console.WriteLine("Загаданное слово: " + now_leader.get_now_answer());
            Console.WriteLine("Игра завершена");
        }
    }
}
