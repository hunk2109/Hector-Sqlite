namespace crud
{
    partial class Form1
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
            this.dgvdatos = new System.Windows.Forms.DataGridView();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btncrear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbtablas = new System.Windows.Forms.ComboBox();
            this.txtcondiocional = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.rdbid = new System.Windows.Forms.RadioButton();
            this.rdbnombre = new System.Windows.Forms.RadioButton();
            this.rdbapellido = new System.Windows.Forms.RadioButton();
            this.rdbcedula = new System.Windows.Forms.RadioButton();
            this.rdbsexo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdatos
            // 
            this.dgvdatos.AllowUserToOrderColumns = true;
            this.dgvdatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvdatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdatos.Location = new System.Drawing.Point(12, 66);
            this.dgvdatos.Name = "dgvdatos";
            this.dgvdatos.Size = new System.Drawing.Size(867, 303);
            this.dgvdatos.TabIndex = 0;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(532, 12);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(181, 20);
            this.txtbuscar.TabIndex = 1;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(719, 11);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 2;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btncrear
            // 
            this.btncrear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btncrear.Location = new System.Drawing.Point(618, 397);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(75, 23);
            this.btncrear.TabIndex = 3;
            this.btncrear.Text = "crear";
            this.btncrear.UseVisualStyleBackColor = true;
            this.btncrear.Click += new System.EventHandler(this.btncrear_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(81, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Prueba";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbtablas
            // 
            this.cmbtablas.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmbtablas.FormattingEnabled = true;
            this.cmbtablas.Items.AddRange(new object[] {
            "Empleado",
            "Cargo",
            "Detalles Nomina"});
            this.cmbtablas.Location = new System.Drawing.Point(699, 397);
            this.cmbtablas.Name = "cmbtablas";
            this.cmbtablas.Size = new System.Drawing.Size(121, 21);
            this.cmbtablas.TabIndex = 5;
            this.cmbtablas.SelectedIndexChanged += new System.EventHandler(this.cmbtablas_SelectedIndexChanged);
            // 
            // txtcondiocional
            // 
            this.txtcondiocional.Location = new System.Drawing.Point(694, 41);
            this.txtcondiocional.Name = "txtcondiocional";
            this.txtcondiocional.Size = new System.Drawing.Size(100, 20);
            this.txtcondiocional.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(573, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tablas";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Mostrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rdbid
            // 
            this.rdbid.AutoSize = true;
            this.rdbid.Location = new System.Drawing.Point(118, 19);
            this.rdbid.Name = "rdbid";
            this.rdbid.Size = new System.Drawing.Size(36, 17);
            this.rdbid.TabIndex = 9;
            this.rdbid.TabStop = true;
            this.rdbid.Text = "ID";
            this.rdbid.UseVisualStyleBackColor = true;
            this.rdbid.CheckedChanged += new System.EventHandler(this.rdbid_CheckedChanged);
            // 
            // rdbnombre
            // 
            this.rdbnombre.AutoSize = true;
            this.rdbnombre.Location = new System.Drawing.Point(160, 19);
            this.rdbnombre.Name = "rdbnombre";
            this.rdbnombre.Size = new System.Drawing.Size(62, 17);
            this.rdbnombre.TabIndex = 10;
            this.rdbnombre.TabStop = true;
            this.rdbnombre.Text = "Nombre";
            this.rdbnombre.UseVisualStyleBackColor = true;
            // 
            // rdbapellido
            // 
            this.rdbapellido.AutoSize = true;
            this.rdbapellido.Location = new System.Drawing.Point(228, 19);
            this.rdbapellido.Name = "rdbapellido";
            this.rdbapellido.Size = new System.Drawing.Size(62, 17);
            this.rdbapellido.TabIndex = 11;
            this.rdbapellido.TabStop = true;
            this.rdbapellido.Text = "Apellido";
            this.rdbapellido.UseVisualStyleBackColor = true;
            // 
            // rdbcedula
            // 
            this.rdbcedula.AutoSize = true;
            this.rdbcedula.Location = new System.Drawing.Point(296, 19);
            this.rdbcedula.Name = "rdbcedula";
            this.rdbcedula.Size = new System.Drawing.Size(58, 17);
            this.rdbcedula.TabIndex = 12;
            this.rdbcedula.TabStop = true;
            this.rdbcedula.Text = "Cedula";
            this.rdbcedula.UseVisualStyleBackColor = true;
            // 
            // rdbsexo
            // 
            this.rdbsexo.AutoSize = true;
            this.rdbsexo.Location = new System.Drawing.Point(361, 19);
            this.rdbsexo.Name = "rdbsexo";
            this.rdbsexo.Size = new System.Drawing.Size(49, 17);
            this.rdbsexo.TabIndex = 13;
            this.rdbsexo.TabStop = true;
            this.rdbsexo.Text = "Sexo";
            this.rdbsexo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(891, 460);
            this.Controls.Add(this.rdbsexo);
            this.Controls.Add(this.rdbcedula);
            this.Controls.Add(this.rdbapellido);
            this.Controls.Add(this.rdbnombre);
            this.Controls.Add(this.rdbid);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcondiocional);
            this.Controls.Add(this.cmbtablas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btncrear);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.dgvdatos);
            this.Name = "Form1";
            this.Text = "Compañia del Caribe CXA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdatos;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btncrear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbtablas;
        private System.Windows.Forms.TextBox txtcondiocional;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rdbid;
        private System.Windows.Forms.RadioButton rdbnombre;
        private System.Windows.Forms.RadioButton rdbapellido;
        private System.Windows.Forms.RadioButton rdbcedula;
        private System.Windows.Forms.RadioButton rdbsexo;
    }
}

