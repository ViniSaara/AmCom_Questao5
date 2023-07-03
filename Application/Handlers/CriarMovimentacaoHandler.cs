using Questao5.Application.Commands.Requests;
using Questao5.Application.Commands.Responses;
using Questao5.Domain.Entities;
using Questao5.Infrastructure.Sqlite;

namespace Questao5.Application.Handlers
{
    public class CriarMovimentacaoHandler : ICriarMovimentacaoHandler
    {
        private IDatabaseBootstrap _repository;

        public CriarMovimentacaoHandler(IDatabaseBootstrap repository)
        {
            _repository = repository;
        }

        public CriarMovimentacaoResponse Handle(CriarMovimentacaoRequest request)
        {
            Movimento movimento = new Movimento(Guid.NewGuid().ToString(), request.IdContaCorrente, request.TipoMovimento, request.Valor);
            var teste = _repository.CriarMovimento(movimento);
            return new CriarMovimentacaoResponse();
        }
    }
}