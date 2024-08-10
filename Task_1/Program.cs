using Task_1;

EventProp Event1 = new EventProp();

Event1.name = "New Event";
Event1.description = "Event_1";
Event1.start = DateTime.Now;
Event1.start.AddDays(-10);
Event1.finish = DateTime.Now;

EventProp Event2 = new EventProp();
Event2.name = "Newest Event";
Event2.description = "Event_2";
Event2.start = DateTime.Now;
Event2.start.AddDays(-5);
Event2.finish = DateTime.Now;

EventProp Event3 = new EventProp();
Event3.name = "Old Event";
Event3.description = "Event_3";
Event3.start = DateTime.Now;
Event3.start.AddDays(-30);
Event3.finish = DateTime.Now;

Event service = new Event();

Console.WriteLine(
service.AddEvent(Event1));
Console.WriteLine(
service.AddEvent(Event2));
Console.WriteLine(
service.AddEvent(Event3));

EventProp e = service.FindEvent(3);
Console.WriteLine(Event2.start.Day);
Console.WriteLine(Event1.start.Day);
Console.WriteLine(e.name);
Console.WriteLine(
service.RemoveEvent("Event_1"));
