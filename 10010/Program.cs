using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10010
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Trainer
    {
        private string name;
        private int wid;
    }
    public class Training
    {
        private int num;
    }

    public class SpecialT : Training
    {
        private Trainer trainer; //note that num is inherited
        int time;

        public int GetTime()
        { return time; }
    }

    public class Client
    {
        private int id;
        private string name;
        private Training[] visits;

        public int SumSpecialTime()
        {
            int st = 0;
            for (int i = 0; i < visits.Length; i++)
            {
                if (visits[i] != null && visits[i] is SpecialT)
                    st += ((SpecialT)visits[i]).GetTime();
            }
            return st;
        }

        public class Management
        {
            private Trainer[] staff;
            private Client[] clients;

            public int AtLeastOneSpecial()
            {
                int count = 0;
                foreach (Client client in clients)
                    if (client != null && client.SumSpecialTime() > 0) count++;
                return count;
            }
        }
    }
}
