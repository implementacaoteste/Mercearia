namespace DAL
{
    public static class Conexao
    {
        private static string stringDeConexao = "User ID=SA;Initial Catalog=Mercearia;Data Source=.\\SQLEXPRESS2019;Password=Senailab02";
        public static string StringDeConexao
        {
            get
            {
                return stringDeConexao;
            }
        }
    }
}
