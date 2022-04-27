using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metaversoSenacc
{
    //Criando interface que vai permitir que a classe possa ser alocada como parãmetro das aulas da Graduação
    interface IAcessoAulaGraduacao
    {

        string Name { get; }
    }
}
