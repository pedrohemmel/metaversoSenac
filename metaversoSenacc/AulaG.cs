using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metaversoSenacc
{
    //Adicionando a classe pai
    class AulaG : Aula
    {
        //Adicionando o construtor da classe com a base da classe pai Aula
        public AulaG(string name, string teacher) : base(name, teacher)
        {
        }

        //Criando função que vai utilizar como parâmetro a classe aluno com a interface IAcessoAulaGraduacao em específico
        public void estudandoPara(IAcessoAulaGraduacao aluno)
        {
            Console.WriteLine("\nO aluno " + aluno.Name + " da Graduação, está estudando para arrumar um emprego.\n");
        }
    }
}
