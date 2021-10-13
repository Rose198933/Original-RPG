using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "CreateMenu/CreateItem", fileName = "ItemData")]
public class Item : ScriptableObject
{
    // アイテムのアイコン
    public Image icon;
    // アイテムの名前
    public string name;
    // アイテムの説明文
    public string description;
    // アイテムの回復量
    public int healPoint;
    // アイテムのダメージ量
    public int damagePoint;
}
