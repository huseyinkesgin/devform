using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIForm.Formlar.PersonelFormlar
{
    public partial class PersonelForm : DevExpress.XtraEditors.XtraForm
    {
        public PersonelForm()
        {
            InitializeComponent();
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {
            // Corrected the code to set the background color of the panel
            var panel = sender as PanelControl;
            if (panel != null)
            {
                panel.BackColor = Color.Red;
            }
        }

        private void labelControl8_Click(object sender, EventArgs e)
        {

        }
    }
}