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

        [Description("Get the value of key. If the key does not exist the special value nil is returned. An error is returned if the value stored at key is not a string, because GET only handles string values.")]
        string StringGet(string key);

        [Description("Returns if key exists.")]
        bool KeyExists(string key);

        [Description("e if the key was removed.")]
        bool KeyDelete(string key);

        [Description("The number of keys that were removed.")]
        long KeyDelete(string[] keys);
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

        public bool KeyDelete(string key)
        {
            return IDatabaseInstance.KeyDelete(key);
        }

        public long KeyDelete(string[] keys)
        {
        
            Redis.RedisKey[] RedisKeys;
            RedisKeys = new Redis.RedisKey[keys.ToArray().Count()];  
            
            for(int i=0; i > keys.ToArray().Count(); i++)
            {
                RedisKeys[i] = keys[i];
            } 

            return IDatabaseInstance.KeyDelete(RedisKeys);
        }

    }
}
