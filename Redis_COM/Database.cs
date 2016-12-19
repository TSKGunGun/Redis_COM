using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace StackExchange.Redis_COM
{
    [ComVisible(true)]
    public interface IDatabase
    {
        void StringSet(string key, string value);
        string StringGet(string key);
    }

    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    public class Database : IDatabase
    {
        private Redis.IDatabase IDatabaseInstance;

        public Database(Redis.IDatabase IDatabase)
        {
            IDatabaseInstance = IDatabase;
        }

        public void StringSet(string key, string value)
        {
            IDatabaseInstance.StringSet(key, value);
        }

        public string StringGet(string key)
        {
            return IDatabaseInstance.StringGet(key);
        }
    }
}
