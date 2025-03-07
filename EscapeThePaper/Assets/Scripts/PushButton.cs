using System;
using UnityEngine;
using UnityEngine.UI;

public class PushButton : MonoBehaviour
{

    public static event Action<string> ButtonPressed = delegate { };

    private int deviderPosition;
    private string buttonName, buttonValue;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        buttonName = gameObject.name;
        deviderPosition = buttonName.IndexOf("-");
        buttonValue = buttonName.Substring(0, deviderPosition);

        gameObject.GetComponent<Button>().onClick.AddListener(ButtonClicked);
    }

    private void ButtonClicked()
    {
        ButtonPressed(buttonValue);
    }
}
