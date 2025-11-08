using System.Collections.Generic;
using UnityEngine;


public class EnemyFactory
{
    //private readonly EnemyPool _enemyPool;

   // public EnemyFactory{}









   // private readonly Transform _parent;
   //  private readonly Dictionary<EnemyType, GameObject?> _prefabs;

    // public EnemyFactory(Transform parent, Dictionary<EnemyType, GameObject?> prefabs)
    // {
    //     _parent = parent;
    //      _prefabs = prefabs;
    // }

    //public GameObject? Create(EnemyType type, Vector3 position)
    //{
    //    if (!_prefabs.TryGetValue(type, out var prefab) || prefab == null)
    //    {
    //        Debug.LogWarning($"[EnemyFactory] Префаб для {type} не назначен в инспекторе.");
    //        return null;
    //    }

    //    var enemy = Object.Instantiate(prefab, position, Quaternion.identity, _parent);
    //    enemy.name = $"Enemy_{type}";
    //    return enemy;
    //}

}

public enum EnemyType
{
    Normal,
    Red,
    Scared
}
