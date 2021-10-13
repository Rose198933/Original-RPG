using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CreateMenu/CreatePlayerDatabase", fileName = "PlayerDatabase")]
public class PlayerDataBase : ScriptableObject
{
    public List<Player> playerDatabase = new List<Player>();
}
