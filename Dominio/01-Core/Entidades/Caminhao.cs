using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio._01_Core.Entidades
{
    [Table("Caminhoes")]
    public class Caminhao : Veiculo
    {
        public double CapacidadeCarga { get; set; }

        public Caminhao(string modelo, int ano, double capacidadeTanque, double consumoPorKm, double capacidadeCarga)
            : base(modelo, ano, capacidadeTanque, consumoPorKm)
        {
            CapacidadeCarga = capacidadeCarga;
        }

        public override string ExibirDetalhes()
        {
            string mensagemDetalhes = base.ExibirDetalhes();
            mensagemDetalhes += $"\nCapacidade de Carga: {CapacidadeCarga} toneladas";
            return mensagemDetalhes;
        }

        public override double CalcularConsumo(double distancia)
        {
            double consumoFinal = base.CalcularConsumo(distancia);
            consumoFinal *= 1 + CapacidadeCarga * 0.05;
            return consumoFinal;
        }
    }

}
