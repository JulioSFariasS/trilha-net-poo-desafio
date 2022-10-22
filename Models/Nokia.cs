namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        
        public Nokia(string numero, string modelo, string imei, int memoria)
        : base(numero, modelo, imei, memoria)
        {
            
        }

        public override void ApresentarInformacoes()
        {
            Console.WriteLine($"Smartphone Nokia {Modelo} {Memoria} GB: \nNumero: {Numero} \nIMEI: {Imei}");
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia.");
        }
    }
}