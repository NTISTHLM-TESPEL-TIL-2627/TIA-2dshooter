using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ShipController : MonoBehaviour
{
  Vector2 movement = Vector2.zero;

  float speed = 5f;

  [SerializeField]
  int maxHealth = 3;
  int health = 3;

  [SerializeField]
  Slider healthSlider;

  [SerializeField]
  GameObject boltPrefab;

  [SerializeField]
  Transform gunPosition;

  float timeSinceLastShot = 0;
  [SerializeField]
  float timeBetweenShots = 1f;

  void Start()
  {
    health = maxHealth;
    healthSlider.maxValue = maxHealth;
    healthSlider.value = health;
  }

  void Update()
  {
    if (timeSinceLastShot < timeBetweenShots)
    {
      timeSinceLastShot += Time.deltaTime;
    }

    transform.Translate(movement
      * speed
      * Time.deltaTime);
  }

  void OnFire(InputValue value)
  {
    if (timeSinceLastShot > timeBetweenShots)
    {
      Instantiate(boltPrefab,
        gunPosition.position,
        Quaternion.identity);
      timeSinceLastShot = 0;
    }
  }

  void OnMove(InputValue value)
  {
    movement = value.Get<Vector2>();
    // print("I'd like to move it, move it");
  }

  void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.gameObject.tag == "Enemy")
    {
      health--;
      healthSlider.value = health;
      if (health <= 0)
      {
        SceneManager.LoadScene("GameOver");
      }
    }
  }
}
