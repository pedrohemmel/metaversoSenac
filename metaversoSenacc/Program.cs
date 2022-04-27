using System;

namespace metaversoSenacc
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando as classes dos alunos
            AlunoEM pedro = new AlunoEM("Pedro Henrique");
            AlunoG rafael = new AlunoG("Rafael Ribeiro");
            AlunoPG bruno = new AlunoPG("Bruno Lafayette");

            //Instanciando as classes das aulas
            AulaEM filosofia = new AulaEM("Filosofia", "Gerson");
            AulaG algebraLinear = new AulaG("Algebra Linear", "Ranulfo");
            AulaPG teoriaComputacao = new AulaPG("Teoria da Computação", "Leonardo Takuna");

            //Instanciando as classes do MEC e do MinisterioEducacao
            MEC gilson = new MEC("Gilson MEC");
            MinisterioEducacao alberto = new MinisterioEducacao("Alberto Min. Educação");

            //Chamando as funções para testes
            filosofia.estudandoPara(pedro);
            filosofia.estudandoPara(alberto);

            algebraLinear.estudandoPara(rafael);
            algebraLinear.estudandoPara(gilson);

            teoriaComputacao.estudandoPara(bruno);
            teoriaComputacao.estudandoPara(gilson);
        }
    }
}
