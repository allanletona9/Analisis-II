using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polideportivo_Administrativo
{
    class Validar
    {
        public static void soloNumeros(KeyPressEventArgs V)
        {
            if(Char.IsDigit(V.KeyChar))
            {
                V.Handled = false;
            }
            else if(Char.IsSeparator(V.KeyChar))
            {
                V.Handled = false;
            }
            else if(Char.IsControl(V.KeyChar))
            {
                V.Handled = false;
            }
            else
            {
                V.Handled = true;
            }
        }
    }
}
