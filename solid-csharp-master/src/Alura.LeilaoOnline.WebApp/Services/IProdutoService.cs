using Alura.LeilaoOnline.WebApp.Models;
using System.Collections.Generic;

namespace Alura.LeilaoOnline.WebApp.Services
{
    public interface IProdutoService
    {
        IEnumerable<Leilao> PesquisarLeiloesEmPregaoPorTermo(string termo);
        IEnumerable<CategoriaComInfoLeilao> ConsultarCategoriasComTotalDeLeiloesEmPregao();
        Categoria ConsultarCategoriaPorIdComLeiloesEmPregao(int id);
    }
}
