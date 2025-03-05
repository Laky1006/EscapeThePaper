using UnityEngine;
using UnityEngine.UI;

public class CombinationLock_Symbols : MonoBehaviour
{
    public Image startingImage;
    public Sprite[] lockSprites;
    int i = 0;

    public void ChangeLockSymbol()
    {
        if (i == lockSprites.Length -1)
        {
            i = 0;
        }
        else
        {
            i++;
        }
        startingImage.sprite = lockSprites[i];
    }
}
