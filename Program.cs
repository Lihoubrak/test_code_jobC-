class Program
{
    static void Main(string[] args)
    {
          //My Test Data
        string input1 = "[BE][FE][Urgent] there is error";
        Console.WriteLine(NotificationParser.ParseNotificationTitle(input1));

        string input2 = "[BE][QA][HAHA][Urgent] there is error";
        Console.WriteLine(NotificationParser.ParseNotificationTitle(input2));
    }
}
