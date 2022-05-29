using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PreVideoElasticCache.Helpers
{
    public class CacheRedisHelper
    {
        private static Lazy<ConnectionMultiplexer> GenerarConexion = new Lazy<ConnectionMultiplexer>(() =>
        {

        return ConnectionMultiplexer.Connect("");
        });

        public static ConnectionMultiplexer Connection
        {
            get { return GenerarConexion.Value; }
        }
    }
}
