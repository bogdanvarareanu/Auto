using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class CAuto
    {
        private int Geschwindigkeit;
        private int Ladung;
        private int Tankinhalt;
        
        public void set_Geschwindigkeit(int G)
        { if (G > 0&&G<=150)
                Geschwindigkeit = G;
            
        }
        public int get_Geschwindigkeit() { return Geschwindigkeit; }
        public void set_Tankinhalt(int T)
        {
            if (T >= 0 && T <= 100)
                Tankinhalt = T;
        }
        public int get_Tankinhalt() { return Tankinhalt; }

        public void set_Ladung(int L)
        {
            if (L <= 250)
                Ladung = L;

        }
        public int get_Ladung() { return Ladung; }

        public bool fahren(int lang)
        {
            
                if (Ladung > 250)
                    return false;
            else 
            {
                if (Geschwindigkeit == 0)
                    return false;
                else
                {
                    if (Tankinhalt >= (lang+(Geschwindigkeit/10)+(Ladung/10)))
                    {
                        Tankinhalt = Tankinhalt - (lang + (Geschwindigkeit / 10) + (Ladung / 10));
                        return true;
                    }
                    else
                    {
                        Tankinhalt = 0;
                        return false;
                    }
                }
            }
        }


    }
}
