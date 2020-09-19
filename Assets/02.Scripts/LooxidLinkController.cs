using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LooxidLinkController : MonoBehaviour
{
    public Looxid.Link.LooxidLinkManager looxidLinkManager;

    public Text LinkCoreC;
    public Text LinkCoreD;

    public Text LinkHubC;
    public Text LinkHubD;


    // Start is called before the first frame update
    void Start()
    {
        // 룩시드링크 시작
        bool isInitialized = looxidLinkManager.Initialize();

        Looxid.Link.LooxidLinkManager.OnLinkCoreConnected += OnLinkCoreConnected;       // 코어 접속시 실행 이벤트
        Looxid.Link.LooxidLinkManager.OnLinkCoreDisconnected += OnLinkCoreDisconnected; // 코어 끊김시 실행 이벤트
        Looxid.Link.LooxidLinkManager.OnLinkHubConnected += OnLinkHubConnected;         // 허브 접속시 실행 이벤트
        Looxid.Link.LooxidLinkManager.OnLinkHubDisconnected += OnLinkHubDisconnected;   // 허브 끊김시 실행 이벤트

        
    }

    void OnLinkCoreConnected()
    {
        Debug.Log("Link Core connected");
        LinkCoreC.text = "Link Core connected";
        LinkCoreD.text = "??";
    }

    void OnLinkCoreDisconnected()
    {
        Debug.Log("Link Core is disconnected");
        LinkCoreC.text = "??";
        LinkCoreD.text = "Link Core is disconnected";
    }

    void OnLinkHubConnected()
    {
        Debug.Log("Link Hub is connected");
        LinkHubC.text = "Link Hub is connected";
        LinkHubD.text = "??";
    }

    void OnLinkHubDisconnected()
    {
        Debug.Log("Link Hub is disconnected");
        LinkHubC.text = "??";
        LinkHubD.text = "Link Hub is disconnected";
    }
}
