using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GlobalDefines;

public class EventMgr
{
    private static EventMgr m_instance;
    public static EventMgr Instance
    {
        get
        {
            if (m_instance == null)
            {
                m_instance = new EventMgr();
            }

            return m_instance;
        }
    }

    private EventDispatcher m_eventDispatcher = new EventDispatcher();
    public EventDispatcher EventDispatcher
    {
        get
        {
            return m_eventDispatcher;
        }
    }

    public void FireEvent(MEventType eventType, EventDispatcher firer, IEventArg args = null, bool bLuaNeedReceive = false)
    {
        if(firer != null)
        {
            firer.FireEvent(eventType, args);

            // 如果事件需要发送到lua
            //if (bLuaNeedReceive)
            //{
            //    var dic = Singleton<LuaEvent>.Instance.GetLuaEventMap();
            //    if (dic.ContainsKey(eventType) && Singleton<LuaManager>.Instance.LuaClient != null)
            //    {
            //        Singleton<LuaManager>.Instance.LuaClient.CallFunc("triggerEventFromMainLogic", dic[eventType], args);
            //    }
            //}
        }
        else
        {
            if(args != null)
            {

            }
        }
    }
}