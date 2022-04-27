using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metaversoSenac
{
    class Aluno
    {
        public String name { get; private set; }

        public Aluno(String name)
        {
            this.name = name;
        }

        public void estudando()
        {
            Console.WriteLine("\nO aluno " + this.name + " está estudando.\n");
        }
    }
}
