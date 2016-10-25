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
    public partial class PouleOverview : Form
    {
        Form1 mainForm;
        Poule currentPoule;
        public PouleOverview(Form1 mainForm, Poule currentPoule)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.currentPoule = currentPoule;
            lblPouleName.Text = currentPoule.getName();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            mainForm.closePouleOverview();
        }

        private void btAddJudoka_Click(object sender, EventArgs e)
        {
            CreateJudoka judoCreate = new CreateJudoka(this);
            judoCreate.Show();
        }

        public Poule getCurrentPoule()
        {
            return currentPoule;
        }
    }
}
