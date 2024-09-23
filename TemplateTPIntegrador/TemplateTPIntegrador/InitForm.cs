using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateTPIntegrador
{
    public partial class InitForm : Form
    {
        String idUsuario;

        public InitForm(String idUsuario)
        {
            this.idUsuario = idUsuario;
            InitializeComponent();
        }

        private void InitForm_Load(object sender, EventArgs e)
        {
            txtDatos.Text = idUsuario;
        }
    }
}
