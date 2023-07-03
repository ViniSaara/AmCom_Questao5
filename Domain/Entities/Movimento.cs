namespace Questao5.Domain.Entities
{
    public class Movimento
    {
        public Movimento(string idMovimento, Guid idContaCorrente, string tipoMovimento, decimal valor)
        {
            IdMovimento = idMovimento;
            IdContaCorrente = idContaCorrente;
            DataMovimento = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            TipoMovimento = tipoMovimento;
            Valor = valor;
        }

        public string IdMovimento { get; set; }
        public Guid IdContaCorrente{ get; set; }
        public string DataMovimento{ get; set; }
        public string TipoMovimento { get; set; }
        public decimal Valor { get; set; }
    }
}