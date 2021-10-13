using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "CreateMenu/CreatePlayer", fileName = "PlayerData")]
public class Player : ScriptableObject
{
    // �v���C���[�̃A�C�R��
    public Image icon;
    // �v���C���[�̖��O
    public string name;
    // �v���C���[�̐��ʁi0:�j�A1:���A2:���̑��j
    public int gender;
    // �v���C���[�̔N��
    public int age;
    // �v���C���[�̃��x��
    public int level;
    // �v���C���[��maxHp
    public int maxHp;
    // �v���C���[��maxMp
    public int maxMp;
    // �v���C���[�̍U����
    public int atk;
    // �v���C���[�̖h���
    public int def;
    // �v���C���[�̖��@�U����
    public int mtk;
    // �v���C���[�̖��@�h���
    public int mdf;
    // �v���C���[�̃X�s�[�h
    public int spd;
    // �v���C���[�̊�p��
    public int tec;

    
}
