namespace POOBoletos
{
    class ConceptoDeVenta
    {
        public int Cantidad { get; set; }
        public int NumeroBoleto { get; private set; }
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

        public int NumeroBoleto() 
        {
            _contadorBoletos = 1;
            NumeroBoleto = _contadorBoletos++; 
        }
    }
}
