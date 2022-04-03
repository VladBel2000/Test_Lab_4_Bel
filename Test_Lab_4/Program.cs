using System;

namespace Test_Lab_4
{
    class Program
    {
        class leader
        {
            String answer;
            int count_users;

            public leader(String p_answer, int p_count_users)
            {
                answer = p_answer;
                count_users = p_count_users;
            }

        }
        static void Main(string[] args)
        {
            leader now_leader = new leader("Ответ", 4);
        }
    }
}
