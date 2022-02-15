using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class EventManager : MonoBehaviour
{
    public static event Action ExampleEvent;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ExampleEvent?.Invoke();
        }
    }
}
