using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Net;
using System.Net.Mail;

namespace SitAReflorestamento
{
    class ClassLogin
    {
        public string EmailEsquecido { get; set; }
        ClassAcessoBD bd = new ClassAcessoBD();

        public static void EnvioEmail(string email, string senha)
        {
            frmRecuperacao recuperar = new frmRecuperacao();
            var client = new SmtpClient("smtp.gmail.com", 587)//Configura parametros do gmail
            {
                Credentials = new NetworkCredential("vpaperltda@gmail.com", "33736767"), //Esse será o email que vai enviar a senha
                EnableSsl = true
            };
            try
            {
                //Mensagem que o email irá mandar para o email cadastrado
                client.Send("vpaperltda@gmail.com", email, " Recuperação de senha vPaper", " A senha que você requisitou é " + senha + ".");
            }
            catch
            {
                recuperar.SemNet();
            }
        }
        public bool EsqueceuSenha()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Usuario WHERE email LIKE '{0}'", EmailEsquecido));
            bd.Desconectar();
            if(dt.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                //Variáveis para pegar o email e a senha e mandar para o EnvioEmail
                string emailRegistrado = dt.Rows[0]["email"].ToString();
                string senhaRegistrada = dt.Rows[0]["senhaUsuario"].ToString();
                EnvioEmail(emailRegistrado, senhaRegistrada);
                return true;
            }
        }
    }
}
