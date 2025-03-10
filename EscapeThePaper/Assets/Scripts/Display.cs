using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Display : MonoBehaviour
{

    public Door door;

    public TMP_Text codeText;
    string codeTextValue = "";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Update()
    {
        codeText.text = codeTextValue;

        if (codeTextValue == "1234")
        {
            door.OpenDoor();
        } 
        else if (codeTextValue.Length >= 4 )
        {
            StartCoroutine(FlashRed());
        }
             
    }

    IEnumerator FlashRed()
    {
       
        codeText.color = Color.red;
        yield return new WaitForSeconds(0.3f);
        
        codeText.color = new Color32(69, 69, 69, 255);
        
        codeTextValue = "";
    }

    public void NumberButton(string value)
    {
        codeTextValue += value;
    }
}
