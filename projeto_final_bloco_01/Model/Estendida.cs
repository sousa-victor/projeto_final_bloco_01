using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final_bloco_01.Model
{
    public class Estendida : Principal
    {
        private bool exotico;

        public Estendida(int idAnuncio, int ano, int numLugares, string marca, string modelo, string categoria, bool exotico)
            : base(idAnuncio, ano, numLugares, marca, modelo, categoria)
        {
            this.exotico = exotico;
        }

        public bool GetExotico()
        {
            return exotico;
        }

        public void SetExotico(bool exotico)
        {
            this.exotico = exotico;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            if (GetExotico())
            {
                Console.WriteLine("Este é um carro exótico, altíssima exclusividade!");
            }
            else {
                Console.WriteLine("Veículo com procedência e garantia.");
            }
        }
    }
}
