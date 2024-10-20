using System.Collections.Generic;

public class ListType
{
    private LinkedList<MEventHandler> m_handlerList = new LinkedList<MEventHandler>();

    public void AddTail(MEventHandler eventHandler)
    {
        m_handlerList.AddLast(eventHandler);
    }

    public LinkedListNode<MEventHandler> Begin()
    {
        return m_handlerList.First;
    }

    public LinkedListNode<MEventHandler> End()
    {
        return m_handlerList.Last;
    }

    public LinkedListNode<MEventHandler> Next(LinkedListNode<MEventHandler> node)
    {
        return node.Next;
    }

    public void Remove(MEventHandler node)
    {
        m_handlerList.Remove(node);
    }

    public bool Empty()
    {
        return m_handlerList.Count == 0;
    }
}
