﻿namespace Questao5.Domain.Entities
{
    public class GuidaCorrente
    {
        public Guid IdContaCorrente { get; set; }
        public int Numero { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
    }
}