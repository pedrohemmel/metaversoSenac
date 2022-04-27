using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metaversoSenac
{
    class AulaG : Aula
    {
        public AulaG(string name, string teacher) : base(name, teacher)
        {
        }

        public override void estudandoPara(Aluno aluno)
        {
            Console.WriteLine("\nO aluno " + aluno.name + " da Graduação, está estudando para arrumar um emprego.\n");
        }
    }
}
