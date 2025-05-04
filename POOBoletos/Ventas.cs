namespace POOBoletos
{
    internal class Ventas
    {
        public decimal Total
        {
            get
            {
                return CalcularTotal();
            }
        }

        public List<ConceptoDeVenta> Conceptos { get; set; } = new List<ConceptoDeVenta>();

        // Changed DgvConceptos from object to DataGridView to fix CS1061 error  
        public System.Windows.Forms.DataGridView DgvConceptos { get; private set; }

        public virtual decimal CalcularTotal()
        {
            decimal total = 0.00m;
            foreach (ConceptoDeVenta concepto in Conceptos)
            {
                total += concepto.Importe;
            }

            // Ensure DgvConceptos is not null before accessing its properties  
            if (DgvConceptos != null && DgvConceptos.Columns.Contains("TipoBoleto"))
            {
                DgvConceptos.Columns["TipoBoleto"].HeaderText = "Tipo de Boleto";
            }

            return total;
        }
    }
}
