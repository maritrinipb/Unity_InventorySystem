using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    public GameObject inventoryPanel;

    public Image sigrunImage;
    public TextMeshProUGUI sigrunNameText;
    public TextMeshProUGUI sigrunItemsText;  

    public Image einarImage;
    public TextMeshProUGUI einarNameText;
    public TextMeshProUGUI einarItemsText;  

    private bool isOpen = false;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            isOpen = !isOpen;
            inventoryPanel.SetActive(isOpen);
            if (isOpen) UpdateInventoryUI();
        }
    }

    void UpdateInventoryUI()
    {
        // Sigrun
        var sigrun = InventoryManager.Instance.sigrunInventory;
        sigrunNameText.text = sigrun.characterName;
        sigrunItemsText.text = "";  
        foreach (string item in sigrun.items) 
        {
            sigrunItemsText.text += "• " + item + "\n";
        }
        if (sigrun.avatar != null)
            sigrunImage.sprite = sigrun.avatar;

        // Einar
        var einar = InventoryManager.Instance.einarInventory;
        einarNameText.text = einar.characterName;
        einarItemsText.text = "";  
        foreach (string item in einar.items)  
        {
            einarItemsText.text += "• " + item + "\n";
        }
        if (einar.avatar != null)
            einarImage.sprite = einar.avatar;
    }
}
