using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleDOS
{
    public class Placeholder
    {
        public Placeholder() { Console.WriteLine("Placeholder Constructed!"); }
        ~Placeholder() { Console.WriteLine("Placeholder Destructed!"); }

        public void WriteASCII()
        {
            Console.WriteLine(
                "\r\n ______  ______  ______ ______  __  __  __  ______  ______  ______    " +
                "\r\n/\\  ___\\/\\  ___\\/\\__  _/\\  == \\/\\ \\/\\_\\_\\_\\/\\  ___\\/\\  ___\\/\\  ___\\   " +
                "\r\n\\ \\  __\\\\ \\___  \\/_/\\ \\\\ \\  __<\\ \\ \\/_/\\_\\/\\ \\___  \\ \\  __\\\\ \\ \\____  " +
                "\r\n \\ \\_____\\/\\_____\\ \\ \\_\\\\ \\_\\ \\_\\ \\_\\/\\_\\/\\_\\/\\_____\\ \\_____\\ \\_____\\ " +
                "\r\n  \\/_____/\\/_____/  \\/_/ \\/_/ /_/\\/_/\\/_/\\/_/\\/_____/\\/_____/\\/_____/ " +
                "\r\n                                                                      " +
                "\r\n");
        }

    }
}
