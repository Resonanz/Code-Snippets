# Events

## Book: Interactive C#

* Events are used to notify or signal that a state of an object is changed. This information is useful for the clients of that object (e.g., a mouse-click or a key press in a GUI application are very common example of events).

* Events are associated with delegates. To understand events, you
should learn delegates first. **When an event occurs, the delegates
given to it by its clients are invoked.**

* In .NET, events are implemented as multicast delegates.

* A publisher-subscriber model is followed here. A publisher (or
broadcaster) publishes a notification (or information) and the
subscriber receives this notification. But subscribers have the
freedom when to start listening and when to stop listening (in
programming terms, when to register and when to unregister).

* **Publisher is the type that contains the delegate. Subscribers register
themselves by using += on the publisher’s delegate and unregister
themselves by using -= on that delegate.** So, when we apply += or -=
to an event, they have a special meaning (in other words, they are not
shortcuts for assignments in these cases).

* Subscribers do not talk to each other. Actually, these are the key goals of supporting an event architecture:

    * Subscribers **cannot** communicate with each other.
    * We can make a **loosely coupled system**.
    * If we use Visual Studio IDE, it makes our life extremely easy when we deal with events. But I believe that these concepts are the core of C#, and so it’s better to learn from the basics.
    * The .NET framework provides a generic delegate that supports the standard event design patterns, as follows:
 
```   
    public delegate void EventHandler<TEventArgs>(object sendersource, TEventArgs e) where TEventArgs : EventArgs;
```