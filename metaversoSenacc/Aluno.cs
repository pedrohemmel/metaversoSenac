using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metaversoSenacc
{   
    //Criando uma classe abstrata para servir só de herança para as classes filhos
    abstract class Aluno
    {
        public String Name { get; private set; }

        //Adicionando o construtor da classe
        public Aluno(String name)
        {
            this.Name = name;
        }

    }
}
