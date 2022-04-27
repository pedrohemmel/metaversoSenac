using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metaversoSenacc
{
    //Adicionando a classe pai e a interface que permite ser alocado no parâmetro da função da classe AulaEM
    class AlunoEM : Aluno, IAcessoAulaEnsinoMedio
    {
        //Adicionando o construtor da classe com a base da classe pai Aluno
        public AlunoEM(string name) : base(name)
        {
        }
    }
}
