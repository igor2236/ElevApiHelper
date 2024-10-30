using ElevApiHelper.Models.ControDeCusto;
using ElevApiHelper.Util;

namespace ElevApiTest.Util.CentroDeCusto
{
    public static class GetCentrosDeCustoParamsModels
    {
        public static GetCentrosDeCustoParams GetModelDefaultElev() 
        {
            GetCentrosDeCustoParams model = new GetCentrosDeCustoParams()
            {
                Page = 1,
                Rows = 5,
                SortBy = null,
                OrderBy = null,
                Ativo = true,
                Nome = null,
                Codigo = null,
                FkRamal = null
            };
            return model;
        }

        public static GetCentrosDeCustoParams GetModelPageZeroElev()
        {
            GetCentrosDeCustoParams model = new GetCentrosDeCustoParams()
            {
                Page = 0,
                Rows = 5,
                SortBy = null,
                OrderBy = null,
                Ativo = true,
                Nome = null,
                Codigo = null,
                FkRamal = null
            };
            return model;
        }

        public static GetCentrosDeCustoParams GetModelNegativePageElev()
        {
            GetCentrosDeCustoParams model = new GetCentrosDeCustoParams()
            {
                Page = -1,
                Rows = 5,
                SortBy = null,
                OrderBy = null,
                Ativo = true,
                Nome = null,
                Codigo = null,
                FkRamal = null
            };
            return model;
        }

        public static GetCentrosDeCustoParams GetModelPageMaxIntElev()
        {
            GetCentrosDeCustoParams model = new GetCentrosDeCustoParams()
            {
                Page = 2147483647,
                Rows = 5,
                SortBy = null,
                OrderBy = null,
                Ativo = true,
                Nome = null,
                Codigo = null,
                FkRamal = null
            };
            return model;
        }
        public static GetCentrosDeCustoParams GetModelPageMinIntElev()
        {
            GetCentrosDeCustoParams model = new GetCentrosDeCustoParams()
            {
                Page = -2147483647,
                Rows = 5,
                SortBy = null,
                OrderBy = null,
                Ativo = true,
                Nome = null,
                Codigo = null,
                FkRamal = null
            };
            return model;
        }

        public static GetCentrosDeCustoParams GetModelSorteByIdElev()
        {
            GetCentrosDeCustoParams model = new GetCentrosDeCustoParams()
            {
                Page = 1,
                Rows = 5,
                SortBy = SortBy.GetCentrosDeCustoSortBy.Id,
                OrderBy = null,
                Ativo = true,
                Nome = null,
                Codigo = null,
                FkRamal = null
            };
            return model;
        }

        public static GetCentrosDeCustoParams GetModelSorteByNameElev()
        {
            GetCentrosDeCustoParams model = new GetCentrosDeCustoParams()
            {
                Page = 1,
                Rows = 5,
                SortBy = SortBy.GetCentrosDeCustoSortBy.Nome,
                OrderBy = null,
                Ativo = true,
                Nome = null,
                Codigo = null,
                FkRamal = null
            };
            return model;
        }
    }
}

