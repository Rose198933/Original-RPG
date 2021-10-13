using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "CreateMenu/CreateItem", fileName = "ItemData")]
public class Item : ScriptableObject
{
    // �A�C�e���̃A�C�R��
    public Image icon;
    // �A�C�e���̖��O
    public string name;
    // �A�C�e���̐�����
    public string description;
    // �A�C�e���̉񕜗�
    public int healPoint;
    // �A�C�e���̃_���[�W��
    public int damagePoint;
}
