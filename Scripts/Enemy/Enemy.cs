using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "CreateMenu/CreateEnemy", fileName = "EnemyData")]
public class Enemy : ScriptableObject
{
    // �G�̃A�C�R��
    public Image icon;
    // �G�̖��O
    public string name;
    // �G�̐��ʁi0:�j�A1:���A2:���̑��j
    public int gender;
    // �G��maxHp
    public int maxHp;
    // �G��maxMp
    public int maxMp;
    // �G�̍U����
    public int atk;
    // �G�̖h���
    public int def;
    // �G�̖��@�U����
    public int mtk;
    // �G�̖��@�h���
    public int mdf;
    // �G�̃X�s�[�h
    public int spd;
    // �G�̊�p��
    public int tec;

    
}
