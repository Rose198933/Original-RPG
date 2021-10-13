using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CreateMenu/CreateEnemyDatabase", fileName = "EnemyDatabase")]
public class EnemyDatabase : ScriptableObject
{
    public List<Enemy> enemyDatabase = new List<Enemy>();
}
