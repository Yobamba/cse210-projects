public class Event 
{
    
    private string _eventTitle;
    private string _description;
    private string _date;
    private int _time;
    private Address _address = new Address();
    protected string _eventType;

    //Standard details
    // Lists the title, description, date, time, and address.
    public string ShowStandardDetails() 
    {
        return _eventTitle + ": "+ _date + " @ " + $"{_time}" + " @ " + _address + "\n" +  _description; 
    }

    //Full details
    // Lists all of the above, plus type of event and information 
    //specific to that event type. For lectures, this includes the speaker 
    //name and capacity. For receptions this includes an email for RSVP. For
    //  outdoor gatherings, this includes a statement of the weather.
    public string ShowFullDetails() 
    {
        string standard = ShowStandardDetails();
        if (_eventType == "Lecture") 
        {
            Console.Write("What is the name of the speaker? ");
            string extraInfo = Console.ReadLine();
            Console.Write("What is the capacity? ");
            string extraInfo2 = Console.ReadLine();
        }

        else if (_eventType == "Reception") 
        {
            string extraInfo = "Please email: sample@gmail.com";
            string extraInfo2 = "";

        }

        else if (_eventType == "Outdoor") 
        {
            Console.Write("What's the weather like? ");
            string extraInfo = Console.ReadLine();
            string extraInfo2 = "";
        }
        return _eventType + "\n" + standard + "\n" + $"{extraInfo}" + $"{extraInfo2}";


    }

    //Short description
    //Lists the type of event, title, and the date.
    public string ShowShortDescription() 
    {
        return _eventType + " " + _eventTitle + " : " + _date;
    }


}