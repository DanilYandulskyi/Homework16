using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class EnemySpawner : MonoBehaviour 
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private List<Transform> _transforms;

    private int _maxDirection = 1;
    private int _minDirection = -1;
    private int _waitTime = 2;

    private void Awake()
    {
        StartCoroutine(SpawnEnemies());
    }

    private void Spawn()
    {
        Vector3 position = _transforms[Random.Range(0, _transforms.Count)].position;

        Enemy enemy = Instantiate(_enemy, position, Quaternion.identity);

        enemy.Initialize(new Vector3(Random.Range(_minDirection, _maxDirection), 0, Random.Range(_minDirection, _maxDirection)));
    }

    private IEnumerator SpawnEnemies()
    {
        bool isSpawning = true;

        while (isSpawning)
        {
            yield return new WaitForSeconds(_waitTime);
            Spawn();
        }
    }
}
