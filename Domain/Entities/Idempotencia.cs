namespace Questao5.Domain.Entities
{
    public class Idempotencia
    {
        public Idempotencia(string chaveIdempotencia, string requisicao, string resultado)
        {
            ChaveIdempotencia = chaveIdempotencia;
            Requisicao = requisicao;
            Resultado = resultado;
        }

        public string ChaveIdempotencia {get;set;}
        public string Requisicao { get; set; }
        public string Resultado { get; set; }
    }
}