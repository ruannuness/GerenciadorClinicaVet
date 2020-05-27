using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form13052020
{
    class animal
    {

        private string nomeanimal;
        private string especieanimal;
        private string nomeproprietario;
        private TextBox txb_nomeanimal;
        private TextBox txb_nomeproprietario;
        private TextBox txb_racaanimal;

        public animal (string na, string ea, string np)
        {

            nomeanimal = na;
            nomeproprietario = np;
            especieanimal = ea;

        }

    }


}
