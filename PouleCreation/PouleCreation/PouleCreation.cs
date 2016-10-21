using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PouleCreation
{
    public partial class PouleCreation : Form
    {
        Form1 mainForm;
        public PouleCreation( Form1 mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Poule newPoule = new Poule(Name.Text);
            mainForm.addToPoolList(newPoule);
        }


    }
}
