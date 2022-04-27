using System;
using System.Collections.Generic;
using System.Text;

namespace metaversoSenacc
{
    //Criando classe que vai poder ter acesso as aulas da Graduação e Pós Graduação com base nas interfaces
    class MEC : IAcessoAulaGraduacao, IAcessoAulaPGraduacao
    {

        public string Name { get; private set; }

        //Adicionando o construtor para a classe
        public MEC(string name)
        {
            this.Name = name;
        }

    }
}
