namespace Proyecto_calculo_nomina
{
    partial class fmrprincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpdatos = new System.Windows.Forms.GroupBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btncalcular = new System.Windows.Forms.Button();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblcedula = new System.Windows.Forms.Label();
            this.lblsalariohora = new System.Windows.Forms.Label();
            this.lblsexo = new System.Windows.Forms.Label();
            this.lblAntiguedad = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.txtsalariohora = new System.Windows.Forms.TextBox();
            this.cmbsexo = new System.Windows.Forms.ComboBox();
            this.cmbantiguedad = new System.Windows.Forms.ComboBox();
            this.grpresultado = new System.Windows.Forms.GroupBox();
            this.lblnombre1 = new System.Windows.Forms.Label();
            this.lblcedula1 = new System.Windows.Forms.Label();
            this.lblsalarioneto = new System.Windows.Forms.Label();
            this.lblsalarioneto_bono = new System.Windows.Forms.Label();
            this.txtnombre1 = new System.Windows.Forms.TextBox();
            this.txtcedula1 = new System.Windows.Forms.TextBox();
            this.txtsalarioneto = new System.Windows.Forms.TextBox();
            this.txtsalarioneto_bono = new System.Windows.Forms.TextBox();
            this.lbldias = new System.Windows.Forms.Label();
            this.txtdias = new System.Windows.Forms.TextBox();
            this.grpdatos.SuspendLayout();
            this.grpresultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpdatos
            // 
            this.grpdatos.Controls.Add(this.txtdias);
            this.grpdatos.Controls.Add(this.lbldias);
            this.grpdatos.Controls.Add(this.cmbantiguedad);
            this.grpdatos.Controls.Add(this.cmbsexo);
            this.grpdatos.Controls.Add(this.txtsalariohora);
            this.grpdatos.Controls.Add(this.txtcedula);
            this.grpdatos.Controls.Add(this.txtnombre);
            this.grpdatos.Controls.Add(this.lblAntiguedad);
            this.grpdatos.Controls.Add(this.lblsexo);
            this.grpdatos.Controls.Add(this.lblsalariohora);
            this.grpdatos.Controls.Add(this.lblcedula);
            this.grpdatos.Controls.Add(this.lblnombre);
            this.grpdatos.Location = new System.Drawing.Point(13, 13);
            this.grpdatos.Name = "grpdatos";
            this.grpdatos.Size = new System.Drawing.Size(355, 269);
            this.grpdatos.TabIndex = 0;
            this.grpdatos.TabStop = false;
            this.grpdatos.Text = "Datos";
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(374, 24);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 1;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(374, 135);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 2;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(374, 259);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 3;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(10, 34);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(44, 13);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Text = "Nombre";
            // 
            // lblcedula
            // 
            this.lblcedula.AutoSize = true;
            this.lblcedula.Location = new System.Drawing.Point(10, 65);
            this.lblcedula.Name = "lblcedula";
            this.lblcedula.Size = new System.Drawing.Size(40, 13);
            this.lblcedula.TabIndex = 1;
            this.lblcedula.Text = "Cedula";
            // 
            // lblsalariohora
            // 
            this.lblsalariohora.AutoSize = true;
            this.lblsalariohora.Location = new System.Drawing.Point(10, 98);
            this.lblsalariohora.Name = "lblsalariohora";
            this.lblsalariohora.Size = new System.Drawing.Size(83, 13);
            this.lblsalariohora.TabIndex = 2;
            this.lblsalariohora.Text = "Salario por Hora";
            // 
            // lblsexo
            // 
            this.lblsexo.AutoSize = true;
            this.lblsexo.Location = new System.Drawing.Point(10, 163);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(31, 13);
            this.lblsexo.TabIndex = 3;
            this.lblsexo.Text = "Sexo";
            // 
            // lblAntiguedad
            // 
            this.lblAntiguedad.AutoSize = true;
            this.lblAntiguedad.Location = new System.Drawing.Point(10, 197);
            this.lblAntiguedad.Name = "lblAntiguedad";
            this.lblAntiguedad.Size = new System.Drawing.Size(61, 13);
            this.lblAntiguedad.TabIndex = 4;
            this.lblAntiguedad.Text = "Antiguedad";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(101, 34);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 5;
            // 
            // txtcedula
            // 
            this.txtcedula.Location = new System.Drawing.Point(101, 65);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(100, 20);
            this.txtcedula.TabIndex = 6;
            // 
            // txtsalariohora
            // 
            this.txtsalariohora.Location = new System.Drawing.Point(100, 98);
            this.txtsalariohora.Name = "txtsalariohora";
            this.txtsalariohora.Size = new System.Drawing.Size(100, 20);
            this.txtsalariohora.TabIndex = 7;
            // 
            // cmbsexo
            // 
            this.cmbsexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsexo.FormattingEnabled = true;
            this.cmbsexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbsexo.Location = new System.Drawing.Point(100, 162);
            this.cmbsexo.Name = "cmbsexo";
            this.cmbsexo.Size = new System.Drawing.Size(51, 21);
            this.cmbsexo.TabIndex = 8;
            this.cmbsexo.SelectedIndexChanged += new System.EventHandler(this.cmbsexo_SelectedIndexChanged);
            // 
            // cmbantiguedad
            // 
            this.cmbantiguedad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbantiguedad.FormattingEnabled = true;
            this.cmbantiguedad.Items.AddRange(new object[] {
            "1-Menor o igual a 1 año.",
            "2-Mayor a 1 año y menor igual a 2 años.",
            "3-Mayor a 2 años y menor o igual a 10 años.",
            "4-Mayor a 10 añ0s y menor o igual a 20 años",
            "5-Mayor a 20 años."});
            this.cmbantiguedad.Location = new System.Drawing.Point(100, 189);
            this.cmbantiguedad.Name = "cmbantiguedad";
            this.cmbantiguedad.Size = new System.Drawing.Size(226, 21);
            this.cmbantiguedad.TabIndex = 9;
            // 
            // grpresultado
            // 
            this.grpresultado.Controls.Add(this.txtsalarioneto_bono);
            this.grpresultado.Controls.Add(this.txtsalarioneto);
            this.grpresultado.Controls.Add(this.txtcedula1);
            this.grpresultado.Controls.Add(this.txtnombre1);
            this.grpresultado.Controls.Add(this.lblsalarioneto_bono);
            this.grpresultado.Controls.Add(this.lblsalarioneto);
            this.grpresultado.Controls.Add(this.lblcedula1);
            this.grpresultado.Controls.Add(this.lblnombre1);
            this.grpresultado.Location = new System.Drawing.Point(459, 13);
            this.grpresultado.Name = "grpresultado";
            this.grpresultado.Size = new System.Drawing.Size(309, 269);
            this.grpresultado.TabIndex = 4;
            this.grpresultado.TabStop = false;
            this.grpresultado.Text = "Resultado";
            // 
            // lblnombre1
            // 
            this.lblnombre1.AutoSize = true;
            this.lblnombre1.Location = new System.Drawing.Point(133, 16);
            this.lblnombre1.Name = "lblnombre1";
            this.lblnombre1.Size = new System.Drawing.Size(44, 13);
            this.lblnombre1.TabIndex = 0;
            this.lblnombre1.Text = "Nombre";
            // 
            // lblcedula1
            // 
            this.lblcedula1.AutoSize = true;
            this.lblcedula1.Location = new System.Drawing.Point(133, 57);
            this.lblcedula1.Name = "lblcedula1";
            this.lblcedula1.Size = new System.Drawing.Size(40, 13);
            this.lblcedula1.TabIndex = 1;
            this.lblcedula1.Text = "Cedula";
            // 
            // lblsalarioneto
            // 
            this.lblsalarioneto.AutoSize = true;
            this.lblsalarioneto.Location = new System.Drawing.Point(86, 101);
            this.lblsalarioneto.Name = "lblsalarioneto";
            this.lblsalarioneto.Size = new System.Drawing.Size(151, 13);
            this.lblsalarioneto.TabIndex = 2;
            this.lblsalarioneto.Text = "Salario neto mas Deducciones";
            // 
            // lblsalarioneto_bono
            // 
            this.lblsalarioneto_bono.AutoSize = true;
            this.lblsalarioneto_bono.Location = new System.Drawing.Point(61, 158);
            this.lblsalarioneto_bono.Name = "lblsalarioneto_bono";
            this.lblsalarioneto_bono.Size = new System.Drawing.Size(197, 13);
            this.lblsalarioneto_bono.TabIndex = 3;
            this.lblsalarioneto_bono.Text = "Salario Neto mas el bono y deducciones";
            // 
            // txtnombre1
            // 
            this.txtnombre1.Location = new System.Drawing.Point(108, 34);
            this.txtnombre1.Name = "txtnombre1";
            this.txtnombre1.ReadOnly = true;
            this.txtnombre1.Size = new System.Drawing.Size(100, 20);
            this.txtnombre1.TabIndex = 4;
            this.txtnombre1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtnombre1.TextChanged += new System.EventHandler(this.txtnombre1_TextChanged);
            // 
            // txtcedula1
            // 
            this.txtcedula1.Location = new System.Drawing.Point(108, 73);
            this.txtcedula1.Name = "txtcedula1";
            this.txtcedula1.ReadOnly = true;
            this.txtcedula1.Size = new System.Drawing.Size(100, 20);
            this.txtcedula1.TabIndex = 5;
            this.txtcedula1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcedula1.TextChanged += new System.EventHandler(this.txtcedula1_TextChanged);
            // 
            // txtsalarioneto
            // 
            this.txtsalarioneto.Location = new System.Drawing.Point(108, 124);
            this.txtsalarioneto.Name = "txtsalarioneto";
            this.txtsalarioneto.ReadOnly = true;
            this.txtsalarioneto.Size = new System.Drawing.Size(100, 20);
            this.txtsalarioneto.TabIndex = 6;
            this.txtsalarioneto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtsalarioneto.TextChanged += new System.EventHandler(this.txtsalarioneto_TextChanged);
            // 
            // txtsalarioneto_bono
            // 
            this.txtsalarioneto_bono.Location = new System.Drawing.Point(108, 178);
            this.txtsalarioneto_bono.Name = "txtsalarioneto_bono";
            this.txtsalarioneto_bono.ReadOnly = true;
            this.txtsalarioneto_bono.Size = new System.Drawing.Size(100, 20);
            this.txtsalarioneto_bono.TabIndex = 7;
            this.txtsalarioneto_bono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbldias
            // 
            this.lbldias.AutoSize = true;
            this.lbldias.Location = new System.Drawing.Point(13, 130);
            this.lbldias.Name = "lbldias";
            this.lbldias.Size = new System.Drawing.Size(30, 13);
            this.lbldias.TabIndex = 10;
            this.lbldias.Text = "Días";
            // 
            // txtdias
            // 
            this.txtdias.Location = new System.Drawing.Point(100, 130);
            this.txtdias.Name = "txtdias";
            this.txtdias.Size = new System.Drawing.Size(100, 20);
            this.txtdias.TabIndex = 11;
            // 
            // fmrprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 290);
            this.ControlBox = false;
            this.Controls.Add(this.grpresultado);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.grpdatos);
            this.Name = "fmrprincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculo Nomina";
            this.grpdatos.ResumeLayout(false);
            this.grpdatos.PerformLayout();
            this.grpresultado.ResumeLayout(false);
            this.grpresultado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpdatos;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.ComboBox cmbantiguedad;
        private System.Windows.Forms.ComboBox cmbsexo;
        private System.Windows.Forms.TextBox txtsalariohora;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblAntiguedad;
        private System.Windows.Forms.Label lblsexo;
        private System.Windows.Forms.Label lblsalariohora;
        private System.Windows.Forms.Label lblcedula;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.GroupBox grpresultado;
        private System.Windows.Forms.Label lblsalarioneto_bono;
        private System.Windows.Forms.Label lblsalarioneto;
        private System.Windows.Forms.Label lblcedula1;
        private System.Windows.Forms.Label lblnombre1;
        private System.Windows.Forms.TextBox txtsalarioneto_bono;
        private System.Windows.Forms.TextBox txtsalarioneto;
        private System.Windows.Forms.TextBox txtcedula1;
        private System.Windows.Forms.TextBox txtnombre1;
        private System.Windows.Forms.TextBox txtdias;
        private System.Windows.Forms.Label lbldias;
    }
}

