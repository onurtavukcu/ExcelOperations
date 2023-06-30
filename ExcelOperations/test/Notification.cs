namespace ExcelOperations.test
{
    public class Notification
    {
        public void Sender(IMessage message)
        {
            message.send();
        }

        public void Received() 
        {
            var email = new Email();
            var sms = new SMS();
            var sender = new Notification();

            sender.Sender(email);
            sender.Sender(sms);
        }
    }    
}
