using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "CreateMenu/CreateEnemy", fileName = "EnemyData")]
public class Enemy : ScriptableObject
{
    // “G‚ÌƒAƒCƒRƒ“
    public Image icon;
    // “G‚Ì–¼‘O
    public string name;
    // “G‚Ì«•Êi0:’jA1:—A2:‚»‚Ì‘¼j
    public int gender;
    // “G‚ÌmaxHp
    public int maxHp;
    // “G‚ÌmaxMp
    public int maxMp;
    // “G‚ÌUŒ‚—Í
    public int atk;
    // “G‚Ì–hŒä—Í
    public int def;
    // “G‚Ì–‚–@UŒ‚—Í
    public int mtk;
    // “G‚Ì–‚–@–hŒä—Í
    public int mdf;
    // “G‚ÌƒXƒs[ƒh
    public int spd;
    // “G‚ÌŠí—p‚³
    public int tec;

    
}
