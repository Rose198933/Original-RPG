using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CreateMenu/CreateItemDatabase", fileName = "ItemDatabase")]
public class ItemDatabase : ScriptableObject
{
    public List<Item> itemDatabase = new List<Item>();
}
