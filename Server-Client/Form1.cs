namespace Server_Client {
    internal partial class Form1 : Form {
        Client Browser { get; set; }
        Server Diener { get; set; }
        public Form1(Client client, Server server) {
            InitializeComponent();
            Browser = client;
            Diener = server;
            this.LadeSeiten();
        }
        public void LadeSeiten() {
            foreach (Webpage item in Diener.Webseiten) {
                textBox3.Text += item.Name + "\r\n";
            } 
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            Browser.SucheSeite(textBox1.Text, Diener);
            textBox2.Text = Browser.ZeigeSeite();
        }

        private void textBox2_TextChanged(object sender, EventArgs e) {
            textBox1.Text = Browser.ZeigeAddresse();
        }
    }
}