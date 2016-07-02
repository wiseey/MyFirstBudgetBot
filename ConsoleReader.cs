using System;

namespace ConsoleApplication
{  
  public class ConsoleReader : IInputReader{
        public ConsoleReader()
        {

        }

        public string ReadInput(){
            return Console.ReadLine();

        }
    }

}