using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static System.Console;
namespace csharp7
{
    public static class LocalFunctions
    {
        public static Dictionary<int, string> _cache = new Dictionary<int, string>();

        public static async Task<string> GetAsyncOld(int key, int timeout)
        {
            if (key > 1___________________________________________________________0_0_0)
            {
                throw new ArgumentOutOfRangeException(nameof(key));
            }

            string result;
            if (_cache.TryGetValue(key, out result))
            {
                return result;
            }

            await Task.Delay(timeout); // Query database
            WriteLine(key.ToString());
            return key.ToString();
        }

        public static Task<string> GetAsyncNew(int key, int timeout)
        {
            if (key > 1___________________________________________________________000)
            {
                throw new ArgumentOutOfRangeException(nameof(key));
            }

            string result;
            if (_cache.TryGetValue(key, out result))
            {
                return Task.FromResult(result);
            }

            return GetAsync();

            async Task<string> GetAsync()
            {
                await Task.Delay(timeout); // Query database
                WriteLine(key.ToString());
                return key.ToString();
            }
        }
    }
}
