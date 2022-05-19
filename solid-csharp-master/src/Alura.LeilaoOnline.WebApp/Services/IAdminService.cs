
using Alura.LeilaoOnline.WebApp.Models;
using System.Collections.Generic;

namespace Alura.LeilaoOnline.WebApp.Services
{
    public interface IAdminService
    {
        IEnumerable<Categoria> ConsultarCategorias();
        IEnumerable<Leilao> ConsultarLeiloes();
        Leilao ConsultarLeilaoPorId(int id);
        void CadastrarLeilao(Leilao leilao);
        void ModificarLeilao(Leilao leilao);
        void RemoverLeilao(Leilao leilao);
        void IniciarPregaoDoLeilaoComId(int id);
        void FinalizarPregaoDoLeilaoComId(int id);
    }
}
