using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace validacija
{
    enum PrivilagLevel{ Standard, Premium, Executive, PremierExecutive}
    internal class nakupkarte
    {
        private string imedogodka;
        private string štkupca;
        private PrivilagLevel nivo;
        private int štVstopnic;
        public bool preveriŠtVstopnic(PrivilagLevel p, int š)
        {
            bool vrni = false;
            switch (p)
            {
                case PrivilagLevel.Standard:
                    vrni = š <= 2;
                    break;
                case PrivilagLevel.Premium:
                    vrni = š <= 4;
                    break;
                case PrivilagLevel.Executive:
                    vrni = š <= 8;
                    break;
                case PrivilagLevel.PremierExecutive:
                    vrni = š <= 10;
                    break;
            }
            return vrni;
        }

        public string Imedogodka
        {
            get => imedogodka;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new Exception("Obvezen podatek");
                imedogodka = value;
            }
        }

        public string Štkupca
        {
            get => štkupca;
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Št. kupca je obvezna");
                štkupca = value;

            }
        }

        public int ŠtVstopnic
        {
            get => štVstopnic;
            set
            {
                if (!preveriŠtVstopnic(nivo, value))
                    throw new Exception("Napačno število za ta status");
                štVstopnic = value;
            }
        }

        public PrivilagLevel Nivo 
        { 
            get => nivo;
            set
            {
                if (!preveriŠtVstopnic(value, štVstopnic))
                    throw new Exception("Napačno število za ta status");
                nivo = value;
            }
        }
    }
}
