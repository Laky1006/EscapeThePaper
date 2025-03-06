using UnityEngine;

public class CombinationLock : MonoBehaviour
{
    public CombinationLock_Symbols[] lockSymbols; // Array of symbol scripts
    private int[] password = { 0, 5, 3, 1 }; // Define the correct code

    public Chest chest; // Reference to the chest

    public void CheckCombination()
    {
        for (int i = 0; i < lockSymbols.Length; i++)
        {
            if (lockSymbols[i].GetSymbolIndex() != password[i])
            {
                return; // Exit if any symbol is incorrect (no debug message needed)
            }
        }

        Debug.Log("Correct combination entered! Chest is opening...");
        chest.OpenChest();
    }
}
