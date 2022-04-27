using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metaversoSenac
{
    interface AcessoAula
    {

        string Name { get; }

        void assistirAula(Aluno aluno);
    }
}
