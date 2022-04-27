using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metaversoSenacc
{
    //Criando uma classe abstrata para servir só de herança para as classes filhos
    abstract class Aula
    {
        public String teacher { get; private set; }

        public string Name { get; private set; }

        //Adicionando o construtor da classe
        public Aula(String name, String teacher)
        {
            this.Name = name;
            this.teacher = teacher;
        }

    }
}
