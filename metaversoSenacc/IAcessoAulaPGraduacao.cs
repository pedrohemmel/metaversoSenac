using System;
using System.Collections.Generic;
using System.Text;

namespace metaversoSenacc
{
    //Criando interface que vai permitir que a classe possa ser alocada como parãmetro das aulas da Pós Graduação
    interface IAcessoAulaPGraduacao
    {
        string Name { get; }
    }
}
