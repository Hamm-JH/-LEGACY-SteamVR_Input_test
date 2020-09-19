using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LooxidLinkDataController : MonoBehaviour
{
    public Looxid.Link.LooxidLinkData looxidLinkData;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        looxidLinkData.GetEEGSensorStatus(0.2f);
    }
}
