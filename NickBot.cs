 
 using System;
 using System.Collections.Generic;

 namespace ConsoleApplication{
 public class NickBot : IBot{

        record[] knowledgeBase;

        List<record>  list;

        public NickBot()
        {
           
            knowledgeBase = new record[]{
                new record(){
                    input="WHAT IS YOUR NAME",
                    responses = new string[]{
                        "MY NAME IS CHATTERBOT2.",
                        "YOU CAN CALL ME CHATTERBOT2",
                        "WHY DO YOU WANT TO KNOW MY NAME?"}
                        },
                new record(){
                    input="Hi",
                    responses = new string[]{
                    "Hi there",
                    "How are you?",
                    "Hi!"}},
                new record(){
                    input="How are you",
                    responses = new string[]{
                    "I'm doing fine",
                    "Not bad thanks, you",
                    "Why do you care?"}},
                new record(){
                    input="Who are you",
                    responses = new string[]{
                    "I'm an A.I of Nick Wise",
                    "I think you know who I am",
                    "Why are you asking?"}
                    },
                new record(){
                    input="Are you intelligent",
                    responses = new string[]{
                    "Yes, ofcorse",
                    "What do you think?",
                    "Actually, i really am"}},
                
                new record(){
                    input="Are you real",
                    responses = new string[]{
                    "Does it really matter?",
                    "What do you  mean?",
                    "I'm as real as you are mofo"}},
            };
            

            list = new List<record>();
            list.AddRange(knowledgeBase);

        }

        public string GetResponse(string input)
        {
             if(!input.Equals("exit")){
                    var responses = findResponse(list, input);

                    if(responses == null || responses.Length == 0){
                       return "Sorry I've got no idea what you're talking about, can you say that again?";
                    }
                    else{
                        var rand = new Random();
                        return responses[rand.Next(3)];
                    }

                }
                else{
                    return "bye";
                }
        }

        private string[] findResponse(List<record> knowledge,string input){
            
            return knowledge.Find(k => k.input.ToLower() == input.ToLower()).responses;
            //TODO : Add removal of special characters
        }

        private string[] getResponseUsingLevenshteinDistance(string input)
        {
                var inputVector = input.Split(' ');

                return null;
        }
    }
}