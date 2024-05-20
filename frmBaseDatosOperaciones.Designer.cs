namespace pryEstructuraDeDatos
{
    partial class frmBaseDatosOperaciones
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
            this.dgvBaseDatos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnJuntar = new System.Windows.Forms.Button();
            this.btnProyeccionmultiatributo = new System.Windows.Forms.Button();
            this.btnProyeccionSimple = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSeleccionConvulsion = new System.Windows.Forms.Button();
            this.btnSeleccionMultiatributo = new System.Windows.Forms.Button();
            this.btnSeleccionSimple = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDiferencia = new System.Windows.Forms.Button();
            this.btnInterseccion = new System.Windows.Forms.Button();
            this.btnUnion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseDatos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBaseDatos
            // 
            this.dgvBaseDatos.AllowUserToAddRows = false;
            this.dgvBaseDatos.AllowUserToDeleteRows = false;
            this.dgvBaseDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaseDatos.Location = new System.Drawing.Point(17, 16);
            this.dgvBaseDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvBaseDatos.Name = "dgvBaseDatos";
            this.dgvBaseDatos.ReadOnly = true;
            this.dgvBaseDatos.RowHeadersWidth = 51;
            this.dgvBaseDatos.Size = new System.Drawing.Size(965, 367);
            this.dgvBaseDatos.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnJuntar);
            this.groupBox1.Controls.Add(this.btnProyeccionmultiatributo);
            this.groupBox1.Controls.Add(this.btnProyeccionSimple);
            this.groupBox1.Location = new System.Drawing.Point(17, 404);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(297, 158);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaiones de Proyecciòn - SELECT";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnJuntar
            // 
            this.btnJuntar.Location = new System.Drawing.Point(8, 110);
            this.btnJuntar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnJuntar.Name = "btnJuntar";
            this.btnJuntar.Size = new System.Drawing.Size(280, 28);
            this.btnJuntar.TabIndex = 2;
            this.btnJuntar.Text = "Juntar";
            this.btnJuntar.UseVisualStyleBackColor = true;
            this.btnJuntar.Click += new System.EventHandler(this.btnJuntar_Click);
            // 
            // btnProyeccionmultiatributo
            // 
            this.btnProyeccionmultiatributo.Location = new System.Drawing.Point(9, 74);
            this.btnProyeccionmultiatributo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProyeccionmultiatributo.Name = "btnProyeccionmultiatributo";
            this.btnProyeccionmultiatributo.Size = new System.Drawing.Size(280, 28);
            this.btnProyeccionmultiatributo.TabIndex = 1;
            this.btnProyeccionmultiatributo.Text = "Proyección multiatributo";
            this.btnProyeccionmultiatributo.UseVisualStyleBackColor = true;
            this.btnProyeccionmultiatributo.Click += new System.EventHandler(this.btnProyeccionmultiatributo_Click);
            // 
            // btnProyeccionSimple
            // 
            this.btnProyeccionSimple.Location = new System.Drawing.Point(9, 38);
            this.btnProyeccionSimple.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProyeccionSimple.Name = "btnProyeccionSimple";
            this.btnProyeccionSimple.Size = new System.Drawing.Size(280, 28);
            this.btnProyeccionSimple.TabIndex = 0;
            this.btnProyeccionSimple.Text = "Proyección simple";
            this.btnProyeccionSimple.UseVisualStyleBackColor = true;
            this.btnProyeccionSimple.Click += new System.EventHandler(this.btnProyeccionSimple_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSeleccionConvulsion);
            this.groupBox2.Controls.Add(this.btnSeleccionMultiatributo);
            this.groupBox2.Controls.Add(this.btnSeleccionSimple);
            this.groupBox2.Location = new System.Drawing.Point(353, 404);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(297, 158);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operaiones de Selección - WHERE";
            // 
            // btnSeleccionConvulsion
            // 
            this.btnSeleccionConvulsion.Location = new System.Drawing.Point(8, 110);
            this.btnSeleccionConvulsion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSeleccionConvulsion.Name = "btnSeleccionConvulsion";
            this.btnSeleccionConvulsion.Size = new System.Drawing.Size(280, 28);
            this.btnSeleccionConvulsion.TabIndex = 2;
            this.btnSeleccionConvulsion.Text = "Selección por convulsión";
            this.btnSeleccionConvulsion.UseVisualStyleBackColor = true;
            this.btnSeleccionConvulsion.Click += new System.EventHandler(this.btnSeleccionConvulsion_Click);
            // 
            // btnSeleccionMultiatributo
            // 
            this.btnSeleccionMultiatributo.Location = new System.Drawing.Point(9, 74);
            this.btnSeleccionMultiatributo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSeleccionMultiatributo.Name = "btnSeleccionMultiatributo";
            this.btnSeleccionMultiatributo.Size = new System.Drawing.Size(280, 28);
            this.btnSeleccionMultiatributo.TabIndex = 1;
            this.btnSeleccionMultiatributo.Text = "Selección multiatributo";
            this.btnSeleccionMultiatributo.UseVisualStyleBackColor = true;
            this.btnSeleccionMultiatributo.Click += new System.EventHandler(this.btnSeleccionMultiatributo_Click);
            // 
            // btnSeleccionSimple
            // 
            this.btnSeleccionSimple.Location = new System.Drawing.Point(9, 38);
            this.btnSeleccionSimple.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSeleccionSimple.Name = "btnSeleccionSimple";
            this.btnSeleccionSimple.Size = new System.Drawing.Size(280, 28);
            this.btnSeleccionSimple.TabIndex = 0;
            this.btnSeleccionSimple.Text = "Selección simple";
            this.btnSeleccionSimple.UseVisualStyleBackColor = true;
            this.btnSeleccionSimple.Click += new System.EventHandler(this.btnSeleccionSimple_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDiferencia);
            this.groupBox3.Controls.Add(this.btnInterseccion);
            this.groupBox3.Controls.Add(this.btnUnion);
            this.groupBox3.Location = new System.Drawing.Point(685, 404);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(297, 158);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operaiones Algebricas";
            // 
            // btnDiferencia
            // 
            this.btnDiferencia.Location = new System.Drawing.Point(8, 110);
            this.btnDiferencia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDiferencia.Name = "btnDiferencia";
            this.btnDiferencia.Size = new System.Drawing.Size(280, 28);
            this.btnDiferencia.TabIndex = 2;
            this.btnDiferencia.Text = "Diferencia";
            this.btnDiferencia.UseVisualStyleBackColor = true;
            this.btnDiferencia.Click += new System.EventHandler(this.btnDiferencia_Click);
            // 
            // btnInterseccion
            // 
            this.btnInterseccion.Location = new System.Drawing.Point(9, 74);
            this.btnInterseccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInterseccion.Name = "btnInterseccion";
            this.btnInterseccion.Size = new System.Drawing.Size(280, 28);
            this.btnInterseccion.TabIndex = 1;
            this.btnInterseccion.Text = "Intersección";
            this.btnInterseccion.UseVisualStyleBackColor = true;
            this.btnInterseccion.Click += new System.EventHandler(this.btnInterseccion_Click);
            // 
            // btnUnion
            // 
            this.btnUnion.Location = new System.Drawing.Point(9, 38);
            this.btnUnion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(280, 28);
            this.btnUnion.TabIndex = 0;
            this.btnUnion.Text = "Unión";
            this.btnUnion.UseVisualStyleBackColor = true;
            this.btnUnion.Click += new System.EventHandler(this.btnUnion_Click);
            // 
            // frmBaseDatosOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 585);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvBaseDatos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBaseDatosOperaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base de Datos";
            this.Load += new System.EventHandler(this.frmBaseDatosOperaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseDatos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBaseDatos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnJuntar;
        private System.Windows.Forms.Button btnProyeccionmultiatributo;
        private System.Windows.Forms.Button btnProyeccionSimple;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSeleccionConvulsion;
        private System.Windows.Forms.Button btnSeleccionMultiatributo;
        private System.Windows.Forms.Button btnSeleccionSimple;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDiferencia;
        private System.Windows.Forms.Button btnInterseccion;
        private System.Windows.Forms.Button btnUnion;
    }
}