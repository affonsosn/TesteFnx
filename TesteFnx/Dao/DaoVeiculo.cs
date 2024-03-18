using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using TesteFnx.Model;

namespace TesteFnx.Dao
{
    public class DaoVeiculo
    {
        string conexao = @"Data Source=DESKTOP-ECTQC3A\\SQLEXPRESS;Initial Catalog=FENOX_TESTE;Integrated Security=True";

        public List<Veiculo> GetVeiculos()
        {
            List<Veiculo> veiculos = new List<Veiculo> ();

            using (SqlConnection conn = new SqlConnection (conexao))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Veiculo", conn))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            while (reader.Read())
                            {
                                var veiculo = new Veiculo();
                                veiculo.Identificador = (int)reader["Identificador"];
                                veiculo.Renavam = (int)reader["Renavam"];
                                veiculos.Add(veiculo);
                            }
                        }
                    }
                }
            }

            return veiculos;
        }
    }
}
