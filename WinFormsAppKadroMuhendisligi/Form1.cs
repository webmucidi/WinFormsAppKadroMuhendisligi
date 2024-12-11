namespace WinFormsAppKadroMuhendisligi
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

            List<string> genisKadro = new List<string>
            {
            "Dominik Livakovic",
            "�rfancan E�ribayat",
            "Samet Akaydin",
            "�a�lar S�y�nc�",
            "Alexander Djiku",
            "Mert M�ld�r",
            "Jayden Oosterwolde",
            "Rodrigo Becao",
            "�smail Y�ksek",
            "Mert Hakan Yanda�",
            "Fred",
            "�rfan Can Kahveci",
            "Sofyan Amrabat",
            "Sebastian Szymanski",
            "Edin Dzeko",
            "Dusan Tadic",
            "Youssef En-Nesyri",
            "Cengiz �nder",
            "Bright Osayi-Samuel",
            "Cenk Tosun",
            "Allan Saint-Maximin"

            };

            for (int i = 0; i < genisKadro.Count; i++)
            {
                comboBoxGenisKadro.Items.Add(genisKadro[i]);
            }

        }

        private void buttonKadroyaEkle_Click(object sender, EventArgs e)
        {
            if (listBoxMacKadrosu.Items.Count <= 11)
            {
                listBoxMacKadrosu.Items.Add(comboBoxGenisKadro.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Ma� kadrosunda max 11 ki�i olabilir!");
            }
            

        }

        private void buttonKadrodanCikar_Click(object sender, EventArgs e)
        {
            listBoxMacKadrosu.Items.RemoveAt(listBoxMacKadrosu.SelectedIndex);
        }

        private void buttonKadroyuTemizle_Click(object sender, EventArgs e)
        {
            listBoxMacKadrosu.Items.Clear();
        }
    }
}
