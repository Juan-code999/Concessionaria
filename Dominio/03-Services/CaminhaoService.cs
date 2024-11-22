using Dominio._01_Core.Entidades;
using Dominio._01_Core.Interfaces.Repository;
using Dominio._01_Core.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio._03_Services
{
    public class CaminhaoService : ICaminhaoService
    {
        private readonly ICaminhaoRepository repositorio;
        public CaminhaoService(ICaminhaoRepository repos)
        {
            repositorio = repos;
        }

        public void Adicionar(Caminhao caminhao)
        {
            repositorio.Adicionar(caminhao);
        }

        public Caminhao BuscarPorId(int id)
        {
            return repositorio.BuscarPorId(id);
        }

        public void Editar(Caminhao caminhao)
        {
            repositorio.Editar(caminhao);
        }

        public List<Caminhao> Listar()
        {
            return repositorio.Listar();
        }

        public void Remover(int id)
        {
            repositorio.Remover(id);
        }
    }
}
