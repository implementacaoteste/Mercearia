using Models;

namespace DAL
{
    public class ProdutoDAL : DALModelo<Produto>
    {
        public ProdutoDAL()
        {
            idExceptionSalvar[Operacao.Inserir] = 1054;
            idExceptionSalvar[Operacao.Alterar] = 1055;
            idExceptionSalvar[Operacao.Excluir] = 1056;
        }
    }
}