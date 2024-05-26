namespace Laboratorio_clase_fin_curso
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.comboBoxCompanias = new System.Windows.Forms.ComboBox();
            this.botonPrueba = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxCompania = new System.Windows.Forms.TextBox();
            this.textBoxAnio = new System.Windows.Forms.TextBox();
            this.textBoxGeneracion = new System.Windows.Forms.TextBox();
            this.buttonSiguiente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(591, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dany Miguel Mateo Hernánddez 0905-23-19399";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(549, 322);
            this.dataGridView1.TabIndex = 1;
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(27, 442);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(75, 23);
            this.buttonCargar.TabIndex = 2;
            this.buttonCargar.Text = "Cargar";
            this.buttonCargar.UseVisualStyleBackColor = true;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // comboBoxCompanias
            // 
            this.comboBoxCompanias.FormattingEnabled = true;
            this.comboBoxCompanias.Location = new System.Drawing.Point(629, 84);
            this.comboBoxCompanias.Name = "comboBoxCompanias";
            this.comboBoxCompanias.Size = new System.Drawing.Size(180, 21);
            this.comboBoxCompanias.TabIndex = 3;
            this.comboBoxCompanias.SelectedIndexChanged += new System.EventHandler(this.comboBoxCompanias_SelectedIndexChanged);
            // 
            // botonPrueba
            // 
            this.botonPrueba.Location = new System.Drawing.Point(890, 474);
            this.botonPrueba.Name = "botonPrueba";
            this.botonPrueba.Size = new System.Drawing.Size(75, 23);
            this.botonPrueba.TabIndex = 4;
            this.botonPrueba.Text = "Prueba";
            this.botonPrueba.UseVisualStyleBackColor = true;
            this.botonPrueba.Click += new System.EventHandler(this.botonPrueba_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(629, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(632, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(635, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Compania";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(635, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Año";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(641, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Generacion";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(709, 157);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 10;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(709, 183);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 11;
            // 
            // textBoxCompania
            // 
            this.textBoxCompania.Location = new System.Drawing.Point(709, 224);
            this.textBoxCompania.Name = "textBoxCompania";
            this.textBoxCompania.Size = new System.Drawing.Size(100, 20);
            this.textBoxCompania.TabIndex = 12;
            // 
            // textBoxAnio
            // 
            this.textBoxAnio.Location = new System.Drawing.Point(709, 258);
            this.textBoxAnio.Name = "textBoxAnio";
            this.textBoxAnio.Size = new System.Drawing.Size(100, 20);
            this.textBoxAnio.TabIndex = 13;
            // 
            // textBoxGeneracion
            // 
            this.textBoxGeneracion.Location = new System.Drawing.Point(709, 298);
            this.textBoxGeneracion.Name = "textBoxGeneracion";
            this.textBoxGeneracion.Size = new System.Drawing.Size(100, 20);
            this.textBoxGeneracion.TabIndex = 14;
            // 
            // buttonSiguiente
            // 
            this.buttonSiguiente.Location = new System.Drawing.Point(401, 442);
            this.buttonSiguiente.Name = "buttonSiguiente";
            this.buttonSiguiente.Size = new System.Drawing.Size(75, 23);
            this.buttonSiguiente.TabIndex = 15;
            this.buttonSiguiente.Text = "SIGUIENTE";
            this.buttonSiguiente.UseVisualStyleBackColor = true;
            this.buttonSiguiente.Click += new System.EventHandler(this.buttonSiguiente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 531);
            this.Controls.Add(this.buttonSiguiente);
            this.Controls.Add(this.textBoxGeneracion);
            this.Controls.Add(this.textBoxAnio);
            this.Controls.Add(this.textBoxCompania);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.botonPrueba);
            this.Controls.Add(this.comboBoxCompanias);
            this.Controls.Add(this.buttonCargar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.ComboBox comboBoxCompanias;
        private System.Windows.Forms.Button botonPrueba;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxCompania;
        private System.Windows.Forms.TextBox textBoxAnio;
        private System.Windows.Forms.TextBox textBoxGeneracion;
        private System.Windows.Forms.Button buttonSiguiente;
    }
}

