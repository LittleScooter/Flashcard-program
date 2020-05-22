using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net;
using System.Net.Sockets;
using System.Linq;

namespace Flashcards
{
    public partial class Form1 : Form
    {
        TcpListener lyssnare;
        TcpClient klient;
        int port = 12345;

        List<Deck> decks = new List<Deck>();

        bool menyCheck;
        bool nyttDeckStart = false;
        Deck selectedDeck;

        public Form1()
        {
            InitializeComponent();
            LäsDeckList();
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
            //Meny managment
            lblTitel.Visible = false;
            btnStudera.Visible = false;
            btnSkickaTaemot.Visible = false;
            btnVisaDeck.Visible = false;
            lbxDeckList.Visible = true;
            btnTillbaka.Visible = true;
            btnStudDeck.Visible = true;
            //Meny managment

            menyCheck = true;
        }

        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            //Meny managment
            lblTitel.Visible = true;
            btnSkickaTaemot.Visible = true;
            btnStudera.Visible = true;
            btnVisaDeck.Visible = true;
            gbxDeckMeny.Visible = false;
            lbxDeckList.Visible = false;
            btnTillbaka.Visible = false;
            btnStudDeck.Visible = false;
            //Meny managment
        }

        private void btnVisaDeck_Click(object sender, EventArgs e)
        {
            //Meny managment
            lblTitel.Visible = false;
            btnSkickaTaemot.Visible = false;
            btnStudera.Visible = false;
            btnVisaDeck.Visible = false;
            gbxDeckMeny.Visible = true;
            lbxDeckList.Visible = true;
            btnTillbaka.Visible = true;
            //Meny managment

            menyCheck = false;
        }

        private void btnNyttDeck_Click(object sender, EventArgs e)
        {
            //Meny managment
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
            //Meny managment
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
                //Meny managment
                gbxDeckRed.Visible = false;
                gbxDeckMeny.Visible = true;
                lbxDeckList.Visible = true;
                btnTillbaka.Visible = true;
                //Meny managment
            }
        }

        private void btnAddKort_Click(object sender, EventArgs e)
        {
            //Meny managment
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
            //Meny managment

            selectedDeck = decks[lbxDeckList.SelectedIndex];
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
                selectedDeck.kort.Add(new Kort(kortFråg, kortSvar)); //this code kinda gay
                tbxKortFråga.Text = "";
                tbxKortSvar.Text = "";

                
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
            selectedDeck = decks[lbxDeckList.SelectedIndex];

            if(selectedDeck.kort.Count >= 1)
            {
                //Meny managment
                lbxDeckList.Visible = false;
                gbxDeckMeny.Visible = false;
                btnStudDeck.Visible = false;
                btnTillbaka.Visible = false;
                gbxKortStud.Visible = true;
                //Meny managment

                selectedDeck.Start();
                //du suger på att ge namn, blanda inte ihop dem
                lblKortFråg.Text = selectedDeck.kortKö.Peek().fråga;
                lblKorSvar.Text = selectedDeck.kortKö.Peek().svar;
            }
            else
            {
                MessageBox.Show("Du måste lägga till kort i decket innan du kan studera");
            }
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

                //Meny managment
                gbxDeckRed.Visible = false;
                gbxDeckMeny.Visible = true;
                lbxDeckList.Visible = true;
                btnTillbaka.Visible = true;
                //Meny managment
            }
        }

        private void btnVisaSvar_Click(object sender, EventArgs e)
        {
            //Meny managment
            lblKorSvar.Visible = true;
            btnFelSvar.Visible = true;
            btnRättSvar.Visible = true;
            btnVisaSvar.Visible = false;
            //Meny managment
        }

        private void btnFelSvar_Click(object sender, EventArgs e)
        {
            //Meny managment
            selectedDeck.Next(false);
            btnFelSvar.Visible = false;
            btnRättSvar.Visible = false;
            btnVisaSvar.Visible = true;
            UpdateQuestion();
            //Meny managment
        }

        private void btnRättSvar_Click(object sender, EventArgs e)
        {
            //Meny managment
            selectedDeck.Next(true);
            btnFelSvar.Visible = false;
            btnRättSvar.Visible = false;
            btnVisaSvar.Visible = true;
            UpdateQuestion();
            //Meny managment
        }
        private void UpdateQuestion()
        {
            if (selectedDeck.kortKö.Count == 0)
            {
                MessageBox.Show("Du är klar!");
                //Meny managment
                gbxKortStud.Visible = false;
                lblTitel.Visible = true;
                btnSkickaTaemot.Visible = true;
                btnStudera.Visible = true;
                btnVisaDeck.Visible = true;
                btnStudDeck.Visible = true;
                btnTillbaka.Visible = true;
                lblKorSvar.Visible = false;
                btnStudDeck.Visible = false;
                btnTillbaka.Visible = false;
                //meny managment
                return;
            }
            lblKorSvar.Visible = false;
            lblKorSvar.Text = selectedDeck.kortKö.Peek().svar;
            lblKortFråg.Text = selectedDeck.kortKö.Peek().fråga;
        }

        private void btnSpara_Click(object sender, EventArgs e)
        {
            SparaDeckList();
            MessageBox.Show("Sparat");
        }

        private void SparaDeckList()
        {
            try
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("deckSave", FileMode.OpenOrCreate, FileAccess.Write);
                formatter.Serialize(stream, decks);
                stream.Dispose();
                
            }
            catch (Exception exp)
            {
                MessageBox.Show("" + exp);
            }
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            SparaDeckList();
        }

        private void LäsDeckList()
        {
            try
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("deckSave", FileMode.Open, FileAccess.Read);
                decks = (List<Deck>)formatter.Deserialize(stream);
                stream.Dispose();
            }
            catch (Exception exp)
            {
                MessageBox.Show("" + exp);
            }
        }
        private byte[] SkickaDeck(Deck deck)
        {
            IFormatter formatter = new BinaryFormatter();
            MemoryStream memoryStream = new MemoryStream();

            formatter.Serialize(memoryStream, deck);
            byte[] bytes = memoryStream.ToArray();
            memoryStream.Dispose();
            return bytes;
            // Skicka byte array över nätverk
        }

        private async void SendNetworkData()
        {

        }

        private void TaEmotDeck(byte[] bytes) // skickar in bytes som du har fått över nätverk
        {
            IFormatter formatter = new BinaryFormatter();

            MemoryStream stream = new MemoryStream();
            stream.Write(bytes, 0, bytes.Length);
            Deck deck = (Deck)formatter.Deserialize(stream);
            decks.Add(deck);
            UpdateListbox();
            stream.Dispose();
        }

        private void btnSkickaTaemot_Click(object sender, EventArgs e)
        {
            //meny managment
            lblTitel.Visible = false;
            btnStudera.Visible = false;
            btnSkickaTaemot.Visible = false;
            btnVisaDeck.Visible = false;
            gbxSkickaHämta.Visible = true;
            lbxDeckList.Visible = true;
            //meny managment
        }

        private async void RecieveNetworkData()
        {
            try
            {
                klient = await lyssnare.AcceptTcpClientAsync();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Text);
                return;
            }
            
        }

        private async void btnHämtaDeck_Click(object sender, EventArgs e)
        {
            try
            {
                lyssnare = new TcpListener(IPAddress.Any, port);
                lyssnare.Start();
                TcpClient client = await lyssnare.AcceptTcpClientAsync();

                byte[] lengthBuffer = new byte[4];
                await client.GetStream().ReadAsync(lengthBuffer, 0, lengthBuffer.Length);
                MemoryStream memoryStream = new MemoryStream(lengthBuffer);
                BinaryReader reader = new BinaryReader(memoryStream);
                int byteLength = reader.ReadInt32();
                byte[] deckData = new byte[byteLength];
                await client.GetStream().ReadAsync(deckData, 0, deckData.Length);
                TaEmotDeck(deckData);
                MessageBox.Show("It is recieved");
                
            }
            catch (Exception error) { MessageBox.Show(error.Message, Text); return; }
            RecieveNetworkData();
            
        }

        private async void btnSkickaDeck_Click(object sender, EventArgs e)
        {
            string ipAdress = "127.0.0.1";
            IPAddress adress = IPAddress.Parse(ipAdress);
            TcpClient client = new TcpClient();
            await client.ConnectAsync(ipAdress, port);
            byte[] bytes = SkickaDeck(decks[lbxDeckList.SelectedIndex]);
        

            MemoryStream memoryStream = new MemoryStream();
            BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
            binaryWriter.Write(bytes.Length);
            
            byte[] length = memoryStream.ToArray();

            length = length.Concat(bytes).ToArray();

            await client.GetStream().WriteAsync(length, 0, length.Length);
            MessageBox.Show("It is sent");
        }
    }
}
