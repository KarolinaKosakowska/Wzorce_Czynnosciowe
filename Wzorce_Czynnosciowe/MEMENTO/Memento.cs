using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_Czynnosciowe.MEMENTO
{
    public class Memento
    {
        public string Path { get; private set; }
        public byte[] Data { get; private set; }
        public Memento(string path, byte[] data)
        {
            Path = path;
            Data = data;
        }
        public bool SetNewData(string path)
        {
            if (path == Path && File.Exists(path))
            {
                Data = File.ReadAllBytes(path);
                return true;
            }
            return false;
        }
        public void RevertFromMemento()
        {
            if (File.Exists(Path) && Data != null)
            {
                File.WriteAllBytes(Path, Data);
            }
        }
    }

}

