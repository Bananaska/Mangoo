using System.Collections.Generic;
using UnityEngine;

public class NormalEnemyPool : MonoBehaviour
{
    [SerializeField] private GameObject _normalEnemyPrefab;
    [SerializeField]private int _poolSize;

    private List<GameObject> pooledEnemys;

    public static NormalEnemyPool Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            pooledEnemys = new List<GameObject>(_poolSize);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        for (int i = 0; i < _poolSize; i++)
        {
            CreateNormalEnemy();
        }
    }

    public GameObject GetNormalEnemy()
    {
        foreach (GameObject enemy in pooledEnemys)
        {
            if (!enemy.activeInHierarchy)
            {
                return enemy;
            }
        }
        return CreateNormalEnemy();
    }
    public void ReleaseBullet(GameObject bullet)
    {
        bullet.SetActive(false);
    }
    private GameObject CreateNormalEnemy()
    {
        GameObject obj = Instantiate(_normalEnemyPrefab);
        obj.SetActive(false);

        pooledEnemys.Add(obj);
        return obj;
    }
}
