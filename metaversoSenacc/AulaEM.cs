using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metaversoSenacc
{
    //Adicionando a classe pai
    class AulaEM : Aula
    {
        //Adicionando o construtor da classe com a base da classe pai Aula
        public AulaEM(string name, string teacher) : base(name, teacher)
        {
        }

        //Criando função que vai utilizar como parâmetro a classe aluno com a interface IAcessoAulaEnsinoMedio em específico
        public void estudandoPara(IAcessoAulaEnsinoMedio aluno)
        {
            Console.WriteLine("\nO aluno " + aluno.Name + " do Ensino Médio, está estudando para passar no vestibular.\n");
        }
    }
}
