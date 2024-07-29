using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CLock : MonoBehaviour
{
    public GameObject hourHand;
    public GameObject minuteHand;
    public GameObject secondHand;

    // Update is called once per frame
    void Update()
    {
        UpdateHand();
    }

    void UpdateHand()
    {
        hourHand.transform.localRotation = Quaternion.Euler((System.DateTime.Now.Hour / 12f) * 360f + 90, 0, -90);
        minuteHand.transform.localRotation = Quaternion.Euler((System.DateTime.Now.Minute / 60f) * 360f + 90, 0, -90);
        secondHand.transform.localRotation = Quaternion.Euler((System.DateTime.Now.Second / 60f) * 360f + 90, 0, -90);
    }
}
