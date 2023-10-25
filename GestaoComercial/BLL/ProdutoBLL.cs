using DAL;
using Models;

namespace BLL
{
    public class ProdutoBLL
    {
        private void ValidarDados(Produto _produto)
        {

        }
        public void Inserir(Produto _produto)
        {
            ValidarDados(_produto);
            new ProdutoDAL().Inserir(_produto);
        }
        public void Alterar(Produto _produto)
        {
            ValidarDados(_produto);
            new ProdutoDAL().Alterar(_produto);
        }
        public void Excluir(int _id)
        {
            new ProdutoDAL().Excluir(_id);
        }
        public List<Produto> BuscarTodos()
        {
            return new ProdutoDAL().BuscarTodos();
        }
        public Produto BuscarPorId(int _id)
        {
            return new ProdutoDAL().BuscarPorId(_id);
        }
    }
}