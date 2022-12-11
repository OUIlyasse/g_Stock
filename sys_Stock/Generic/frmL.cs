using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sys_Stock.Generic
{
    public partial class frmL : Form
    {
        #region CRUD

        public virtual void Ajouter()
        {
        }

        public virtual void Supprimer()
        {
        }

        public virtual void Recherche()
        {
        }

        #endregion CRUD

        public frmL()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Ajouter();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            Supprimer();
        }

        private void txtRecherche_EditValueChanged(object sender, EventArgs e)
        {
            Recherche();
        }
    }
}