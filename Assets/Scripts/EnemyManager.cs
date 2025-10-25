using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [Header("ZoV")]
    [SerializeField] private GameObject? NormalEnemyPrefab;
    [SerializeField] private GameObject? RedEnemyPrefab;
    [SerializeField] private GameObject? ScaredEnemyPrefab;

    private EnemyFactory _enemyFactory = null!;

    private void Awake()
    {
        _enemyFactory = new EnemyFactory(transform, new Dictionary<EnemyType, GameObject?>
        {
            { EnemyType.Normal, NormalEnemyPrefab },
            { EnemyType.Red, RedEnemyPrefab },
            { EnemyType.Scared, ScaredEnemyPrefab }
        });
    }
}
