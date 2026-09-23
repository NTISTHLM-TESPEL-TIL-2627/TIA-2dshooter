using UnityEngine;

public class BoltController : MonoBehaviour
{
  [SerializeField]
  float speed = 120f;

  void Update()
  {
    transform.Translate(Vector2.up * speed * Time.deltaTime);

    if (transform.position.y > Camera.main.orthographicSize)
    {
      Destroy(this.gameObject);
    }
  }

  void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.gameObject.tag == "Enemy")
    {
      Destroy(this.gameObject);
    }
  }

}
