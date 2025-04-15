using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;

    public CharacterInventory sigrunInventory = new CharacterInventory { characterName = "Sigrun" };
    public CharacterInventory einarInventory = new CharacterInventory { characterName = "Einar" };

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // A�adir �tem al inventario de Sigrun
    public void UnlockSigrunShield()
    {
        if (!sigrunInventory.items.Contains("Escudo"))
        {
            sigrunInventory.items.Add("Escudo");
        }
    }

    // A�adir �tem al inventario de Einar
    public void UnlockEinarDaggers()
    {
        if (!einarInventory.items.Contains("Dagas"))
        {
            einarInventory.items.Add("Dagas");
        }
    }
}

