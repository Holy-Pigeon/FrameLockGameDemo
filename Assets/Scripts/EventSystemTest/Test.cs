using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var button = this.gameObject.GetComponent<Button>();
        button.onClick.AddListener(OnButtonClicked);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnButtonClicked()
    {
        Debug.Log("OnButtonClicked");
        EventMgr.Instance.FireEvent(GlobalDefines.MEventType.TestEvent, EventMgr.Instance.EventDispatcher);
    }
}
