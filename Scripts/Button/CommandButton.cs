using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandButton : ButtonManager
{
    // �{�^���I�u�W�F�N�g�̖��O�ɂ���Ďg�p���郁�\�b�h�𕪊�
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

    // ���X�N���v�g�̍U�����\�b�h�����s
    public void AttackButton()
    {
        Debug.Log("�U���I");
    }

    // ���X�N���v�g�̃X�L�����\�b�h�����s
    public void SkillButton()
    {
        Debug.Log("�X�L�������I");
    }

    // ���X�N���v�g�̃A�C�e�����\�b�h�����s
    public void ItemButton()
    {
        Debug.Log("�A�C�e���g�p�I");
    }

    // ���X�N���v�g�̓������\�b�h�����s
    public void EscapeButton()
    {
        Debug.Log("������I");
    }
}
