using projeto_final_bloco_01.Model;
using projeto_final_bloco_01.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final_bloco_01.Controller
{
    public class AnuncioController : IRepository
    {
        private readonly List<Principal> listaAnuncios = new();
        int numero = 0;


        public void AddAnuncio(Estendida anuncio)
        {
            listaAnuncios.Add(anuncio);
            Console.WriteLine("O anúncio número: " + anuncio.GetIdAnuncio() + " foi criada");
        }

        public void Atualizar(Estendida anuncio)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int idAnuncio)
        {
            var anuncio = BuscaNaCollection(idAnuncio);

            if (anuncio != null)
            {
                if (listaAnuncios.Remove(anuncio) == true)
                {
                    Console.WriteLine("O anúncio ID " + idAnuncio + " foi apagado com sucesso");
                }
                else
                {
                    Console.WriteLine("Anúncio não encontrado");
                }
            }
            else
            {
                Console.WriteLine("Anúncio não encontrado");
            }
        }

        public void ListarTudo()
        {
            foreach (var principal  in listaAnuncios)
            {
                principal.Visualizar();
            }
        }

        public void ProcuraId(int idAnuncio)
        {
            var anuncio = BuscaNaCollection(idAnuncio);

            if (anuncio != null)
            {
                anuncio.Visualizar();
            }
            else
            {
                Console.WriteLine("Anúncio não encontrado");
            }
        }

        //Métodos auxiliares
        public int GerarNumero()
        {
            return ++numero;
        }
        /*
        void IRepository.ProcuraId(int idAnuncio)
        {
            var anuncio = BuscaNaCollection(idAnuncio);

                if (anuncio != null)
            {
                anuncio.Visualizar();
            }
            else
            {
                Console.WriteLine("Anúncio não encontrado");
            }
        }*/

        public Principal? BuscaNaCollection(int idAnuncio)
        {
            foreach (var principal in listaAnuncios)
            {
                if (principal.GetIdAnuncio() == idAnuncio)
                {
                    return principal;
                }
            }
            return null;
        }

        public void Deletar(Estendida anuncio)
        {
            throw new NotImplementedException();
        }
    }
}
