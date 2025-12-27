using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Teaching.Octopus
{
	public class EnemyManager : MonoBehaviour
	{
		[SerializeField] private Transform _parent;

		[Header("Пример 1. Враги (Simple Enemy Factory)")]
		[SerializeField] private GameObject _patrulEnemyPrefab;
		[SerializeField] private GameObject _superEnemyPrefab;
		[SerializeField] private GameObject _flyerEnemyPrefab;

		[SerializeField] private Transform _playerTransform;

		[SerializeField] private Transform _flyerSpawnPosition;

		[SerializeField] private float _flyerSpawnTime;

		private EnemyPool _enemyPool = null!;
		private EnemyFactory _enemyFactory = null!;

		private void Awake()
		{
			Transform parent = _parent != null ? _parent : transform;

			///	int num = (5 > 4) ? 3 : 1;

			_enemyPool = new EnemyPool(parent, new Dictionary<EnemyType, GameObject?>
			{
				{ EnemyType.Patrul, _patrulEnemyPrefab },
				{ EnemyType.Super, _superEnemyPrefab },
				{ EnemyType.Flyer,  _flyerEnemyPrefab }
			});

			_enemyFactory = new EnemyFactory(_enemyPool);

			StartCoroutine(SpawnFlyerByTime());

		}

		public GameObject SpawnEnemy(EnemyType type, Vector3 position)
		{
			return _enemyFactory.Create(type, position);
		}

		public void DespawnEnemy(EnemyType type, GameObject enemy)
		{
			_enemyFactory.Release(type, enemy);
		}

		private IEnumerator SpawnFlyerByTime()
		{
			while (true)
			{
                yield return new WaitForSeconds(_flyerSpawnTime);
                var enemy = SpawnEnemy(EnemyType.Flyer,_flyerSpawnPosition.position);
				enemy.GetComponent<FlyEnemy>().SetTarget(_playerTransform);
            }

        }
	}
}
