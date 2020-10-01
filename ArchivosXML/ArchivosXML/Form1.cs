using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchivosXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = @" C:\Users\laura\OneDrive\Escritorio\FORMATEO\Cosas importantes\CURSO-DAM\2DAM\3_Des_Interfaces\Ejercicios_C#\Ficheros\XML_Ejercicios-Ejemplos\ArchivosXML\ArchivosXML\authors.xml";

            // string path = @"C:\"  //Look ma, no escape
            //  string path = @"C:\programs\file.txt";
            // C:\Users\laura\OneDrive\Escritorio\FORMATEO\Cosas importantes\CURSO-DAM\2DAM\3_Des_Interfaces\Ejercicios_C#\Ficheros\XML_Ejercicios-Ejemplos\ArchivosXML\ArchivosXML

            AuthorsDataSet.ReadXml(filePath);
            dataGridView1.DataSource = AuthorsDataSet;
            dataGridView1.DataMember = "authors";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filePath = @" C:\Users\laura\OneDrive\Escritorio\FORMATEO\Cosas importantes\CURSO-DAM\2DAM\3_Des_Interfaces\Ejercicios_C#\Ficheros\XML_Ejercicios-Ejemplos\ArchivosXML\ArchivosXML\authors.xml";

            AuthorsDataSet.ReadXml(filePath);
            System.IO.StringWriter swXML = new System.IO.StringWriter();
            AuthorsDataSet.WriteXmlSchema(swXML);
            textBox1.Text = swXML.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
