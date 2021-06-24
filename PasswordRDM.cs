using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PasswordRandomizer
{
    class PasswordRDM
    {
        private Random RdmMdp;
        private List<char> cLstCarRDM;
        private List<char> cLstMajRDM;
        private List<char> cLstNumRDM;
        private List<char> cLstMDP;
        private char[] cTabTmp;
        private char[] cTabReturn;

        public PasswordRDM()
        {
            GenererMdp();
        }

        public string GenererMdp()
        {
            int i2;
            string sMdp = "";
            cLstMDP = new List<char>(26);
            for (int i = 0; i < 3; i++)
            {
                GenererRDM();
                for ( i2 = 0; i2 < cTabReturn.Length; i2++)
                {
                   cLstMDP.Add(cTabReturn[i2]);
                }
            }

            for (int i = 0; i < cLstMDP.Count; i++)
            {
                if (i == 8 || i == 16)
                {
                    sMdp += '-' + cLstMDP[i].ToString();
                }
                else
                {
                    sMdp += cLstMDP[i].ToString();
                }
            }

            return sMdp;
           
        }

        private void GenererRDM()
        {
            RdmMdp = new Random();
            GenererCarRandom();
            GenererMajRandom();
            GenererNumRandom();

            
            cTabTmp = new char[8];
            cTabReturn = new char[8];

            Random rdmNbre = new Random();
            for (int i = 0; i < cTabTmp.Length; i++)
            {
                int iNbre = rdmNbre.Next(1, 4);

                if (iNbre == 1)
                {
                    cTabTmp[i] = cLstCarRDM[rdmNbre.Next(25)];
                }
                else if (iNbre == 2)
                {
                    cTabTmp[i] = cLstMajRDM[rdmNbre.Next(25)];
                }
                else
                {
                    cTabTmp[i] = cLstNumRDM[rdmNbre.Next(10)];
                }
                cTabReturn[i] = cTabTmp[i];
            }
        }

        private void GenererCarRandom()
        {
            
            List<char> cTabCar = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            cLstCarRDM = new List<char>(cTabCar.Count);
            char[] Tab = new char[cTabCar.Count];

            
            for (int i = 0; i < Tab.Length; i++)
            {
                int iNbre = RdmMdp.Next(cTabCar.Count);
                Tab[i] = cTabCar[iNbre];
                cLstCarRDM.Add(Tab[i]);
                cTabCar.RemoveAt(iNbre);
            }
        }

        private void GenererMajRandom()
        {
            List<char> cTabCar = new List<char>() { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            cLstMajRDM = new List<char>(cTabCar.Count);
            char[] Tab = new char[cTabCar.Count];


            for (int i = 0; i < Tab.Length; i++)
            {
                int iNbre = RdmMdp.Next(cTabCar.Count);
                Tab[i] = cTabCar[iNbre];
                cLstMajRDM.Add(Tab[i]);
                cTabCar.RemoveAt(iNbre);
            }
        }

        private void GenererNumRandom()
        {
            List<char> cTabCar = new List<char>() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
            cLstNumRDM = new List<char>(cTabCar.Count);
            char[] Tab = new char[cTabCar.Count];


            for (int i = 0; i < Tab.Length; i++)
            {
                int iNbre = RdmMdp.Next(cTabCar.Count);
                Tab[i] = cTabCar[iNbre];
                cLstNumRDM.Add(Tab[i]);
                cTabCar.RemoveAt(iNbre);
            }
        }
    }

}
