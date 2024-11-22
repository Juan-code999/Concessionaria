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
    public class CarroService : ICarroService
    {
        private readonly ICarroRespository repositorio;
        public CarroService(ICarroRespository repos)
        {
            repositorio = repos;
        }

        public void Adicionar(Carro carro)
        {
            repositorio.Adicionar(carro);
        }

        public Carro BuscarPorId(int id)
        {
            return repositorio.BuscarPorId(id);
        }

        public void Editar(Carro carro)
        {
            repositorio.Editar(carro);
        }

        public List<Carro> Listar()
        {
            return repositorio.Listar();
        }

        public void Remover(int id)
        {
            repositorio.Remover(id);
        }
    }
}
