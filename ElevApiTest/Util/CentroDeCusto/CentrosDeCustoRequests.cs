using ElevApiHelper.Models.ControDeCusto;
using ElevApiHelper.Util;

namespace ElevApiTest.Util.CentroDeCusto
{
    public static class GetCentrosDeCustoParamsModels
    {
        public static GetCentrosDeCustoParams GetModelDefault() 
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

        public static GetCentrosDeCustoParams GetModelPageZero()
        {
            GetCentrosDeCustoParams model = new GetCentrosDeCustoParams()
            {
                Page = 0,
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

        public static GetCentrosDeCustoParams GetModelNegativePage()
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

        public static GetCentrosDeCustoParams GetModelPageMaxInt()
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
        public static GetCentrosDeCustoParams GetModelPageMinInt()
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
    }
}

