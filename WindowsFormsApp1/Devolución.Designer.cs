namespace WindowsFormsApp1
{
    partial class Devolución
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_consultarUPrestamo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtGV_Usuario = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.fecha_DevolucionSignatura = new System.Windows.Forms.DateTimePicker();
            this.select_Recibido = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.btnatras = new FontAwesome.Sharp.IconButton();
            this.btn_consultarUPrestamo = new System.Windows.Forms.Button();
            this.dtGV_SignaturasU = new System.Windows.Forms.DataGridView();
            this.Signaturas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGV_Usuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGV_SignaturasU)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_consultarUPrestamo
            // 
            this.txt_consultarUPrestamo.Location = new System.Drawing.Point(229, 70);
            this.txt_consultarUPrestamo.Name = "txt_consultarUPrestamo";
            this.txt_consultarUPrestamo.Size = new System.Drawing.Size(210, 20);
            this.txt_consultarUPrestamo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(115, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IDENTIFICACIÓN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Registrar.ForeColor = System.Drawing.Color.Black;
            this.btn_Registrar.Location = new System.Drawing.Point(76, 330);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Registrar.TabIndex = 7;
            this.btn_Registrar.Text = "Confirmar";
            this.btn_Registrar.UseVisualStyleBackColor = true;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(189, 330);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(155, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 24);
            this.label3.TabIndex = 80;
            this.label3.Text = "DEVOLUCIÓN DE LIBRO";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtGV_Usuario);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.fecha_DevolucionSignatura);
            this.panel1.Controls.Add(this.select_Recibido);
            this.panel1.Controls.Add(this.label5);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(12, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 167);
            this.panel1.TabIndex = 83;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dtGV_Usuario
            // 
            this.dtGV_Usuario.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtGV_Usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGV_Usuario.Location = new System.Drawing.Point(0, 0);
            this.dtGV_Usuario.Name = "dtGV_Usuario";
            this.dtGV_Usuario.Size = new System.Drawing.Size(449, 91);
            this.dtGV_Usuario.TabIndex = 90;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(153, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 15);
            this.label6.TabIndex = 89;
            this.label6.Text = "FECHA DEVOLUCIÓN";
            // 
            // fecha_DevolucionSignatura
            // 
            this.fecha_DevolucionSignatura.Location = new System.Drawing.Point(217, 144);
            this.fecha_DevolucionSignatura.Name = "fecha_DevolucionSignatura";
            this.fecha_DevolucionSignatura.Size = new System.Drawing.Size(200, 20);
            this.fecha_DevolucionSignatura.TabIndex = 88;
            // 
            // select_Recibido
            // 
            this.select_Recibido.FormattingEnabled = true;
            this.select_Recibido.Items.AddRange(new object[] {
            "Isolina Tinoco Meza",
            "Ana Maria Flores",
            "Daniel Ruiz Ortez",
            "Heysell Rivas Peralta"});
            this.select_Recibido.Location = new System.Drawing.Point(35, 143);
            this.select_Recibido.Name = "select_Recibido";
            this.select_Recibido.Size = new System.Drawing.Size(155, 21);
            this.select_Recibido.TabIndex = 87;
            this.select_Recibido.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(32, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 85;
            this.label5.Text = "Recibido por";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            this.btnSalir.IconColor = System.Drawing.Color.Black;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 30;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(569, 345);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 31);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnatras
            // 
            this.btnatras.BackColor = System.Drawing.Color.White;
            this.btnatras.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnatras.IconChar = FontAwesome.Sharp.IconChar.CircleChevronLeft;
            this.btnatras.IconColor = System.Drawing.Color.Black;
            this.btnatras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnatras.IconSize = 30;
            this.btnatras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnatras.Location = new System.Drawing.Point(2, 6);
            this.btnatras.Name = "btnatras";
            this.btnatras.Size = new System.Drawing.Size(75, 31);
            this.btnatras.TabIndex = 5;
            this.btnatras.Text = "Atràs";
            this.btnatras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnatras.UseVisualStyleBackColor = false;
            this.btnatras.Click += new System.EventHandler(this.btnatras_Click);
            // 
            // btn_consultarUPrestamo
            // 
            this.btn_consultarUPrestamo.BackColor = System.Drawing.Color.Transparent;
            this.btn_consultarUPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultarUPrestamo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_consultarUPrestamo.Location = new System.Drawing.Point(456, 68);
            this.btn_consultarUPrestamo.Name = "btn_consultarUPrestamo";
            this.btn_consultarUPrestamo.Size = new System.Drawing.Size(75, 23);
            this.btn_consultarUPrestamo.TabIndex = 84;
            this.btn_consultarUPrestamo.Text = "Consultar";
            this.btn_consultarUPrestamo.UseVisualStyleBackColor = false;
            this.btn_consultarUPrestamo.Click += new System.EventHandler(this.btn_consultarUPrestamo_Click);
            // 
            // dtGV_SignaturasU
            // 
            this.dtGV_SignaturasU.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtGV_SignaturasU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGV_SignaturasU.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Signaturas});
            this.dtGV_SignaturasU.Location = new System.Drawing.Point(467, 145);
            this.dtGV_SignaturasU.Name = "dtGV_SignaturasU";
            this.dtGV_SignaturasU.Size = new System.Drawing.Size(177, 167);
            this.dtGV_SignaturasU.TabIndex = 85;
            // 
            // Signaturas
            // 
            this.Signaturas.HeaderText = "Signatura";
            this.Signaturas.Name = "Signaturas";
            this.Signaturas.Width = 134;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(217, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 91;
            this.label4.Text = "Fecha de Recibido";
            // 
            // Devolución
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(656, 387);
            this.Controls.Add(this.dtGV_SignaturasU);
            this.Controls.Add(this.btn_consultarUPrestamo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btn_Registrar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnatras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_consultarUPrestamo);
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.Name = "Devolución";
            this.Text = "Devolucion";
            this.Load += new System.EventHandler(this.Devolucion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGV_Usuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGV_SignaturasU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_consultarUPrestamo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnatras;
        private FontAwesome.Sharp.IconButton btnSalir;
        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox select_Recibido;
        private System.Windows.Forms.DateTimePicker fecha_DevolucionSignatura;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_consultarUPrestamo;
        private System.Windows.Forms.DataGridView dtGV_Usuario;
        private System.Windows.Forms.DataGridView dtGV_SignaturasU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Signaturas;
        private System.Windows.Forms.Label label4;
    }
}