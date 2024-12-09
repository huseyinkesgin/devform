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
            panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
        }

        private void buttonKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}