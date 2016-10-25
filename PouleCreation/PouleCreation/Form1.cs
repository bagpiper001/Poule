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
    public partial class Form1 : Form
    {
        List<Poule> pouleList;
        PouleCreation pouleForm;
        PouleOverview pouleOverview;
        public Form1()
        {
            InitializeComponent();
            pouleList = new List<Poule>();

        }

        private void createPoule_Click(object sender, EventArgs e)
        {
            if (pouleForm == null)
            {
                pouleForm = new PouleCreation(this);
                pouleForm.Show();
            }
        }

        private void lbPoule_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.lbPoule.IndexFromPoint(e.Location);
            if(index != ListBox.NoMatches)
            {
                Poule currentPoule;
                foreach(Poule p in pouleList)
                {
                    if (p.getName() == lbPoule.SelectedItem.ToString())
                    {
                        currentPoule = new Poule();
                        currentPoule = p;
                        pouleOverview = new PouleOverview(this, currentPoule);
                        break;
                    }
                }
                if (pouleOverview != null)
                {
                    pouleOverview.Show();
                }
            }
        }

        public void addToPoolList(Poule pouleToAdd)
        {
            pouleList.Add(pouleToAdd);
            lbPoule.Items.Add(pouleToAdd.getName());
            pouleForm.Close();
            pouleForm = null;
        }

        public void closePouleOverview()
        {
            pouleOverview.Close();
            pouleOverview = null;
        }
    }
}
