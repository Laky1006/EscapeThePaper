using UnityEngine;
using UnityEngine.UI;

public class CombinationLock_Symbols : MonoBehaviour
{
    public Image startingImage;
    public Sprite[] lockSprites;
    private int currentSymbolIndex = 0; // Store the current symbol index

    public CombinationLock combLockManager;

    public int GetSymbolIndex()
    {
        return currentSymbolIndex; // Return the current symbol index
    }

    public void ChangeLockSymbol()
    {
        if (currentSymbolIndex == lockSprites.Length - 1)
        {
            currentSymbolIndex = 0;
        }
        else
        {
            currentSymbolIndex++;
        }
        startingImage.sprite = lockSprites[currentSymbolIndex];
        combLockManager.CheckCombination();
    }
}
