using Dominio._01_Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio._01_Core.Entidades
{
    public abstract class Veiculo : IVeiculo
    {
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public double CapacidadeTanque { get; set; }
        public double ConsumoPorKm { get; set; }

        public Veiculo(string modelo, int ano, double capacidadeTanque, double consumoPorKm)
        {
            Modelo = modelo;
            Ano = ano;
            CapacidadeTanque = capacidadeTanque;
            ConsumoPorKm = consumoPorKm;
        }

        public virtual string ExibirDetalhes()
        {
            string mensagemExibirDetalhes = $"Modelo: {Modelo}" +
                $"\n Ano: {Ano}" +
                $"\n Capacidade do Tanque: {CapacidadeTanque} litros" +
                $"\t Consumo por Km: {ConsumoPorKm} km/l";

            return mensagemExibirDetalhes;
        }

        public virtual double CalcularConsumo(double distancia)
        {
            return distancia / ConsumoPorKm;
        }
    }
}
