using Models;

namespace DAL
{
    public class ClienteDAL : DALModelo<Cliente>
    {
        public ClienteDAL()
        {
            idExceptionSalvar[Operacao.Inserir] = 1;
            idExceptionSalvar[Operacao.Alterar] = 2;
            idExceptionSalvar[Operacao.Excluir] = 3;
        }
    }
}