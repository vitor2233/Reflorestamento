using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SitAReflorestamento
{
    class ClassDesmatamento
    {
        public int Ano { get; set; }
        public string Estado { get; set; }
        public int NumArvores{ get; set; }
        public int VolumeM3 { get; set; }
        public double ArvoresARepor { get; set; }
        public int ValorAPagar { get; set; }

        ClassAcessoBD bd = new ClassAcessoBD();

        public bool Inserir()
        {
            try
            {
                //Conecta no banco
                bd.Conectar();


                bd.ExecutarComandosSql(String.Format("INSERT INTO Reflorestamento (ano,estado,numArvoresCortadas," +
                    "volumeM3)VALUES ({0},'{1}',{2},{3})", Ano, Estado, NumArvores, VolumeM3));

                //Desconecta no banco 
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao inserir usuário. ");
            }
        }

        public DataTable RetTodosUsuarios()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Reflorestamento "));
            bd.Desconectar();
            return dt;
        }

        public bool Editar(int codCalculoClicado)
        {
            bd.Conectar();
            bd.ExecutarComandosSql(String.Format("UPDATE Reflorestamento SET ano = {0},estado = '{1}'," +
                "numArvoresCortadas = {2},volumeM3 = {3} WHERE codCalculo = {4}",
                 Ano, Estado, NumArvores, VolumeM3,codCalculoClicado));
            bd.Desconectar();
            return true;
        }

        public bool Excluir(int codDesmatamentoClicado)
        {
            bd.Conectar();
            bd.ExecutarComandosSql(String.Format("DELETE FROM Reflorestamento WHERE codCalculo = {0}",
                codDesmatamentoClicado));
            bd.Desconectar();
            return true;

        }

        public bool InserirValor(int codDesmatamentoClicado)
        {
            bd.Conectar();

            bd.ExecutarComandosSql(String.Format("UPDATE Reflorestamento SET valorAPagar = {0} WHERE codCalculo LIKE {1}", ValorAPagar //arg 0
                , codDesmatamentoClicado));// arg 1

            bd.Desconectar();

            return true;
        }

        public bool ReporArvores(int codDesmatamentoClicado)
        {
            bd.Conectar();

            bd.ExecutarComandosSql(String.Format("UPDATE Reflorestamento SET arvoresARepor = {0} WHERE codCalculo LIKE {1}", ArvoresARepor //arg 0
                , codDesmatamentoClicado));// arg 1

            bd.Desconectar();

            return true;
        }
    }
}
