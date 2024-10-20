public class MEventHandler
{
    public delegate void EventCallbackHandler(IEventArg e);
    private EventCallbackHandler m_callbackHandler = null;

    public MEventHandler(EventCallbackHandler callback)
    {
        m_callbackHandler = callback;
    }

    public void Invoke(IEventArg args)
    {
        m_callbackHandler(args);
    }
}
