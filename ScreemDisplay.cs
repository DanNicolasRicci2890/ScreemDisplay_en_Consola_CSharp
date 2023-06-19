using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCD_ScreemDisplay
{
    public class ScreemDisplay
    {
        private int _Width;
        private int _Height;

        public void MonitorSize()
        {
            int size = 0, cont = 0;
            bool est = false;

            while (cont < 2)
            {
                est = true;
                while (est)
                {
                    try
                    {
                        size += 10;
                        switch (cont)
                        {
                            case (0): Console.WindowWidth = size; break;
                            case (1): Console.WindowHeight = size; break;
                        }
                    }
                    catch
                    {
                        size -= 15;
                        switch (cont)
                        {
                            case (0):
                                Console.WindowWidth = size;
                                this._Width = size;
                                break;
                            case (1):
                                Console.WindowHeight = size;
                                this._Height = size;
                                break;
                        }
                        est = false;
                        size = 0;
                        cont++;
                    }
                }
            }
            Console.SetWindowSize(this._Width, this._Height);
            Console.SetBufferSize(this._Width, this._Height);
        }
        public int WIDTH { get => (this._Width); }        
        public int HEIGTH { get => (this._Height); }
    }
}
