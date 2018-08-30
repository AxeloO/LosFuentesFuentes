using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EN;

namespace BL
{
    public class CuentasPorPagarBL
    {
        CuentasPorPagarDal _CuentasDal = new CuentasPorPagarDal();//Creacion de instancia Dal
        EnCuentasPorPagar _enCuentas = new EnCuentasPorPagar();//Creacion de la instancia EN

        public int AgregarCuentasPorPagar(EnCuentasPorPagar _enCuentas)
        {
            return _CuentasDal.AgregarCuentasPorPagar(_enCuentas);
        }
        public List<EnCuentasPorPagar> MostrarCuentasPorPagar()
        {
            return _CuentasDal.MostrarEnCuentasPorPagar();
        }
        public List<EnCuentasPorPagar> MostrarCuentasPorNombre(EnCuentasPorPagar _enCuentas)
        {
            return _CuentasDal.MostrarEnCuentaPorNombre(_enCuentas);
        }
        public int ModificarCuentas(EnCuentasPorPagar _enCuentas)
        {
            return _CuentasDal.ModificarCuenta(_enCuentas);
        }
        public int EliminarCuentas(EnCuentasPorPagar _enCuentas)
        {
            return _CuentasDal.EliminarCuenta(_enCuentas);
        }
    }

}

