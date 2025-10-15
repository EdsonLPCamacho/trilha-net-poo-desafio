using System;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private string Modelo { get; set; }
        private string Imei { get; set; }
        private int Memoria { get; set; }

        // Construtor completo para que as classes filhas possam inicializar todas as propriedades
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        // Construtor original com apenas 'numero' (mantido caso o projeto o exija, mas o acima é usado pelas classes filhas)
        public Smartphone(string numero)
        {
             Numero = numero;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);

        // Método auxiliar para testes (adicionado para exibir as informações)
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Número: {Numero}");
            Console.WriteLine($"IMEI: {Imei}");
            Console.WriteLine($"Memória: {Memoria}GB");
        }
    }
}
