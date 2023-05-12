namespace Server_Client {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Client netscape = new Client();
            Server internet = new Server();
            internet.Webseiten.Add(new() { Name = "Google", Inhalt = "404 keine Treffer" });
            internet.Webseiten.Add(new() { Name = "Zeit", Inhalt = "Putin kapituliert, europa feiert das ende des Krieges" });
            internet.Webseiten.Add(new() { Name = "Taz", Inhalt = "Donald gibt zu, dass er ein Lügner ist und von Putin bezahlt wird." });
            internet.Webseiten.Add(new() { Name = "Hotmail", Inhalt = "Ihr Posteingang ist leer." });

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(netscape, internet));
        }
    }
}