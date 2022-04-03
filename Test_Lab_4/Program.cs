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
                String now_password = "Ответ";
                return now_password;
            }

        }
        static void Main(string[] args)
        {
            leader now_leader = new leader(4);
        }
    }
}
