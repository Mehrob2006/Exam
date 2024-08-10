namespace Task_2;

public class Inventory<T> where T : Item
{
    
    List<T> items = new List<T>();
    
    public void AddItem(T item)
    {
        try
        {
            items.Add(item);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public void RemoveItem(T item)
    {
        try
        {
            items.Remove(item);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public Item GetItemsByCategory(string category)
    {
        try
        {
            if (items.Find(x => x.Category == category) != null)
            {
                Item i = items.Find(x => x.Category == category);
                return i;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        return null;
    }

    public Item GetItemsByType(MyEnum type)
    {
        try
        {
            if (items.Find(x => x.Type == type) != null)
            {
                Item i = items.Find(x => x.Type == type);
                return i;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        return null;
    }

    public List<T> GetAllItems()
    {
        return items;
    }
}