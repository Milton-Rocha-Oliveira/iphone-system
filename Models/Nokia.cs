namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {

        public Nokia(string numero, string model, string imei, int memory) : base(numero, model, imei, memory)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalApp(string appName)
        {
            Console.WriteLine($"Instalando o aplicativo {appName} no Nokia");
        }
    }
}