namespace WindowsFormsApp1
{
    partial class Préstamos
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
            this.components = new System.ComponentModel.Container();
            this.txtSignatura = new System.Windows.Forms.Label();
            this.txt_AgregarSignatura = new System.Windows.Forms.TextBox();
            this.txtPrestamosala = new System.Windows.Forms.Label();
            this.btn_ConfirmarRegistro = new System.Windows.Forms.Button();
            this.btn_CancelarRegistro = new System.Windows.Forms.Button();
            this.dtGV_Signaturas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_AgregarSignaturaList = new System.Windows.Forms.Button();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txt_IDUsuario = new System.Windows.Forms.TextBox();
            this.txt_AgregarSignaturaList = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AgregarSignatura = new System.Windows.Forms.Button();
            this.txt_aprobadoPor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGV_Signaturas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSignatura
            // 
            this.txtSignatura.AutoSize = true;
            this.txtSignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignatura.ForeColor = System.Drawing.Color.White;
            this.txtSignatura.Location = new System.Drawing.Point(68, 53);
            this.txtSignatura.Name = "txtSignatura";
            this.txtSignatura.Size = new System.Drawing.Size(95, 13);
            this.txtSignatura.TabIndex = 0;
            this.txtSignatura.Text = "B. SIGNATURA";
            this.txtSignatura.Click += new System.EventHandler(this.txtSignatura_Click);
            // 
            // txt_AgregarSignatura
            // 
            this.txt_AgregarSignatura.Location = new System.Drawing.Point(169, 50);
            this.txt_AgregarSignatura.Name = "txt_AgregarSignatura";
            this.txt_AgregarSignatura.Size = new System.Drawing.Size(265, 20);
            this.txt_AgregarSignatura.TabIndex = 1;
            this.txt_AgregarSignatura.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPrestamosala
            // 
            this.txtPrestamosala.AutoSize = true;
            this.txtPrestamosala.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrestamosala.ForeColor = System.Drawing.Color.White;
            this.txtPrestamosala.Location = new System.Drawing.Point(238, 9);
            this.txtPrestamosala.Name = "txtPrestamosala";
            this.txtPrestamosala.Size = new System.Drawing.Size(137, 24);
            this.txtPrestamosala.TabIndex = 9;
            this.txtPrestamosala.Text = "PRÉSTAMOS";
            // 
            // btn_ConfirmarRegistro
            // 
            this.btn_ConfirmarRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ConfirmarRegistro.Location = new System.Drawing.Point(169, 351);
            this.btn_ConfirmarRegistro.Name = "btn_ConfirmarRegistro";
            this.btn_ConfirmarRegistro.Size = new System.Drawing.Size(80, 30);
            this.btn_ConfirmarRegistro.TabIndex = 7;
            this.btn_ConfirmarRegistro.Text = "Confirmar";
            this.btn_ConfirmarRegistro.UseVisualStyleBackColor = true;
            this.btn_ConfirmarRegistro.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_CancelarRegistro
            // 
            this.btn_CancelarRegistro.Location = new System.Drawing.Point(316, 351);
            this.btn_CancelarRegistro.Name = "btn_CancelarRegistro";
            this.btn_CancelarRegistro.Size = new System.Drawing.Size(80, 30);
            this.btn_CancelarRegistro.TabIndex = 8;
            this.btn_CancelarRegistro.Text = "Cancelar";
            this.btn_CancelarRegistro.UseVisualStyleBackColor = true;
            // 
            // dtGV_Signaturas
            // 
            this.dtGV_Signaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtGV_Signaturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dtGV_Signaturas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dtGV_Signaturas.Location = new System.Drawing.Point(219, 201);
            this.dtGV_Signaturas.Name = "dtGV_Signaturas";
            this.dtGV_Signaturas.Size = new System.Drawing.Size(142, 141);
            this.dtGV_Signaturas.TabIndex = 12;
            this.dtGV_Signaturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGV_Signaturas_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Signatura libro ";
            this.Column1.Name = "Column1";
            // 
            // btn_AgregarSignaturaList
            // 
            this.btn_AgregarSignaturaList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AgregarSignaturaList.Location = new System.Drawing.Point(449, 84);
            this.btn_AgregarSignaturaList.Name = "btn_AgregarSignaturaList";
            this.btn_AgregarSignaturaList.Size = new System.Drawing.Size(63, 22);
            this.btn_AgregarSignaturaList.TabIndex = 6;
            this.btn_AgregarSignaturaList.Text = "Agregar";
            this.btn_AgregarSignaturaList.UseVisualStyleBackColor = true;
            this.btn_AgregarSignaturaList.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.Location = new System.Drawing.Point(546, 383);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(75, 31);
            this.iconButton2.TabIndex = 9;
            this.iconButton2.Text = "Salir";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.CircleChevronLeft;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(1, 1);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(69, 27);
            this.iconButton1.TabIndex = 10;
            this.iconButton1.Text = "Atras";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.textBox2.Location = new System.Drawing.Point(1, 394);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(131, 20);
            this.textBox2.TabIndex = 14;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(68, 126);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(88, 13);
            this.lblUsuario.TabIndex = 15;
            this.lblUsuario.Text = "ID - USUARIO";
            // 
            // txt_IDUsuario
            // 
            this.txt_IDUsuario.Location = new System.Drawing.Point(169, 123);
            this.txt_IDUsuario.Name = "txt_IDUsuario";
            this.txt_IDUsuario.Size = new System.Drawing.Size(265, 20);
            this.txt_IDUsuario.TabIndex = 3;
            // 
            // txt_AgregarSignaturaList
            // 
            this.txt_AgregarSignaturaList.Location = new System.Drawing.Point(169, 86);
            this.txt_AgregarSignaturaList.Name = "txt_AgregarSignaturaList";
            this.txt_AgregarSignaturaList.Size = new System.Drawing.Size(265, 20);
            this.txt_AgregarSignaturaList.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(69, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "SIGNATURA";
            // 
            // btn_AgregarSignatura
            // 
            this.btn_AgregarSignatura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AgregarSignatura.Location = new System.Drawing.Point(449, 42);
            this.btn_AgregarSignatura.Name = "btn_AgregarSignatura";
            this.btn_AgregarSignatura.Size = new System.Drawing.Size(63, 35);
            this.btn_AgregarSignatura.TabIndex = 5;
            this.btn_AgregarSignatura.Text = "Agregar a la BD";
            this.btn_AgregarSignatura.UseVisualStyleBackColor = true;
            this.btn_AgregarSignatura.Click += new System.EventHandler(this.btn_AgregarSignatura_Click);
            // 
            // txt_aprobadoPor
            // 
            this.txt_aprobadoPor.FormattingEnabled = true;
            this.txt_aprobadoPor.Items.AddRange(new object[] {
            "Isolina Tinoco Meza",
            "Ana Maria Flores",
            "Daniel Ruiz Ortez",
            "Heysell Rivas Peralta"});
            this.txt_aprobadoPor.Location = new System.Drawing.Point(179, 157);
            this.txt_aprobadoPor.Name = "txt_aprobadoPor";
            this.txt_aprobadoPor.Size = new System.Drawing.Size(255, 21);
            this.txt_aprobadoPor.TabIndex = 87;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(68, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 88;
            this.label4.Text = "APROBADO POR";
            // 
            // Prestamo_en_Sala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(624, 416);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_aprobadoPor);
            this.Controls.Add(this.btn_AgregarSignatura);
            this.Controls.Add(this.txt_AgregarSignaturaList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_IDUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btn_AgregarSignaturaList);
            this.Controls.Add(this.dtGV_Signaturas);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.btn_CancelarRegistro);
            this.Controls.Add(this.btn_ConfirmarRegistro);
            this.Controls.Add(this.txtPrestamosala);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.txt_AgregarSignatura);
            this.Controls.Add(this.txtSignatura);
            this.Name = "Prestamo_en_Sala";
            this.Text = "Prestamo_en_Sala";
            ((System.ComponentModel.ISupportInitialize)(this.dtGV_Signaturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtSignatura;
        private System.Windows.Forms.TextBox txt_AgregarSignatura;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label txtPrestamosala;
        private System.Windows.Forms.Button btn_ConfirmarRegistro;
        private System.Windows.Forms.Button btn_CancelarRegistro;
        private System.Windows.Forms.DataGridView dtGV_Signaturas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btn_AgregarSignaturaList;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txt_IDUsuario;
        private System.Windows.Forms.TextBox txt_AgregarSignaturaList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_AgregarSignatura;
        private System.Windows.Forms.ComboBox txt_aprobadoPor;
        private System.Windows.Forms.Label label4;
    }
}