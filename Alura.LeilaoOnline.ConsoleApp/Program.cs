using Alura.LeilaoOnline.Core;
using System;

namespace Alura.LeilaoOnline.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            LeilaoComVariosLances();
            LeilaoComApenasUmLance();
        }

        private static void LeilaoComApenasUmLance()
        {
            // Arranjo - cenário
            var leilao = new Leilao("Van Gogh");
            var fulano = new Interessada("Fulano", leilao);

            leilao.RecebeLance(fulano, 800);

            // Act - método sob teste
            leilao.TerminaPregao();

            // Assert 
            var valorEsperado = 800;
            var valorObtido = leilao.Ganhador.Valor;

            if (valorEsperado == valorObtido)
            {
                Console.WriteLine("TESTE PASSOU");
            }
            else
            {
                Console.WriteLine("TESTE FALHOU");
            }
        }

        private static void LeilaoComVariosLances()
        {
            // Arranjo - cenário
            var leilao = new Leilao("Van Gogh");
            var fulano = new Interessada("Fulano", leilao);
            var maria = new Interessada("Maria", leilao);

            leilao.RecebeLance(fulano, 800);
            leilao.RecebeLance(maria, 900);
            leilao.RecebeLance(fulano, 1000);
            leilao.RecebeLance(fulano, 950);

            // Act - método sob teste
            leilao.TerminaPregao();

            // Assert 
            var valorEsperado = 1000;
            var valorObtido = leilao.Ganhador.Valor;

            if (valorEsperado == valorObtido)
            {
                Console.WriteLine("TESTE PASSOU");
            }
            else
            {
                Console.WriteLine("TESTE FALHOU");
            }
        }
    }
}
