using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "CreateMenu/CreatePlayer", fileName = "PlayerData")]
public class Player : ScriptableObject
{
    // プレイヤーのアイコン
    public Image icon;
    // プレイヤーの名前
    public string name;
    // プレイヤーの性別（0:男、1:女、2:その他）
    public int gender;
    // プレイヤーの年齢
    public int age;
    // プレイヤーのレベル
    public int level;
    // プレイヤーのmaxHp
    public int maxHp;
    // プレイヤーのmaxMp
    public int maxMp;
    // プレイヤーの攻撃力
    public int atk;
    // プレイヤーの防御力
    public int def;
    // プレイヤーの魔法攻撃力
    public int mtk;
    // プレイヤーの魔法防御力
    public int mdf;
    // プレイヤーのスピード
    public int spd;
    // プレイヤーの器用さ
    public int tec;

    
}
