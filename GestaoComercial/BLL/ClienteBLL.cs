﻿using DAL;
using Models;

namespace BLL
{
    public class ClienteBLL
    {
        private void ValidarDados(Cliente _cliente)
        {

        }
        public void Inserir(Cliente _cliente)
        {
            ValidarDados(_cliente);
            new ClienteDAL().Inserir(_cliente);
        }
        public void Alterar(Cliente _cliente)
        {
            ValidarDados(_cliente);
            new ClienteDAL().Alterar(_cliente);
        }
        public void Excluir(int _id)
        {
            new ClienteDAL().Excluir(_id);
        }
        public List<Cliente> BuscarTodos()
        {
            return new ClienteDAL().BuscarTodos();
        }
        public Cliente BuscarPorId(int _id)
        {
            return new ClienteDAL().BuscarPorId(_id);
        }
    }
}