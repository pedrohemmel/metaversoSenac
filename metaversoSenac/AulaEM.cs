using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metaversoSenac
{
    class AulaEM : Aula
    {
        public AulaEM(string name, string teacher) : base(name, teacher)
        {
        }


        public override void estudandoPara(Aluno aluno)
        {
            Console.WriteLine("\nO aluno " + aluno.name + " do Ensino Médio, está estudando para passar no vestibular.\n");
        }
    }
}
