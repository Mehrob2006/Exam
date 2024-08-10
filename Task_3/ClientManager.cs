using System.Runtime.CompilerServices;

namespace Task_3;

public class ClientManager<T>where T : Client
{
    List<T>l = new List<T>();
    
    public void create(T t)
    {
        try
        {
            l.Add(t);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public void delete(T t)
    {
        try
        {
            l.Remove(t);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public void update(int id)
    {
        try
        {
            if (l.Find(x => x.ClientId == id) != null)
            {
                int i = l.FindIndex(x => x.ClientId == id);
                T t2 = null;
                t2.Name = "Updated Client";
                t2.ClientId = 33;
                t2.ContactInfo = "1235212312";
                l.Add(t2);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public List<T> Read()
    {
        try
        {
            return l;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        return null;
    }
}