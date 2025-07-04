namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"

        public Iphone(string numero, string model, string imei, int memory) : base(numero, model, imei, memory)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalApp(string appName)
        {
            Console.WriteLine($"Instalando aplicativo {appName} no Iphone");
        }
    }
}