using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace INTEX.Models
{
    static class WriteAllText
    {
        public static async Task writeJSON(string input, string path)
        {
            
            await File.WriteAllTextAsync(path, input);
        }
    }
}
