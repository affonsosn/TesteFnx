using TesteFnx.Dao;
using TesteFnx.Model;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace TesteFnx.Repositories
{
    public class VeiculoRepositorio
    {
        private readonly DaoVeiculo _daoVeiculo;

        public VeiculoRepositorio()
        {
            _daoVeiculo = new DaoVeiculo();
        }

        public List<Veiculo> GetVeiculos
        {
            get
            {
                return _daoVeiculo.GetVeiculos();
            }
        }
    }
}
