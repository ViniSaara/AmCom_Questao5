using Questao5.Domain.Entities;

namespace Questao5.Infrastructure.Sqlite
{
    public interface IDatabaseBootstrap
    {
        void Setup();
        string CriarMovimento(Movimento movimento);
    }
}