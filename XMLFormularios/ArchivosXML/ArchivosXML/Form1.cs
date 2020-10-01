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
        string filePath = "datos2.xml";

        
        public Form1()
        {
            InitializeComponent();
            dataSet1.ReadXml(filePath);
        }

        //BOTÓN LEER
        private void button1_Click(object sender, EventArgs e)
        {
          
            dataGridView1.DataSource = dataSet1;
            dataGridView1.DataMember = "Empleado";
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            System.IO.StringWriter swXML = new System.IO.StringWriter();
            dataSet1.WriteXmlSchema(swXML);
            textBox1.Text = swXML.ToString();
        }
    }
}
