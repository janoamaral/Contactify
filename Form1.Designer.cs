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
            System.Windows.Forms.ListViewItem listViewItem48 = new System.Windows.Forms.ListViewItem("Name");
            System.Windows.Forms.ListViewItem listViewItem49 = new System.Windows.Forms.ListViewItem("Given Name");
            System.Windows.Forms.ListViewItem listViewItem50 = new System.Windows.Forms.ListViewItem("Additional Name");
            System.Windows.Forms.ListViewItem listViewItem51 = new System.Windows.Forms.ListViewItem("Family Name");
            System.Windows.Forms.ListViewItem listViewItem52 = new System.Windows.Forms.ListViewItem("Yomi Name");
            System.Windows.Forms.ListViewItem listViewItem53 = new System.Windows.Forms.ListViewItem("Given Name Yomi");
            System.Windows.Forms.ListViewItem listViewItem54 = new System.Windows.Forms.ListViewItem("Additional Name Yomi");
            System.Windows.Forms.ListViewItem listViewItem55 = new System.Windows.Forms.ListViewItem("Family Name Yomi");
            System.Windows.Forms.ListViewItem listViewItem56 = new System.Windows.Forms.ListViewItem("Name Prefix");
            System.Windows.Forms.ListViewItem listViewItem57 = new System.Windows.Forms.ListViewItem("Name Suffix");
            System.Windows.Forms.ListViewItem listViewItem58 = new System.Windows.Forms.ListViewItem("Initials");
            System.Windows.Forms.ListViewItem listViewItem59 = new System.Windows.Forms.ListViewItem("Nickname");
            System.Windows.Forms.ListViewItem listViewItem60 = new System.Windows.Forms.ListViewItem("Short Name");
            System.Windows.Forms.ListViewItem listViewItem61 = new System.Windows.Forms.ListViewItem("Maiden Name");
            System.Windows.Forms.ListViewItem listViewItem62 = new System.Windows.Forms.ListViewItem("Birthday");
            System.Windows.Forms.ListViewItem listViewItem63 = new System.Windows.Forms.ListViewItem("Gender");
            System.Windows.Forms.ListViewItem listViewItem64 = new System.Windows.Forms.ListViewItem("Billing Information");
            System.Windows.Forms.ListViewItem listViewItem65 = new System.Windows.Forms.ListViewItem("Directory Server");
            System.Windows.Forms.ListViewItem listViewItem66 = new System.Windows.Forms.ListViewItem("Mileage");
            System.Windows.Forms.ListViewItem listViewItem67 = new System.Windows.Forms.ListViewItem("Occupation");
            System.Windows.Forms.ListViewItem listViewItem68 = new System.Windows.Forms.ListViewItem("Hobby");
            System.Windows.Forms.ListViewItem listViewItem69 = new System.Windows.Forms.ListViewItem("Sensitivity");
            System.Windows.Forms.ListViewItem listViewItem70 = new System.Windows.Forms.ListViewItem("Priority");
            System.Windows.Forms.ListViewItem listViewItem71 = new System.Windows.Forms.ListViewItem("Subject");
            System.Windows.Forms.ListViewItem listViewItem72 = new System.Windows.Forms.ListViewItem("Notes");
            System.Windows.Forms.ListViewItem listViewItem73 = new System.Windows.Forms.ListViewItem("Language");
            System.Windows.Forms.ListViewItem listViewItem74 = new System.Windows.Forms.ListViewItem("Photo");
            System.Windows.Forms.ListViewItem listViewItem75 = new System.Windows.Forms.ListViewItem("Group Membership");
            System.Windows.Forms.ListViewItem listViewItem76 = new System.Windows.Forms.ListViewItem(new string[] {
            "E-mail 1 - Type",
            "* Other"}, -1);
            System.Windows.Forms.ListViewItem listViewItem77 = new System.Windows.Forms.ListViewItem("E-mail 1 - Value");
            System.Windows.Forms.ListViewItem listViewItem78 = new System.Windows.Forms.ListViewItem("E-mail 2 - Type");
            System.Windows.Forms.ListViewItem listViewItem79 = new System.Windows.Forms.ListViewItem("E-mail 2 - Value");
            System.Windows.Forms.ListViewItem listViewItem80 = new System.Windows.Forms.ListViewItem(new string[] {
            "Phone 1 - Type",
            "Work"}, -1);
            System.Windows.Forms.ListViewItem listViewItem81 = new System.Windows.Forms.ListViewItem("Phone 1 - Value");
            System.Windows.Forms.ListViewItem listViewItem82 = new System.Windows.Forms.ListViewItem(new string[] {
            "Phone 2 - Type",
            "Mobile"}, -1);
            System.Windows.Forms.ListViewItem listViewItem83 = new System.Windows.Forms.ListViewItem("Phone 2 - Value");
            System.Windows.Forms.ListViewItem listViewItem84 = new System.Windows.Forms.ListViewItem("Phone 3 - Type");
            System.Windows.Forms.ListViewItem listViewItem85 = new System.Windows.Forms.ListViewItem("Phone 3 - Value");
            System.Windows.Forms.ListViewItem listViewItem86 = new System.Windows.Forms.ListViewItem("Address 1 - Type");
            System.Windows.Forms.ListViewItem listViewItem87 = new System.Windows.Forms.ListViewItem("Address 1 - Formatted");
            System.Windows.Forms.ListViewItem listViewItem88 = new System.Windows.Forms.ListViewItem("Address 1 - Street");
            System.Windows.Forms.ListViewItem listViewItem89 = new System.Windows.Forms.ListViewItem("Address 1 - City");
            System.Windows.Forms.ListViewItem listViewItem90 = new System.Windows.Forms.ListViewItem("Address 1 - PO Box");
            System.Windows.Forms.ListViewItem listViewItem91 = new System.Windows.Forms.ListViewItem("Address 1 - Region");
            System.Windows.Forms.ListViewItem listViewItem92 = new System.Windows.Forms.ListViewItem("Address 1 - Postal Code");
            System.Windows.Forms.ListViewItem listViewItem93 = new System.Windows.Forms.ListViewItem("Address 1 - Country");
            System.Windows.Forms.ListViewItem listViewItem94 = new System.Windows.Forms.ListViewItem("Address 1 - Extended Address");
            this.lstCamposCsv = new System.Windows.Forms.ListView();
            this.Campos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lstExportar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnExportar = new System.Windows.Forms.Button();
            this.oFile = new System.Windows.Forms.OpenFileDialog();
            this.sFile = new System.Windows.Forms.SaveFileDialog();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstCamposCsv
            // 
            this.lstCamposCsv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Campos});
            this.lstCamposCsv.FullRowSelect = true;
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
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            // lstExportar
            // 
            this.lstExportar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstExportar.FullRowSelect = true;
            this.lstExportar.HideSelection = false;
            this.lstExportar.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem48,
            listViewItem49,
            listViewItem50,
            listViewItem51,
            listViewItem52,
            listViewItem53,
            listViewItem54,
            listViewItem55,
            listViewItem56,
            listViewItem57,
            listViewItem58,
            listViewItem59,
            listViewItem60,
            listViewItem61,
            listViewItem62,
            listViewItem63,
            listViewItem64,
            listViewItem65,
            listViewItem66,
            listViewItem67,
            listViewItem68,
            listViewItem69,
            listViewItem70,
            listViewItem71,
            listViewItem72,
            listViewItem73,
            listViewItem74,
            listViewItem75,
            listViewItem76,
            listViewItem77,
            listViewItem78,
            listViewItem79,
            listViewItem80,
            listViewItem81,
            listViewItem82,
            listViewItem83,
            listViewItem84,
            listViewItem85,
            listViewItem86,
            listViewItem87,
            listViewItem88,
            listViewItem89,
            listViewItem90,
            listViewItem91,
            listViewItem92,
            listViewItem93,
            listViewItem94});
            this.lstExportar.Location = new System.Drawing.Point(359, 34);
            this.lstExportar.MultiSelect = false;
            this.lstExportar.Name = "lstExportar";
            this.lstExportar.Size = new System.Drawing.Size(410, 328);
            this.lstExportar.TabIndex = 0;
            this.lstExportar.UseCompatibleStateImageBehavior = false;
            this.lstExportar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Campo";
            this.columnHeader1.Width = 113;
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(359, 368);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(410, 23);
            this.btnExportar.TabIndex = 1;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // oFile
            // 
            this.oFile.Filter = "|*.csv";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Valor";
            this.columnHeader2.Width = 267;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 430);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.lstExportar);
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
        private System.Windows.Forms.ListView lstExportar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.OpenFileDialog oFile;
        private System.Windows.Forms.SaveFileDialog sFile;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

