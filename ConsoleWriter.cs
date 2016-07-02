 using System;
 
 namespace ConsoleApplication{
 public class ConsoleWriter : IResponseWriter{
        
        
        public ConsoleWriter(){
            PromptUser();
        }

        public void OutputResponse(string output)
        {
            Console.WriteLine(output);
            PromptUser();

        }
        private void PromptUser(){
            Console.Write(">");
        }

    }
 }