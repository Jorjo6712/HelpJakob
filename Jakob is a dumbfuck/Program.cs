namespace Jakob_is_a_dumbfuck;

using Jakob_is_a_dumbfuck.Model;

public class Program 
{ 
    private static void Main()
    {
        string from = "YourMom@gmail.com";
        string[] to = {"Magnusse@gmail.com", "Marcusse@gmail.com"};
        string body = "Hello!";
        string subject = "Sex";
        string cc = "yord0050@zbc.dk";
        
        Message message = new Message(to, from, body, subject, cc);

        
        message.SendMessage(MessageCarrier.VMessage, message, true);
        message.SendMessageToAll(MessageCarrier.Smtp,to,message,true);
    }
}