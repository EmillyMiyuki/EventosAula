using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CadastroEventos.models
{
    public class Evento
    {
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public int NumeroParticipantes { get; set; }
        public string Local { get; set; }
        public decimal CustoPorParticipante { get; set; }

        // Propriedade para calcular a duração do evento
        public int DuracaoEventoEmDias
        {
            get
            {
                // Calcula a diferença entre as datas
                return (DataTermino - DataInicio).Days;
            }
        }

        // Propriedade para calcular o custo total do evento
        public decimal CustoTotal
        {
            get
            {
                // Calcula o custo total com base no número de participantes
                return NumeroParticipantes * CustoPorParticipante;
            }
        }
    }
}
