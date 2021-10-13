using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public ButtonManager instance;

    public void OnClick()
    {
        if(instance == null)
        {
            throw new System.Exception("Button instance is null!");
        }

        instance.OnClick(this.gameObject.name);
    }

    protected virtual void OnClick(string buttonName)
    {

    }
}
