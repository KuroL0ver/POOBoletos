namespace POOBoletos
{
    public partial class FrmVenta : Form
    {
        private Ventas _venta;
        private readonly Dictionary<string, decimal> preciosBoletos = new Dictionary<string, decimal>
        {
            { "VIP", 1550m },
            { "General", 500m },
            { "Estudiantes", 430m }
        };
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

            if (!int.TryParse(TxtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida.");
                return;
            }

            if (!decimal.TryParse(TxtValorUnitario.Text, out decimal valorUnitario) || valorUnitario <= 0)
            {
                MessageBox.Show("Por favor, ingrese un valor unitario válido.");
                return;
            }

            if (cBxBoletos.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un tipo de boleto.");
                return;
            }

            // Crear un nuevo concepto de venta
            ConceptoDeVenta concepto = new ConceptoDeVenta
            {
                Cantidad = cantidad,
                ValorUnitario = valorUnitario,
                TipoBoleto = cBxBoletos.SelectedItem.ToString()
            };

            _venta.Conceptos.Add(concepto);

            // Actualizar el DataGridView
            DgvConceptos.DataSource = _venta.Conceptos;

            // Configurar encabezados de las columnas
            DgvConceptos.Columns["Cantidad"].HeaderText = "Cantidad";
            DgvConceptos.Columns["ValorUnitario"].HeaderText = "Valor Unitario";
            DgvConceptos.Columns["Importe"].HeaderText = "Importe";
            DgvConceptos.Columns["TipoBoleto"].HeaderText = "Tipo de Boleto";
            DgvConceptos.Columns["NumeroBoleto"].HeaderText = "Número de Boleto";

            // Limpiar campos
            TxtCantidad.Text = string.Empty;
            TxtValorUnitario.Text = string.Empty;
            TxtTotal.Text = _venta.Total.ToString("0.00");
            cBxBoletos.SelectedIndex = -1;
            TxtCantidad.Focus();
        }

        private void cBxBoletos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBxBoletos.SelectedItem != null)
            {
                string tipoBoleto = cBxBoletos.SelectedItem.ToString();
                if (preciosBoletos.TryGetValue(tipoBoleto, out decimal precio))
                {
                    TxtValorUnitario.Text = precio.ToString("0.00");
                }
                else
                {
                    TxtValorUnitario.Text = "0.00"; // Valor por defecto si no se encuentra el tipo
                }
            }
        }
    }
}
