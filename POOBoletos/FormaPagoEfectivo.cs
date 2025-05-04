namespace POOBoletos
{
    internal class FormaPagoEfectivo :IFormaPago
    {
        public void Cobrar(decimal total)
        {
            MessageBox.Show("El total se pagó en efectivo");
        }
    }
}
