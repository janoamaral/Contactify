using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contactify
{
    public partial class Form1 : Form
    {
        Importador imp = new Importador();
       

        public Form1()
        {
            InitializeComponent();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            if (oFile.ShowDialog() == DialogResult.OK)
            {
                lstCamposCsv.Items.Clear();
                imp.Path = oFile.FileName;
                

                if (imp.Cargar() == 0)
                {
                    char[] comaSeparator = new char[] { ';' };
                    if (imp.Archivo.Length > 0)
                    {
                        string[] linea = imp.Archivo[0].Split(comaSeparator);
                        int index = 0;
                        foreach (string item in linea)
                        {
                            lstCamposCsv.Items.Add(item);
                            lstCamposCsv.Items[index].Tag = index;
                            index++;
                        }
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lstCamposCsv.SelectedItems.Count == 1 && lstExportar.SelectedItems.Count == 1)
            {
                if (lstCamposCsv.SelectedItems[0].SubItems.Count <= 1)
                {
                    lstExportar.SelectedItems[0].SubItems.Add(lstCamposCsv.SelectedItems[0].Text);
                    lstExportar.SelectedItems[0].Tag = lstCamposCsv.SelectedItems[0].Tag;
                    lstCamposCsv.SelectedItems[0].Remove();
                }
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (imp.Archivo.Length > 0)
            {
                if (sFile.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }
    }
}
