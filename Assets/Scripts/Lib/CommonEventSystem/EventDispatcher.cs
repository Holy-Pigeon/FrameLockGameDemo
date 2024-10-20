using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GlobalDefines;

public class EventDispatcher
{
    public EventDispatcher()
    {

    }

    Dictionary<MEventType, ListType> m_dicRegisterFuncCallback = new Dictionary<MEventType, ListType>();

    public void AddEventListener(MEventType eventType, MEventHandler eventHandler)
    {
        if (eventHandler == null) return;
        if(!m_dicRegisterFuncCallback.TryGetValue(eventType, out var registerList))
        {
            registerList = new ListType();
            m_dicRegisterFuncCallback.Add(eventType, registerList);
        }
        registerList.AddTail(eventHandler);
    }

    public void RemoveEventListener(MEventType eventType, MEventHandler callbackAction)
    {
        if (callbackAction == null) return;
        if (m_dicRegisterFuncCallback.TryGetValue(eventType, out var registerList))
        {
            registerList.Remove(callbackAction);
        }
    }

    public void FireEvent(MEventType eventType, IEventArg args)
    {
        if(m_dicRegisterFuncCallback.TryGetValue(eventType, out var registerList))
        {
            if (registerList.Empty())
            {
                m_dicRegisterFuncCallback.Remove(eventType);
                return;
            }

            for(var node = registerList.Begin(); node != null; node = registerList.Next(node))
            {
                if(node.Value != null)
                {
                    node.Value.Invoke(args);
                }
            }
        }
    }
}
