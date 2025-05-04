namespace POOBoletos
{
    internal class VentaCredito : Ventas
    {
        public override decimal CalcularTotal() 
        {
            decimal incremento = 1.05m;
            decimal total = base.CalcularTotal();
            decimal totalConIncremento = total * incremento;
            return totalConIncremento;
        }
    }
}
