using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClassLibrary;
using DAO;
using Models;

namespace GestionArchive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbEtudiant.Text))
            {
                errorProvider.SetError(btnFind, "S'il vous plait, selectioner l'étudiant.");
                errorProvider.SetIconAlignment(cbEtudiant, ErrorIconAlignment.BottomRight);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbEtudiant.DataSource = null;
            var Etudiants = new EtudiantDAO().GetEtudiants();
            cbEtudiant.ValueMember = "IdEtudiant";
            cbEtudiant.DisplayMember = "FullName";
            cbEtudiant.DataSource = Etudiants;
        }

        private void cbEtudiant_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbClasse.DataSource = null;
                var IdEtudiant = int.Parse(cbEtudiant.SelectedValue.ToString());
                var Classes = new ClasseDAO().GetClassesByEtudiant(IdEtudiant);
                cbClasse.ValueMember = "IdClasse";
                cbClasse.DisplayMember = "NomClasse";
                cbClasse.DataSource = Classes;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
