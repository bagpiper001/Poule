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
    public partial class CreateJudoka : Form
    {
        public PouleOverview pouleOverview;
        static string[] belt = new string[] { "White", "Yellow", "Orange", "Green", "Blue", "Brown", "Black" };
        public CreateJudoka(PouleOverview pouleOverview)
        {
            InitializeComponent();
            this.pouleOverview = pouleOverview;
            cbBelt.Items.AddRange(belt);
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            Poule currentPoule = pouleOverview.getCurrentPoule();
            if(tbName.Text != null && tbWeight.Text != null && cbBelt.SelectedValue != null)
            {
                Judoka newJudoka = new Judoka(tbName.Text, cbBelt.SelectedValue.ToString(), Convert.ToInt32(tbWeight.Text), currentPoule);
            } else
            {
                MessageBox.Show("Please make sure all the fields are filled.");
            }
        }
    }
}
