using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCourses.Controls
{
    public partial class panelProfesseurs : UserControl
    {
        public panelProfesseurs()
        {
            InitializeComponent();
        }

        private void PanelProfesseurs_Load(object sender, EventArgs e)//load
        {
            this.ListeEtudiants.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            ListeEtudiants.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Bold);
        }
    }
}
