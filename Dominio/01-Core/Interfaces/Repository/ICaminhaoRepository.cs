﻿using Dominio._01_Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio._01_Core.Interfaces.Repository
{
    public interface ICaminhaoRepository
    {
        void Adicionar(Caminhao carro);
        void Remover(int id);
        void Editar(Caminhao carro);
        List<Caminhao> Listar();
        Caminhao BuscarPorId(int id);
    }
}
