using UnityEngine;

public class EnemyController : MonoBehaviour
{
  [SerializeField]
  float speed = 3f;

  [SerializeField]
  GameObject explosionPrefab;

  void Start()
  {
    transform.position = new(
      Random.Range(-6f, 6f),
      Camera.main.orthographicSize + 1);
  }

  void Update()
  {
    transform.Translate(Vector2.down * speed * Time.deltaTime);

    if (transform.position.y < -Camera.main.orthographicSize)
    {
      Destroy(this.gameObject);
    }
  }

  void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.gameObject.tag == "Projectile")
    {
      Destroy(this.gameObject);
      Instantiate(explosionPrefab,
        transform.position,
        Quaternion.identity);
    }
  }
}
