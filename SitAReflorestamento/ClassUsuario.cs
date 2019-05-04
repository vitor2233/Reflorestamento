using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SitAReflorestamento
{
    class ClassUsuario
    {
        public int CodUsuario { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string LoginU { get; set; }
        public string SenhaU { get; set; }
        public int TipoUsuario { get; set; }

        ClassAcessoBD bd = new ClassAcessoBD();

        public bool Inserir()
        {
            try
            {
                //Conecta no banco
                bd.Conectar();


                bd.ExecutarComandosSql(String.Format("INSERT INTO Usuario (tipoUsuario,email,loginUsuario,senhaUsuario," +
                    "nome,telefone,cpf)VALUES ({0},'{1}','{2}','{3}','{4}','{5}','{6}')", TipoUsuario, Email, Login, Senha, Nome, Telefone, Cpf));

                //Desconecta no banco 
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao inserir usuário. ");
            }
        }


        public bool Editar(int codUsuarioClicado)
        {
            bd.Conectar();
            bd.ExecutarComandosSql(String.Format("UPDATE Usuario SET tipoUsuario = {0},email = '{1}'," +
                "loginUsuario = '{2}',senhaUsuario = '{3}',nome = '{4}',telefone = '{5}',cpf = '{6}' WHERE codUsuario = {7}",
                TipoUsuario, Email, Login, Senha, Nome, Telefone, Cpf, codUsuarioClicado));
            bd.Desconectar();
            return true;
        }

        public bool Excluir(int codUsuarioClicado)
        {
            bd.Conectar();
            bd.ExecutarComandosSql(String.Format("DELETE FROM Usuario WHERE codUsuario = {0}",
                codUsuarioClicado));
            bd.Desconectar();
            return true;

        }

        public DataTable RetTodosUsuarios()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Usuario "));
            bd.Desconectar();
            return dt;
        }

        public DataTable RetUsuario(string nome)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Usuario WHERE nome LIKE '%{0}%'", nome));
            bd.Desconectar();
            return dt;
        }

        public DataTable VerificarUsu(string login, string senha)
        {           
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Usuario WHERE loginUsuario = '{0}' AND senhaUsuario = '{1}'", login, senha));
            bd.Conectar();
            bd.Desconectar();

            return dt;
        }
        public int VerificarCpf(string cpf)
        {
            int r;
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Usuario WHERE cpf = '{0}'", cpf));
            bd.Conectar();
            r = dt.Rows.Count;
            bd.Desconectar();
            //Se a linha foi afetada o r retorna 1
            return r;
        }
        public int VerificarEmail(string email)
        {
            int r;
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Usuario WHERE email = '{0}'", email));
            bd.Conectar();
            r = dt.Rows.Count;
            bd.Desconectar();
            //Se a linha foi afetada o r retorna 1
            return r;
        }
    }
}
