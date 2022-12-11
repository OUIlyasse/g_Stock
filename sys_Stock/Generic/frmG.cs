﻿using System;
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
    public partial class frmG : Form
    {
        #region CRUD

        public virtual void Ajouter()
        {
        }

        public virtual void Modifier()
        {
        }

        public virtual void Supprimer()
        {
        }

        #endregion CRUD

        public frmG()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Ajouter();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            Modifier();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            Supprimer();
        }
    }
}