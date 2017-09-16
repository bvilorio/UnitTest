using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyClasses
{
    public class FileProcess
    {
        public bool FileExists(string filename) {
            if (string.IsNullOrEmpty(filename)) {
                throw new ArgumentNullException("filename");
            }

            return File.Exists(filename);
        }
    }
}
