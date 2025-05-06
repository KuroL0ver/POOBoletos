namespace POOBoletos
{
    class ConceptoDeVenta
    {
        public int Cantidad { get; set; }

        private static int _contadorBoletos = 1;
        public int NumeroBoleto { get;  private set; }
        public decimal ValorUnitario { get; set; }
        public string TipoBoleto { get; set; } 
        public decimal Importe
        {
            get
            {
                return CalcularImporte();
            }
        }

        private decimal CalcularImporte()
        {
            return Cantidad * ValorUnitario;
        }
        public ConceptoDeVenta() 
        {
            NumeroBoleto = _contadorBoletos;
        }
    }
}
