namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            //I assume using Dependency Injection you'd instantiate these through config?
            IBot bot = new NickBot();
            IResponseWriter writer = new ConsoleWriter();
            IInputReader userInput = new ConsoleReader();

            while(true){
                var input = userInput.ReadInput();

                var response = bot.GetResponse(input);
                
                writer.OutputResponse(response);

                if(response.Equals("bye")){
                    break;
                }
            }
        }
    }
}
