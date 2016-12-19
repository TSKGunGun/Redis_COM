using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.ComponentModel;
using StackExchange.Redis;


namespace StackExchange.Redis_COM
{
    [ComVisible(true)]
    public interface IConnectionMultiplexer
    {
        [Description("Create a new ConnectionMultiplexer instance")]
        ConnectionMultiplexer Connect(string configuration);

        [Description("Obtain an interactive connection to a database inside redis")]
        Database GetDatabase(int db = -1);
    }

    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    public class ConnectionMultiplexer : IConnectionMultiplexer
    {
        private Redis.ConnectionMultiplexer ConnectionMultiplexerInstance;

        public ConnectionMultiplexer Connect(string configuration)
        {
            ConnectionMultiplexerInstance = Redis.ConnectionMultiplexer.Connect(configuration);
            return this;
         }

        public Database GetDatabase(int db = -1)
        {
            return new Database(ConnectionMultiplexerInstance.GetDatabase(db));
        }
    }
}
