using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metaversoSenac
{
    abstract class Aula : AcessoAula
    {
        public String teacher { get; private set; }

        public string Name { get; private set; }

        public Aula(String name, String teacher)
        {
            this.Name = name;
            this.teacher = teacher;
        }

        public void assistirAula(Aluno aluno)
        {
            Console.WriteLine("O aluno " + aluno.name + " está assistindo a aula de " + this.Name + " do(a) professor(a) " + this.teacher);
        }

        public abstract void estudandoPara(Aluno aluno);
    }
}
