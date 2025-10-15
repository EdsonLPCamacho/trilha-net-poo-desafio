using System;
using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=====================================");
        Console.WriteLine(" Testes POO - Abstração de Celulares ");
        Console.WriteLine("=====================================");
        
        // --- TESTES NOKIA ---
        Console.WriteLine("\n--- Teste Nokia ---");
        Nokia nokia = new Nokia(
            numero: "9988-7766",
            modelo: "Nokia 3310",
            imei: "111222333444555",
            memoria: 64
        );
        
        nokia.ExibirInformacoes(); 
        nokia.Ligar();            
        nokia.InstalarAplicativo("Snake Game"); 

        // --- TESTES IPHONE ---
        Console.WriteLine("\n--- Teste iPhone ---");
        Iphone iphone = new Iphone(
            numero: "9123-4567",
            modelo: "iPhone 15 Pro",
            imei: "666777888999000",
            memoria: 256
        );

        iphone.ExibirInformacoes(); 
        iphone.ReceberLigacao();    
        iphone.InstalarAplicativo("iMovie"); 

        Console.WriteLine("\n=====================================");
        Console.WriteLine(" Testes Concluídos! ");
        Console.WriteLine("=====================================");
    }
}
