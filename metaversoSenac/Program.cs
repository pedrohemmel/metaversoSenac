using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metaversoSenac
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            AlunoEM pedro = new AlunoEM("Pedro Henrique");
            AlunoEM rafael = new AlunoEM("Rafael Ribeiro");
            AlunoG arthur = new AlunoG("Arthur Ferreira");
            AulaEM filosofia = new AulaEM("Filosofia", "Laercio");
            AulaG algebraLinear = new AulaG("Algebra Linear", "Ranulfo");

            filosofia.assistirAula(pedro);

            algebraLinear.estudandoPara(arthur);

            filosofia.estudandoPara(rafael);
        }
    }
}
