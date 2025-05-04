
namespace POOBoletos
{
    partial class FrmVenta
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAgregar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TxtCantidad = new TextBox();
            TxtValorUnitario = new TextBox();
            DgvConceptos = new DataGridView();
            TxtTotal = new TextBox();
            btnTarjeta = new Button();
            btnEfectivo = new Button();
            label4 = new Label();
            TxtCortesia = new TextBox();
            cBxBoletos = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)DgvConceptos).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(1030, 621);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(159, 72);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 42);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 1;
            label1.Text = "Cantidad";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 121);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 2;
            label2.Text = "Boletos";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(707, 42);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 3;
            label3.Text = "Valor Unitario";
            label3.Click += label3_Click;
            // 
            // TxtCantidad
            // 
            TxtCantidad.Location = new Point(189, 42);
            TxtCantidad.Name = "TxtCantidad";
            TxtCantidad.Size = new Size(125, 27);
            TxtCantidad.TabIndex = 4;
            TxtCantidad.TextChanged += TxtCantidad_TextChanged;
            // 
            // TxtValorUnitario
            // 
            TxtValorUnitario.Location = new Point(840, 35);
            TxtValorUnitario.Name = "TxtValorUnitario";
            TxtValorUnitario.Size = new Size(125, 27);
            TxtValorUnitario.TabIndex = 6;
            TxtValorUnitario.TextChanged += TxtValorUnitario_TextChanged;
            // 
            // DgvConceptos
            // 
            DgvConceptos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvConceptos.Location = new Point(12, 261);
            DgvConceptos.Name = "DgvConceptos";
            DgvConceptos.RowHeadersWidth = 51;
            DgvConceptos.Size = new Size(750, 432);
            DgvConceptos.TabIndex = 7;
            DgvConceptos.CellContentClick += DgvConceptos_CellContentClick;
            // 
            // TxtTotal
            // 
            TxtTotal.Location = new Point(791, 261);
            // TxtTotal.Text = total.ToString("F2");
            TxtTotal.Text = "0.00";
            TxtTotal.Name = "TxtTotal";
            TxtTotal.Size = new Size(125, 27);
            TxtTotal.TabIndex = 8; 
            TxtTotal.TextAlign = HorizontalAlignment.Center;
            TxtTotal.TextChanged += TxtTotal_TextChanged;
            // 
            // btnTarjeta
            // 
            btnTarjeta.Location = new Point(1060, 451);
            btnTarjeta.Name = "btnTarjeta";
            btnTarjeta.Size = new Size(104, 44);
            btnTarjeta.TabIndex = 9;
            btnTarjeta.Text = "Tarjeta";
            btnTarjeta.UseVisualStyleBackColor = true;
            btnTarjeta.Click += btnTarjeta_Click;
            // 
            // btnEfectivo
            // 
            btnEfectivo.Location = new Point(1060, 512);
            btnEfectivo.Name = "btnEfectivo";
            btnEfectivo.Size = new Size(104, 44);
            btnEfectivo.TabIndex = 10;
            btnEfectivo.Text = "Efectivo";
            btnEfectivo.UseVisualStyleBackColor = true;
            btnEfectivo.Click += btnEfectivo_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(707, 121);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 11;
            label4.Text = "V. Cortesía";
            // 
            // TxtCortesia
            // 
            TxtCortesia.Location = new Point(840, 121);
            TxtCortesia.Name = "TxtCortesia";
            TxtCortesia.Size = new Size(125, 27);
            TxtCortesia.TabIndex = 12;
            // 
            // cBxBoletos
            // 
            cBxBoletos.DropDownStyle = ComboBoxStyle.DropDownList;
            cBxBoletos.FormattingEnabled = true;
            cBxBoletos.Items.AddRange(new object[] { "VIP", "Público" });
            cBxBoletos.Location = new Point(189, 120);
            cBxBoletos.Name = "cBxBoletos";
            cBxBoletos.Size = new Size(311, 28);
            cBxBoletos.TabIndex = 13;
            cBxBoletos.SelectedIndexChanged += cBxBoletos_SelectedIndexChanged;
            // 
            // FrmVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1201, 705);
            Controls.Add(cBxBoletos);
            Controls.Add(TxtCortesia);
            Controls.Add(label4);
            Controls.Add(btnEfectivo);
            Controls.Add(btnTarjeta);
            Controls.Add(TxtTotal);
            Controls.Add(DgvConceptos);
            Controls.Add(TxtValorUnitario);
            Controls.Add(TxtCantidad);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAgregar);
            Name = "FrmVenta";
            Text = "Form1";
            Load += FrmVenta_Load;
            ((System.ComponentModel.ISupportInitialize)DgvConceptos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Button btnAgregar;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TxtCantidad;
        private TextBox TxtValorUnitario;
        private DataGridView DgvConceptos;
        private TextBox TxtTotal;
        private Button btnTarjeta;
        private Button btnEfectivo;
        private Label label4;
        private TextBox TxtCortesia;
        private ComboBox cBxBoletos;
    }
}
