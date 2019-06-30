using System;
using System.Data.SqlClient;

namespace PlanetDDS.Interfaces
{
    public interface IDataProvider
    {
        void ExecuteProcedure(
            string procedureName,
            Action<SqlParameterCollection> inputParamMapper = null,
            Action<SqlDataReader> rowMapper = null,
            Action<SqlParameterCollection> outputParamMapper = null
        );
    }
}
