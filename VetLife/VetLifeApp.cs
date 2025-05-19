
using System;
using System.Windows.Forms;
using VetLife.Core;
using VetLife.DataAccess;
using VetLife.Core;
using VetLife.DataAccess;

namespace VetLife
{
    public partial class VetLifeApp : Form
    {
        private string rolCurent = "Administrator";

        public VetLifeApp()
        {
            InitializeComponent();
            listBox1.SelectedIndex = 0;
            AplicarePermisiuni();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string rolSelectat = listBox1.SelectedItem?.ToString();
            if (rolSelectat == null) return;

            switch (rolSelectat)
            {
                case "Administrator":
                    rolCurent = "Administrator";
                    break;
                case "Medic veterinar":
                    rolCurent = "MedicVeterinar";
                    break;
                case "Asistent":
                    rolCurent = "Asistent";
                    break;
                case "Operator":
                    rolCurent = "Receptioner";
                    break;
                default:
                    MessageBox.Show("Rol necunoscut.");
                    return;
            }

            AplicarePermisiuni();
        }

        private void AplicarePermisiuni()
        {
            btnProprietar.Enabled = false;
            btnAnimal.Enabled = false;
            btnConsultatie.Enabled = false;
            btnConsultatiiV.Enabled = false;
            btnPersonal.Enabled = false;
            bool poateAdaugaAnimal = rolCurent == "Administrator" || rolCurent == "Receptioner";

            switch (rolCurent)
            {
                case "Administrator":
                    btnProprietar.Enabled = true;
                    btnAnimal.Enabled = true;
                    btnConsultatie.Enabled = true;
                    btnConsultatiiV.Enabled = true;
                    btnPersonal.Enabled = true;
                    txtNumeAnimal.Enabled = poateAdaugaAnimal;
                    txtSpecie.Enabled = poateAdaugaAnimal;
                    txtRasa.Enabled = poateAdaugaAnimal;
                    txtVarsta.Enabled = poateAdaugaAnimal;
                    txtGreutate.Enabled = poateAdaugaAnimal;
                    cmbProprietar.Enabled = poateAdaugaAnimal;
                    break;

                case "MedicVeterinar":
                    btnConsultatiiV.Enabled = true;
                    break;

                case "Asistent":
                    btnConsultatie.Enabled = true;
                    break;

                case "Receptioner":
                    txtNumeAnimal.Enabled = poateAdaugaAnimal;
                    txtSpecie.Enabled = poateAdaugaAnimal;
                    txtRasa.Enabled = poateAdaugaAnimal;
                    txtVarsta.Enabled = poateAdaugaAnimal;
                    txtGreutate.Enabled = poateAdaugaAnimal;
                    btnProprietar.Enabled = true;
                    btnAnimal.Enabled = true;
                    btnConsultatie.Enabled = true;
                    break;
            }
        }

        private void btnIesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProprietar_Click(object sender, EventArgs e)
        {
            try
            {
                var proprietari = ProprietarRepository.GetAll();
                if (proprietari.Count == 0)
                {
                    MessageBox.Show("Nu există proprietari înregistrați.");
                    return;
                }

                string output = "Proprietari:\n";
                foreach (var p in proprietari)
                    output += $"- {p.Nume} | {p.Email} | {p.Telefon}\n";
                MessageBox.Show(output, "Lista Proprietari");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare: " + ex.Message);
            }
        }

        private void btnAnimal_Click(object sender, EventArgs e)
        {
            try
            {
                var animal = new Animal
                {
                    Nume = txtNumeAnimal.Text,
                    Specie = txtSpecie.Text,
                    Rasa = txtRasa.Text,
                    Varsta = int.Parse(txtVarsta.Text),
                    Greutate = double.Parse(txtGreutate.Text),
                    ProprietarId = 11
                };

                AnimalRepository.Adauga(animal);
                MessageBox.Show("Animal adăugat cu succes!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la adăugare animal: " + ex.Message);
            }
        }

        private void btnConsultatie_Click(object sender, EventArgs e)
        {
            try
            {
                var animale = AnimalRepository.GetAll();
                if (animale.Count == 0)
                {
                    MessageBox.Show("Nu există animale pentru a adăuga o consultație.");
                    return;
                }

                var animal = animale[0]; // exemplu simplificat
                var consultatie = new Consultatie
                {
                    AnimalId = animal.Id,
                    Data_consultatie = DateTime.Now.ToString("yyyy-MM-dd"),
                    Simptome = "Letargie",
                    Diagnostic = "Gastroenterită",
                    Tratament = "Regim alimentar + hidratare"
                };

                ConsultatieRepository.Adauga(consultatie);
                MessageBox.Show("Consultație adăugată pentru " + animal.Nume);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la salvarea consultației: " + ex.Message);
            }
        }

        private void btnConsultatiiV_Click(object sender, EventArgs e)
        {
            try
            {
                var consultatii = ConsultatieRepository.GetAll();
                if (consultatii.Count == 0)
                {
                    MessageBox.Show("Nu există consultații înregistrate.");
                    return;
                }

                string output = "Consultații:\n";
                foreach (var c in consultatii)
                    output += $"- {c.Data_consultatie}: {c.Simptome}, Diagnostic: {c.Diagnostic}, Tratament: {c.Tratament}\n";
                MessageBox.Show(output, "Lista Consultații");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la citirea consultațiilor: " + ex.Message);
            }
        }

        private void VetLifeApp_Load(object sender, EventArgs e)
        {
            AplicarePermisiuni();
        }

        private void txtNumeAnimal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSpecie_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRasa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVarsta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGreutate_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbProprietar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
