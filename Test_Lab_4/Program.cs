using System;

namespace Test_Lab_4
{
    class Program
    {
        class leader
        {
            String answer;
            int count_users;

            public leader(int p_count_users)
            {
                answer = generate_answer();
                count_users = p_count_users;
            }
            public string generate_answer()
            {
                //Создание объекта для генерации чисел
                Random rnd = new Random();
                //Получить случайное число (в диапазоне от 0 до 12)
                int value = rnd.Next(4, 10);

                String now_password = "Ответ";
                return now_password;
            }
            public string RandomString(int length)
            {
                var result = new char[length];
                var r = new Random();
                for (int i = 0; i < result.Length; i++)
                {
                    do
                        result[i] = (char)r.Next(127);
                    while (result[i] < '!');
                }
                return new string(result);
            }

        }
        static void Main(string[] args)
        {
            leader now_leader = new leader(4);
        }
    }
}
