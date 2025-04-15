using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CharacterInventory
{
    public string characterName;
    public Sprite avatar;
    public List<string> items = new List<string>();
}
