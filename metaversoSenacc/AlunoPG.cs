using System;
using System.Collections.Generic;
using System.Text;

namespace metaversoSenacc
{
    //Adicionando a classe pai e a interface que permite ser alocado no parâmetro da função da classe AulaPG
    class AlunoPG : Aluno, IAcessoAulaPGraduacao
    {
        //Adicionando o construtor da classe com a base da classe pai Aluno
        public AlunoPG(string name) : base(name)
        {
        }
    }
}
