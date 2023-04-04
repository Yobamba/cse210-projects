public class Event 
{
    
    protected string _eventTitle;
    private string _description;
    private string _date;
    private int _time;
    private Address _address = new Address();
   

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
        string extraInfo = "";
        string extraInfo2 = "";
        if (_eventTitle == "Lecture") 
        {
            Console.Write("What is the name of the speaker? ");
            extraInfo = Console.ReadLine();
            Console.Write("What is the capacity? ");
            extraInfo2 = Console.ReadLine();
        }

        else if (_eventTitle == "Reception") 
        {
            extraInfo = "Please email: sample@gmail.com";
            extraInfo2 = "";

        }

        else if (_eventTitle == "Outdoor") 
        {
            Console.Write("What's the weather like? ");
            extraInfo = Console.ReadLine();
            extraInfo2 = "";
        }
        return _eventTitle + "\n" + standard + "\n" + $"{extraInfo}" + $"{extraInfo2}";


    }

    //Short description
    //Lists the type of event, title, and the date.
    public string ShowShortDescription() 
    {
        return _eventTitle + " : " + _date;
    }


}