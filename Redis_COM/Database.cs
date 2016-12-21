using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.ComponentModel;

namespace StackExchange.Redis_COM
{
    [ComVisible(true)]
    public interface IDatabase
    {
        [Description("Set key to hold the string value. If key already holds a value, it is overwritten, regardless of its type.")]
        void StringSet(string key, string value);

        [Description("Sets the given keys to their respective values. If 'not exists' is specified, this will not perform any operation at all even if just a single key already exists.")]
        string StringGet(string key);

        [Description("")]
        bool KeyExists(string key);
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

        public bool KeyExists(string key)
        {
            return IDatabaseInstance.KeyExists(key);
        }

    }
}
