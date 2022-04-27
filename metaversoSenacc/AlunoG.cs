using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metaversoSenacc
{
    //Adicionando a classe pai e a interface que permite ser alocado no parâmetro da função da classe AulaG
    class AlunoG : Aluno, IAcessoAulaGraduacao
    {
        //Adicionando o construtor da classe com a base da classe pai Aluno
        public AlunoG(string name) : base(name)
        {
        }
    }
}
