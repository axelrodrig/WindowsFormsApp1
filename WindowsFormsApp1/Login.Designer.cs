namespace WindowsFormsApp1
{
    partial class Login
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
            FontAwesome.Sharp.IconButton iconButton2;
            this.txtUsuarios = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtidentificacion = new System.Windows.Forms.TextBox();
            this.cbusuario = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.BtnEntrar = new FontAwesome.Sharp.IconButton();
            this.Muestra = new System.Windows.Forms.CheckBox();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // iconButton2
            // 
            iconButton2.BackColor = System.Drawing.Color.White;
            iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            iconButton2.IconColor = System.Drawing.Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            iconButton2.Location = new System.Drawing.Point(418, 231);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new System.Drawing.Size(112, 47);
            iconButton2.TabIndex = 5;
            iconButton2.Text = "Salir  ";
            iconButton2.UseVisualStyleBackColor = false;
            iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // txtUsuarios
            // 
            this.txtUsuarios.AutoSize = true;
            this.txtUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarios.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtUsuarios.Location = new System.Drawing.Point(176, 76);
            this.txtUsuarios.Name = "txtUsuarios";
            this.txtUsuarios.Size = new System.Drawing.Size(71, 13);
            this.txtUsuarios.TabIndex = 0;
            this.txtUsuarios.Text = "USUARIOS";
            this.txtUsuarios.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(164, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "IDENTIFICACIÓN";
            // 
            // txtidentificacion
            // 
            this.txtidentificacion.Location = new System.Drawing.Point(276, 119);
            this.txtidentificacion.Name = "txtidentificacion";
            this.txtidentificacion.PasswordChar = '*';
            this.txtidentificacion.Size = new System.Drawing.Size(254, 20);
            this.txtidentificacion.TabIndex = 2;
            this.txtidentificacion.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // cbusuario
            // 
            this.cbusuario.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbusuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbusuario.ForeColor = System.Drawing.Color.Black;
            this.cbusuario.FormattingEnabled = true;
            this.cbusuario.Items.AddRange(new object[] {
            "ADMINISTRADOR"});
            this.cbusuario.Location = new System.Drawing.Point(276, 68);
            this.cbusuario.Name = "cbusuario";
            this.cbusuario.Size = new System.Drawing.Size(254, 21);
            this.cbusuario.TabIndex = 1;
            this.cbusuario.SelectedIndexChanged += new System.EventHandler(this.cbusuario_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 324);
            this.panel1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(22, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "BIENVENIDO (AS)";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 111;
            this.iconPictureBox1.Location = new System.Drawing.Point(25, 53);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(111, 122);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // BtnEntrar
            // 
            this.BtnEntrar.BackColor = System.Drawing.Color.White;
            this.BtnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEntrar.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.BtnEntrar.IconColor = System.Drawing.Color.Black;
            this.BtnEntrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEntrar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnEntrar.Location = new System.Drawing.Point(266, 231);
            this.BtnEntrar.Name = "BtnEntrar";
            this.BtnEntrar.Size = new System.Drawing.Size(103, 47);
            this.BtnEntrar.TabIndex = 4;
            this.BtnEntrar.Text = "Entrar\r\n";
            this.BtnEntrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnEntrar.UseVisualStyleBackColor = false;
            this.BtnEntrar.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // Muestra
            // 
            this.Muestra.AutoSize = true;
            this.Muestra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Muestra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Muestra.Location = new System.Drawing.Point(276, 138);
            this.Muestra.Name = "Muestra";
            this.Muestra.Size = new System.Drawing.Size(72, 17);
            this.Muestra.TabIndex = 3;
            this.Muestra.Text = "Mostrar ";
            this.Muestra.UseVisualStyleBackColor = true;
            this.Muestra.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(590, 324);
            this.Controls.Add(this.Muestra);
            this.Controls.Add(this.panel1);
            this.Controls.Add(iconButton2);
            this.Controls.Add(this.BtnEntrar);
            this.Controls.Add(this.cbusuario);
            this.Controls.Add(this.txtidentificacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsuarios);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadística de préstamos bibliográficos";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtUsuarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtidentificacion;
        private System.Windows.Forms.ComboBox cbusuario;
        private FontAwesome.Sharp.IconButton BtnEntrar;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox Muestra;
    }
}

