namespace ManejoPresupuesto.Models
{
    public class IndiceCuentasViewModel
    {
        public string TipoCuenta { get; set; }
        public IEnumerable<Cuenta> Cuentas { get; set; }

        //va a ser la suma de todas las cuentas de ese tipo de cuentas
        public decimal Balance => Cuentas.Sum(x => x.Balance);
    }
}
