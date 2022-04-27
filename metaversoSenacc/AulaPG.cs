using System;
using System.Collections.Generic;
using System.Text;

namespace metaversoSenacc
{
    //Adicionando a classe pai
    class AulaPG : Aula, IAcessoAulaPGraduacao
    {
        //Adicionando o construtor da classe com a base da classe pai Aula
        public AulaPG(string name, string teacher) : base(name, teacher)
        {
        }

        //Criando função que vai utilizar como parâmetro a classe aluno com a interface IAcessoAulaPGraduacao em específico
        public void estudandoPara(IAcessoAulaPGraduacao aluno)
        {
            Console.WriteLine("\nO aluno " + aluno.Name + " da Pós Graduação, está estudando para arrumar um emprego.\n");
        }
    }
}
