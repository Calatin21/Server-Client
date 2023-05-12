namespace Server_Client {
    internal class Client {
        public Webpage Webseite { get; set; }
        public void SucheSeite(string name, Server server) {
            foreach (Webpage item in server.Webseiten) {
                if (item.Name == name) {
                    this.Webseite = item;
                    break;
                }
            }
        }
        public string ZeigeAddresse() {
            string ergebnis = "";
            if (Webseite != null) {
                ergebnis = $"https://www.{Webseite.Name}.de";
            }
            return ergebnis;
        }
        public string ZeigeSeite() {
            string ergebnis = "404";
            if (Webseite != null) {
                ergebnis = Webseite.Inhalt;
            }
            return ergebnis;
        }
    }
}
