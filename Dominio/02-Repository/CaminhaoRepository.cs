﻿using Dapper.Contrib.Extensions;
using Dominio._01_Core.Entidades;
using Dominio._01_Core.Interfaces.Repository;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio._02_Repository
{
    public class CaminhaoRepository : ICaminhaoRepository
    {
        private readonly string ConnectionString;
        public CaminhaoRepository(IConfiguration config)
        {
            ConnectionString = config.GetConnectionString("DefaultConnection");
        }
        public void Adicionar(Caminhao carro)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Caminhao>(carro);
        }
        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Caminhao carro = BuscarPorId(id);
            connection.Delete<Caminhao>(carro);
        }
        public void Editar(Caminhao carro)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Caminhao>(carro);
        }
        public List<Caminhao> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Caminhao>().ToList();
        }
        public Caminhao BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Caminhao>(id);
        }
    }
}
