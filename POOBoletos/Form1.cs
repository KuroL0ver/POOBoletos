namespace POOBoletos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVentaContado_Click(object sender, EventArgs e)
        {
            FrmVenta frmVenta = new FrmVenta("contado");
            frmVenta.ShowDialog();
        }

        private void btnCortesia_Click(object sender, EventArgs e)
        {
            FrmVenta frmVenta = new FrmVenta("cortesia");
            frmVenta.ShowDialog();

        }

        private void btnVentaCredito_Click(object sender, EventArgs e)
        {
            FrmVenta frmVenta = new FrmVenta("credito");
            frmVenta.ShowDialog();
        }
    }
}
