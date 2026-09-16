using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
  [SerializeField]
  GameObject enemyPrefab;

  float timeSinceLastEnemy = 0;
  [SerializeField]
  float timeBetweenEnemies = 1f;

  void Update()
  {
    Instantiate(enemyPrefab);
  }
}
