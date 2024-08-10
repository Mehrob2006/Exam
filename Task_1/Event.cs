using System.Runtime.InteropServices.JavaScript;

namespace Task_1;

public class Event:EventProp
{
    List<EventProp> events = new List<EventProp>();
    
    public bool AddEvent(EventProp e)
    {
        try
        {
            events.Add(e);
            return true;
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
        }

        return false;
    }

    public bool RemoveEvent(string name)
    {
        try
        {
            if (events.Find(x => x.name == name) != null)
            {
                int id = events.FindIndex(x => x.name == name);
                events.RemoveAt(id);
                return true;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        return false;
    }

    public EventProp FindEvent(int day)
    {
        try
        {
            if (events.Find(x => x.start.Day.Equals(day)) != null)
            {
                EventProp id = events.Find(x => x.start.Day.Equals(day));
                return id;

            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        return null;
    }
}