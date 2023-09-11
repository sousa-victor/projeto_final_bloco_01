using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final_bloco_01.Model
{
    public abstract class Principal
    {
        private int idAnuncio;
        private int ano;
        private int numLugares;
        private string marca;
        private string modelo;
        private string categoria;


        public Principal(int idAnuncio, int ano, int numLugares, string marca, string modelo, string categoria)
        {
            this.idAnuncio = idAnuncio;
            this.ano = ano;
            this.numLugares = numLugares;
            this.marca = marca;
            this.modelo = modelo;
            this.categoria = categoria;
        }

        public int GetIdAnuncio()
        {
            return idAnuncio;
        }
        public void SetIdAnuncio(int idAnuncio)
        {
            this.idAnuncio = idAnuncio;
        }

        public int GetAno()
        {
            return ano;
        }
        public void SetAno(int ano)
        {
            this.ano = ano;
        }

        public int GetNumLugares()
        {
            return numLugares;
        }
        public void SetNumLugares(int numLugares)
        {
            this.numLugares= numLugares;
        }

        public string GetMarca()
        {
            return marca;
        }
        public void SetMarca(string marca)
        {
            this.marca = marca;
        }

        public string GetModelo()
        {
            return modelo;
        }
        public void SetModelo(string modelo)
        {
            this.modelo = modelo;
        }

        public string GetCategoria()
        {
            return categoria;
        }
        public void SetCategoria(string categoria)
        {
            this.categoria = categoria;
        }

        public virtual void Visualizar()
        {
            Console.WriteLine("Anúncio nº" + this.idAnuncio);
            Console.WriteLine("Marca: " + this.marca);
            Console.WriteLine("Modelo: " + this.modelo);
            Console.WriteLine("Ano: " + this.ano);
            Console.WriteLine("Categoria: " + this.categoria);
            Console.WriteLine("Número de lugares: " + this.numLugares);
        }


    }
}
