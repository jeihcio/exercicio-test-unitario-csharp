using System.Linq;

namespace Alura.LeilaoOnline.Core
{
    public class MaioValor : IModalidadeAvaliacao
    {
        public Lance Avalia(Leilao leilao)
        {
            return leilao.Lances
                .DefaultIfEmpty(new Lance(null, 0))
                .OrderBy(x => x.Valor)
                .LastOrDefault();
        }
    }
}