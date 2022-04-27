using System;
using System.Collections.Generic;
using System.Text;

namespace metaversoSenacc
{
    //Criando classe que vai poder ter acesso as aulas do Ensino Médio com base na interface
    class MinisterioEducacao : IAcessoAulaEnsinoMedio
    {
        public string Name { get; private set; }

        //Adicionando construtor para a classe
        public MinisterioEducacao(string name)
        {
            this.Name = name;
        }
    }
}
