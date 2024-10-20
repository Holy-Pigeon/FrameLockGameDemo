using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageCtrl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MEventHandler handle = new MEventHandler(Test);
        EventMgr.Instance.EventDispatcher.AddEventListener(GlobalDefines.MEventType.TestEvent, handle);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Test(IEventArg data)
    {
        Debug.Log("ImageCtrl.Test");

        var active = this.gameObject.activeSelf;
        this.gameObject.SetActive(!active);
    }
}
