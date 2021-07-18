using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class GerenciadorLatidos
    {
        private int _intensidadedoLatido;
        public delegate void ExcessoDecibeisHandler(object sender, EventArgs e);
        public event ExcessoDecibeisHandler ExcessoDecibeisEvent;

        public event EventHandler ExcessoDecibeisAcimaNoventa;


        public GerenciadorLatidos()
        {
            _intensidadedoLatido = 0;

        }


        public int Latir()
        {
            _intensidadedoLatido += 10;
            ExcessoDecibeisEventArgs e = new ExcessoDecibeisEventArgs
            {
                IntensidadeLatido = _intensidadedoLatido
            };
            if (_intensidadedoLatido > 80 && _intensidadedoLatido <= 100)
                            
                onExcessoDecibeis(e);
            else if (_intensidadedoLatido > 100)
                onExcessoDecibeisAcimaNoventa(e);


            return _intensidadedoLatido;
        }

        protected virtual void onExcessoDecibeis(EventArgs e)
        {

            if (ExcessoDecibeisEvent != null)
            {
                ExcessoDecibeisEvent(this, e);
            }
        }


        protected virtual void onExcessoDecibeisAcimaNoventa(EventArgs e)
        {

            if (ExcessoDecibeisAcimaNoventa != null)
            {
                ExcessoDecibeisAcimaNoventa(this, e);
            }
        }
    }
}
