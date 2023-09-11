using projeto_final_bloco_01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final_bloco_01.Repository
{
    public interface IRepository
    {
        //CRUD dos anúncios
        public void ProcuraId(int idAnuncio);
        public void ListarTudo();
        public void AddAnuncio(Estendida anuncio);
        public void Atualizar(Estendida anuncio);
        public void Deletar(Estendida anuncio);
    }
}
