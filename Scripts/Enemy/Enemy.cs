using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "CreateMenu/CreateEnemy", fileName = "EnemyData")]
public class Enemy : ScriptableObject
{
    // GÌACR
    public Image icon;
    // GÌ¼O
    public string name;
    // GÌ«Êi0:jA1:A2:»Ì¼j
    public int gender;
    // GÌmaxHp
    public int maxHp;
    // GÌmaxMp
    public int maxMp;
    // GÌUÍ
    public int atk;
    // GÌhäÍ
    public int def;
    // GÌ@UÍ
    public int mtk;
    // GÌ@häÍ
    public int mdf;
    // GÌXs[h
    public int spd;
    // GÌíp³
    public int tec;

    
}
