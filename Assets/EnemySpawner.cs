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
    timeSinceLastEnemy += Time.deltaTime;

    if (timeSinceLastEnemy > timeBetweenEnemies)
    {
      Instantiate(enemyPrefab);
      timeSinceLastEnemy = 0;
    }

  }
}
