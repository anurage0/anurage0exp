using OPENSCS_Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string endpointUrl = "opc.tcp://212.43.72.27:51510/UA/WipotecServer/";
            OPENSCS_Library.OPENSCS_Library openscsLibrary = new OPENSCS_Library.OPENSCS_Library();
            openscsLibrary.Connect(endpointUrl);
            //openscsLibrary.ConnectAndCall(endpointUrl);
        }
    }
}
