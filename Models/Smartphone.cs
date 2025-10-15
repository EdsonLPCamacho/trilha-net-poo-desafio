using System;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone (substituído pela lógica abaixo)

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=====================================");
        Console.WriteLine(" Testes POO - Abstração de Celulares ");
        Console.WriteLine("=====================================");
        
        // --- TESTES NOKIA ---
        Console.WriteLine("\n--- Teste Nokia ---");
        // Cria uma instância de Nokia
        Nokia nokia = new Nokia(
            numero: "9988-7766",
            modelo: "Nokia 3310",
            imei: "111222333444555",
            memoria: 64
        );
        
        // Chama os métodos herdados e o polimórfico
        nokia.ExibirInformacoes(); 
        nokia.Ligar();            
        nokia.InstalarAplicativo("Snake Game"); 

        // --- TESTES IPHONE ---
        Console.WriteLine("\n--- Teste iPhone ---");
        // Cria uma instância de Iphone
        Iphone iphone = new Iphone(
            numero: "9123-4567",
            modelo: "iPhone 15 Pro",
            imei: "666777888999000",
            memoria: 256
        );

        // Chama os métodos herdados e o polimórfico
        iphone.ExibirInformacoes(); 
        iphone.ReceberLigacao();    
        iphone.InstalarAplicativo("iMovie"); 

        Console.WriteLine("\n=====================================");
        Console.WriteLine(" Testes Concluídos! ");
        Console.WriteLine("=====================================");
    }
}
