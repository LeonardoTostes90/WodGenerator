using System;
using System.Collections.Generic;
using System.Text;
using WodGenerator.Dominio.Servicos;

namespace WodGenerator.Dominio.Servicos
{
    public static class ServiceFactory
    {
        public static IAtletaService AtletaService()
        {
            return new FakeApiAtletaService();
        }

        public static ITiposWODService TiposWODService()
        {
            return new FakeApiTiposWODService();
        }

        public static ISubtiposWODService SubtiposWODService()
        {
            return new FakeApiSubtiposWODService();
        }
    }
}
