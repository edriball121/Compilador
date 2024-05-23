namespace Compilador
{
    partial class VistaCompilador
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
            this.lbl_tittle = new System.Windows.Forms.Label();
            this.btn_load_file = new System.Windows.Forms.Button();
            this.gbEntry = new System.Windows.Forms.GroupBox();
            this.txt_entry = new System.Windows.Forms.TextBox();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_compile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_lexico = new System.Windows.Forms.TextBox();
            this.txt_semantico = new System.Windows.Forms.TextBox();
            this.btn_limpiar_salias = new System.Windows.Forms.Button();
            this.gbEntry.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_tittle
            // 
            this.lbl_tittle.AutoSize = true;
            this.lbl_tittle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tittle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_tittle.Location = new System.Drawing.Point(437, 0);
            this.lbl_tittle.Name = "lbl_tittle";
            this.lbl_tittle.Size = new System.Drawing.Size(214, 40);
            this.lbl_tittle.TabIndex = 0;
            this.lbl_tittle.Text = "Compilador";
            // 
            // btn_load_file
            // 
            this.btn_load_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load_file.Location = new System.Drawing.Point(12, 53);
            this.btn_load_file.Name = "btn_load_file";
            this.btn_load_file.Size = new System.Drawing.Size(126, 41);
            this.btn_load_file.TabIndex = 2;
            this.btn_load_file.Text = "Cargar";
            this.btn_load_file.UseVisualStyleBackColor = true;
            this.btn_load_file.Click += new System.EventHandler(this.Cargar_Click);
            // 
            // gbEntry
            // 
            this.gbEntry.Controls.Add(this.txt_entry);
            this.gbEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEntry.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbEntry.Location = new System.Drawing.Point(12, 100);
            this.gbEntry.Name = "gbEntry";
            this.gbEntry.Size = new System.Drawing.Size(514, 533);
            this.gbEntry.TabIndex = 3;
            this.gbEntry.TabStop = false;
            this.gbEntry.Text = "Entrada";
            // 
            // txt_entry
            // 
            this.txt_entry.Location = new System.Drawing.Point(6, 27);
            this.txt_entry.Multiline = true;
            this.txt_entry.Name = "txt_entry";
            this.txt_entry.Size = new System.Drawing.Size(500, 490);
            this.txt_entry.TabIndex = 4;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(403, 53);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(123, 41);
            this.btn_limpiar.TabIndex = 4;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_compile
            // 
            this.btn_compile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_compile.Location = new System.Drawing.Point(213, 53);
            this.btn_compile.Name = "btn_compile";
            this.btn_compile.Size = new System.Drawing.Size(112, 41);
            this.btn_compile.TabIndex = 5;
            this.btn_compile.Text = "Procesar";
            this.btn_compile.UseVisualStyleBackColor = true;
            this.btn_compile.Click += new System.EventHandler(this.btn_compile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_lexico);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(557, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 222);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lexico";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_semantico);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(557, 328);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(538, 305);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Semantico";
            // 
            // txt_lexico
            // 
            this.txt_lexico.Location = new System.Drawing.Point(16, 25);
            this.txt_lexico.Multiline = true;
            this.txt_lexico.Name = "txt_lexico";
            this.txt_lexico.Size = new System.Drawing.Size(500, 183);
            this.txt_lexico.TabIndex = 5;
            // 
            // txt_semantico
            // 
            this.txt_semantico.Location = new System.Drawing.Point(16, 25);
            this.txt_semantico.Multiline = true;
            this.txt_semantico.Name = "txt_semantico";
            this.txt_semantico.Size = new System.Drawing.Size(500, 252);
            this.txt_semantico.TabIndex = 6;
            // 
            // btn_limpiar_salias
            // 
            this.btn_limpiar_salias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar_salias.Location = new System.Drawing.Point(950, 44);
            this.btn_limpiar_salias.Name = "btn_limpiar_salias";
            this.btn_limpiar_salias.Size = new System.Drawing.Size(123, 41);
            this.btn_limpiar_salias.TabIndex = 8;
            this.btn_limpiar_salias.Text = "Limpiar";
            this.btn_limpiar_salias.UseVisualStyleBackColor = true;
            this.btn_limpiar_salias.Click += new System.EventHandler(this.btn_limpiar_salias_Click);
            // 
            // VistaCompilador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1122, 638);
            this.Controls.Add(this.btn_limpiar_salias);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_compile);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.gbEntry);
            this.Controls.Add(this.btn_load_file);
            this.Controls.Add(this.lbl_tittle);
            this.Name = "VistaCompilador";
            this.Text = "Compilador";
            this.gbEntry.ResumeLayout(false);
            this.gbEntry.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tittle;
        private System.Windows.Forms.Button btn_load_file;
        private System.Windows.Forms.GroupBox gbEntry;
        private System.Windows.Forms.TextBox txt_entry;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_compile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_lexico;
        private System.Windows.Forms.TextBox txt_semantico;
        private System.Windows.Forms.Button btn_limpiar_salias;
    }
}

