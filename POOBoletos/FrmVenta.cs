namespace POOBoletos
{
    public partial class FrmVenta : Form
    {
        private Ventas _venta;
        public FrmVenta(string tipoVenta)
        {
            InitializeComponent();

            if (tipoVenta == "credito")
            {
                _venta = new VentaCredito();
                this.Text = "Venta de Credito";
                TxtCortesia.Text = "No";
                btnTarjeta.Visible = false;
                btnEfectivo.Visible = false;
            }
            else if (tipoVenta == "contado")
            {
                _venta = new VentaContado();
                this.Text = "Venta de Contado";
                TxtCortesia.Text = "No";
                btnTarjeta.Visible = true;
                btnEfectivo.Visible = true;
            }
            else
            {
                _venta = new VentaCortesia();
                this.Text = "Venta de Cortesia";
                TxtCortesia.Text = "Sí";
                btnTarjeta.Visible = false;
                btnEfectivo.Visible = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void DgvConceptos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {

        }

        private void TxtValorUnitario_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTarjeta_Click(object sender, EventArgs e)
        {
            FormaPagoTarjeta tarjeta = new FormaPagoTarjeta();
            AplicarPago(tarjeta);
        }

        private void btnEfectivo_Click(object sender, EventArgs e)
        {
            FormaPagoEfectivo efectivo = new FormaPagoEfectivo();
            AplicarPago(efectivo);
        }

        void AplicarPago(IFormaPago formaPago)
        {
            formaPago.Cobrar(_venta.Total);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DgvConceptos.DataSource = null;

            ConceptoDeVenta concepto = new ConceptoDeVenta();
            concepto.Cantidad = Convert.ToInt32(TxtCantidad.Text);
            concepto.ValorUnitario = Convert.ToDecimal(TxtValorUnitario.Text);
            concepto.TipoBoleto = cBxBoletos.SelectedItem?.ToString(); // Captura el tipo de boleto
            _venta.Conceptos.Add(concepto);

            DgvConceptos.DataSource = _venta.Conceptos;

            // Configurar encabezados de las columnas
            DgvConceptos.Columns["Cantidad"].HeaderText = "Cantidad";
            DgvConceptos.Columns["ValorUnitario"].HeaderText = "Valor Unitario";
            DgvConceptos.Columns["Importe"].HeaderText = "Importe";
            DgvConceptos.Columns["TipoBoleto"].HeaderText = "Tipo de Boleto"; // Configura el encabezado

            TxtCantidad.Text = string.Empty;
            TxtValorUnitario.Text = string.Empty;
            TxtTotal.Text = _venta.Total.ToString("0.00");
            cBxBoletos.SelectedIndex = -1; // Reinicia el ComboBox
            TxtCantidad.Focus();
        }

        private void cBxBoletos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
