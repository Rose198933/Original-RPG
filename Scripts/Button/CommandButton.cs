using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandButton : ButtonManager
{
    // ボタンオブジェクトの名前によって使用するメソッドを分岐
    protected override void OnClick(string buttonName)
    {
        if(buttonName.Equals("AttackButton"))
        {
            this.AttackButton();
        }
        else if(buttonName.Equals("SkillButton"))
        {
            this.SkillButton();
        }
        else if(buttonName.Equals("ItemButton"))
        {
            this.ItemButton();
        }
        else if(buttonName.Equals("EscapeButton"))
        {
            this.EscapeButton();
        }
    }

    // 他スクリプトの攻撃メソッドを実行
    public void AttackButton()
    {
        Debug.Log("攻撃！");
    }

    // 他スクリプトのスキルメソッドを実行
    public void SkillButton()
    {
        Debug.Log("スキル発動！");
    }

    // 他スクリプトのアイテムメソッドを実行
    public void ItemButton()
    {
        Debug.Log("アイテム使用！");
    }

    // 他スクリプトの逃走メソッドを実行
    public void EscapeButton()
    {
        Debug.Log("逃げる！");
    }
}
