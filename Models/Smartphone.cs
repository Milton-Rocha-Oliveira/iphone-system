namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Number { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        protected string Model;
        protected string Imei;
        protected int Memory;
        public Smartphone(string number, string model, string imei, int memory)
        {
            Number = number;
            // TODO: Passar os parâmetros do construtor para as propriedades
            Model = model;
            Imei = imei;
            Memory = memory;
        }

        public void Calling()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceiveCall()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalApp(string appName);
    }
}