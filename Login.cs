using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLogin
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            pnContainer.BackColor = Color.FromArgb(59, 255, 255, 255);
            Titulo();
        }
        private void Titulo()
        {
            this.tbTitulo.Font = new Font("Arial Rounded MT Bold", 12, FontStyle.Bold);
            this.tbTitulo.TextAlign = ContentAlignment.MiddleCenter;
            this.tbTitulo.Padding = new Padding(0, 3, 0, 3);
            this.tbTitulo.Height = 40;
        }
    }
}
