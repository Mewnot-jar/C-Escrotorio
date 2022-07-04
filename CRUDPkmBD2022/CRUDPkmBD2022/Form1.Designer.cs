
namespace CRUDPkmBD2022
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
            this.dgvPokemon = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombrePkm = new System.Windows.Forms.TextBox();
            this.txt_pesoPkm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_alturaPkm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_crearPkm = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_modificarPkm = new System.Windows.Forms.Button();
            this.txt_alturaUpdt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_pesoUpdt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nombreUpdt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemon)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPokemon
            // 
            this.dgvPokemon.AccessibleName = "";
            this.dgvPokemon.AllowUserToAddRows = false;
            this.dgvPokemon.AllowUserToDeleteRows = false;
            this.dgvPokemon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPokemon.Location = new System.Drawing.Point(12, 12);
            this.dgvPokemon.MultiSelect = false;
            this.dgvPokemon.Name = "dgvPokemon";
            this.dgvPokemon.ReadOnly = true;
            this.dgvPokemon.Size = new System.Drawing.Size(478, 426);
            this.dgvPokemon.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_crearPkm);
            this.panel1.Controls.Add(this.txt_alturaPkm);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_pesoPkm);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_nombrePkm);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(496, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 204);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Creación de Pokemon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Pokemon:";
            // 
            // txt_nombrePkm
            // 
            this.txt_nombrePkm.Location = new System.Drawing.Point(19, 55);
            this.txt_nombrePkm.Name = "txt_nombrePkm";
            this.txt_nombrePkm.Size = new System.Drawing.Size(166, 20);
            this.txt_nombrePkm.TabIndex = 2;
            // 
            // txt_pesoPkm
            // 
            this.txt_pesoPkm.Location = new System.Drawing.Point(19, 110);
            this.txt_pesoPkm.Name = "txt_pesoPkm";
            this.txt_pesoPkm.Size = new System.Drawing.Size(166, 20);
            this.txt_pesoPkm.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Peso Pokemon:";
            // 
            // txt_alturaPkm
            // 
            this.txt_alturaPkm.Location = new System.Drawing.Point(19, 165);
            this.txt_alturaPkm.Name = "txt_alturaPkm";
            this.txt_alturaPkm.Size = new System.Drawing.Size(166, 20);
            this.txt_alturaPkm.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Altura Pokemon:";
            // 
            // btn_crearPkm
            // 
            this.btn_crearPkm.Location = new System.Drawing.Point(260, 52);
            this.btn_crearPkm.Name = "btn_crearPkm";
            this.btn_crearPkm.Size = new System.Drawing.Size(94, 23);
            this.btn_crearPkm.TabIndex = 7;
            this.btn_crearPkm.Text = "Crear Pokemon";
            this.btn_crearPkm.UseVisualStyleBackColor = true;
            this.btn_crearPkm.Click += new System.EventHandler(this.btn_crearPkm_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_modificarPkm);
            this.panel2.Controls.Add(this.txt_alturaUpdt);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txt_pesoUpdt);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_nombreUpdt);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(496, 234);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(412, 204);
            this.panel2.TabIndex = 2;
            // 
            // btn_modificarPkm
            // 
            this.btn_modificarPkm.Location = new System.Drawing.Point(256, 52);
            this.btn_modificarPkm.Name = "btn_modificarPkm";
            this.btn_modificarPkm.Size = new System.Drawing.Size(109, 23);
            this.btn_modificarPkm.TabIndex = 7;
            this.btn_modificarPkm.Text = "Modificar Pokemon";
            this.btn_modificarPkm.UseVisualStyleBackColor = true;
            this.btn_modificarPkm.Click += new System.EventHandler(this.btn_modificarPkm_Click);
            // 
            // txt_alturaUpdt
            // 
            this.txt_alturaUpdt.Location = new System.Drawing.Point(19, 165);
            this.txt_alturaUpdt.Name = "txt_alturaUpdt";
            this.txt_alturaUpdt.Size = new System.Drawing.Size(166, 20);
            this.txt_alturaUpdt.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Altura Pokemon:";
            // 
            // txt_pesoUpdt
            // 
            this.txt_pesoUpdt.Location = new System.Drawing.Point(19, 110);
            this.txt_pesoUpdt.Name = "txt_pesoUpdt";
            this.txt_pesoUpdt.Size = new System.Drawing.Size(166, 20);
            this.txt_pesoUpdt.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Peso Pokemon:";
            // 
            // txt_nombreUpdt
            // 
            this.txt_nombreUpdt.Location = new System.Drawing.Point(19, 55);
            this.txt_nombreUpdt.Name = "txt_nombreUpdt";
            this.txt_nombreUpdt.Size = new System.Drawing.Size(166, 20);
            this.txt_nombreUpdt.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nombre Pokemon:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Modificación de Pokemon";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvPokemon);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPokemon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_crearPkm;
        private System.Windows.Forms.TextBox txt_alturaPkm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_pesoPkm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nombrePkm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_modificarPkm;
        private System.Windows.Forms.TextBox txt_alturaUpdt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_pesoUpdt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_nombreUpdt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

