using System;
using UnityEngine;

public class PushButton : MonoBehaviour
{

    public static event Action<string> ButtonPressed = delegate { };

    private int deviderPosition;
    private string buttonName, buttonValue;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        buttonName = gameObject.name;
        deviderPosition = buttonName.IndexOf("_");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
