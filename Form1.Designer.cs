namespace Contactify
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
            this.lstCamposCsv = new System.Windows.Forms.ListView();
            this.Campos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnExportar = new System.Windows.Forms.Button();
            this.oFile = new System.Windows.Forms.OpenFileDialog();
            this.sFile = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // lstCamposCsv
            // 
            this.lstCamposCsv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Campos});
            this.lstCamposCsv.HideSelection = false;
            this.lstCamposCsv.Location = new System.Drawing.Point(28, 34);
            this.lstCamposCsv.Name = "lstCamposCsv";
            this.lstCamposCsv.Size = new System.Drawing.Size(208, 328);
            this.lstCamposCsv.TabIndex = 0;
            this.lstCamposCsv.UseCompatibleStateImageBehavior = false;
            this.lstCamposCsv.View = System.Windows.Forms.View.Details;
            // 
            // Campos
            // 
            this.Campos.Text = "Campos";
            this.Campos.Width = 200;
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(28, 368);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(208, 23);
            this.btnImportar.TabIndex = 1;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(261, 164);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = ">>";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(261, 202);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "<<";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(359, 34);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(208, 328);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Campos";
            this.columnHeader1.Width = 200;
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(359, 368);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(208, 23);
            this.btnExportar.TabIndex = 1;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            // 
            // oFile
            // 
            this.oFile.Filter = "|*.csv";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 430);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lstCamposCsv);
            this.Name = "Form1";
            this.Text = "Contactify";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstCamposCsv;
        private System.Windows.Forms.ColumnHeader Campos;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.OpenFileDialog oFile;
        private System.Windows.Forms.SaveFileDialog sFile;
    }
}

