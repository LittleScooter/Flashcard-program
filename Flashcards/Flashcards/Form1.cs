using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flashcards
{
    public partial class Form1 : Form
    {
        List<Deck> decks = new List<Deck>();

        bool menyCheck;
        bool nyttDeckStart = false;

        public Form1()
        {
            InitializeComponent();

            UpdateListbox();
        }

        private void UpdateListbox()
        {
            lbxDeckList.Items.Clear();
            for(int i = 0; i < decks.Count; i++)
            {
                lbxDeckList.Items.Add(decks.ElementAt(i));
            }
        }

        private void btnStudera_Click(object sender, EventArgs e)
        {
            lblTitel.Visible = false;
            btnStudera.Visible = false;
            btnVisaDeck.Visible = false;
            lbxDeckList.Visible = true;
            btnTillbaka.Visible = true;
            btnStudDeck.Visible = true;

            menyCheck = true;
        }

        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            lblTitel.Visible = true;
            btnStudera.Visible = true;
            btnVisaDeck.Visible = true;
            gbxDeckMeny.Visible = false;
            lbxDeckList.Visible = false;
            btnTillbaka.Visible = false;
            btnStudDeck.Visible = false;
        }

        private void btnVisaDeck_Click(object sender, EventArgs e)
        {
            lblTitel.Visible = false;
            btnStudera.Visible = false;
            btnVisaDeck.Visible = false;
            gbxDeckMeny.Visible = true;
            lbxDeckList.Visible = true;
            btnTillbaka.Visible = true;

            menyCheck = false;
        }

        private void btnNyttDeck_Click(object sender, EventArgs e)
        {
            gbxDeckRed.Visible = true;
            lblDeckNamn.Visible = true;
            tbxDeckNamn.Visible = true;
            btnSkapaDeck.Visible = true;
            gbxDeckMeny.Visible = false;
            lbxDeckList.Visible = false;
            btnTillbaka.Visible = false;
            btnStudDeck.Visible = false;
            lblKortFråga.Visible = false;
            lblKortSvar.Visible = false;
            tbxKortFråga.Visible = false;
            tbxKortSvar.Visible = false;
            btnAddKort4real.Visible = false;
        }

        private void tbxDeckNamn_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTillbakFrånKort_Click(object sender, EventArgs e)
        {

            if (tbxDeckNamn.Text == "" && nyttDeckStart == true)
            {
                MessageBox.Show("Du måste ge kortleken ett namn innan du lämnar");
            }
            else
            {
                gbxDeckRed.Visible = false;
                gbxDeckMeny.Visible = true;
                lbxDeckList.Visible = true;
                btnTillbaka.Visible = true;
            }
        }

        private void btnAddKort_Click(object sender, EventArgs e)
        {
            gbxDeckMeny.Visible = false;
            lbxDeckList.Visible = false;
            btnTillbaka.Visible = false;
            gbxDeckRed.Visible = true;
            btnSkapaDeck.Visible = false;
            lblDeckNamn.Visible = false;
            tbxDeckNamn.Visible = false;
            lblKortFråga.Visible = true;
            lblKortSvar.Visible = true;
            tbxKortFråga.Visible = true;
            tbxKortSvar.Visible = true;
            btnAddKort4real.Visible = true;
        }

        private void btnAddKort4real_Click(object sender, EventArgs e)
        {
            string kortFråg = tbxKortFråga.Text;
            string kortSvar = tbxKortSvar.Text;

            if (kortFråg == "" || kortSvar == "")
            {
                MessageBox.Show("Du måste fylla i båda boxarna innan du kan skapa ett kort");
            }
            else
            {
                nyttDeckStart = true;

                //Kolla igenom decket om korten har dubleter
            }
        }

        private void lbxDeckList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (menyCheck == true)
            {
                btnStudDeck.Enabled = true;
            }
            else if (menyCheck == false)
            {
                btnAddKort.Enabled = true;
                btnDelDeck.Enabled = true;
            }
        }

        //private void lbxDeckList_DoubleClick(object sender, MouseEventArgs e)
        //{
        //    gbxDeckMeny.Visible = false;
        //}

        private void btnDelDeck_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Är du säker att du vill radera decket?", "", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                decks.RemoveAt(lbxDeckList.SelectedIndex);
                UpdateListbox();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void btnStudDeck_Click(object sender, EventArgs e)
        {
            lbxDeckList.Visible = false;
            gbxDeckMeny.Visible = false;
            btnStudDeck.Visible = false;
            btnTillbaka.Visible = false;

            //visa knappar och text for att studera
        }

        private void btnSkapaDeck_Click(object sender, EventArgs e)
        {
            if (tbxDeckNamn.Text == "")
            {
                MessageBox.Show("Du måste ge decket ett namn");
            }
            else
            {
                Deck nyttDeck = new Deck(tbxDeckNamn.Text);
                decks.Add(nyttDeck);

                tbxDeckNamn.Text = "";

                UpdateListbox();

                gbxDeckRed.Visible = false;
                gbxDeckMeny.Visible = true;
                lbxDeckList.Visible = true;
                btnTillbaka.Visible = true;
            }
        }
    }
}
