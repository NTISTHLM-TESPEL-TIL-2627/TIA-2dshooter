using UnityEngine;
using UnityEngine.InputSystem;

public class ShipController : MonoBehaviour
{
  Vector2 movement = Vector2.zero;

  float speed = 5f;

  [SerializeField]
  GameObject boltPrefab;

  [SerializeField]
  Transform gunPosition;

  float timeSinceLastShot = 0;
  [SerializeField]
  float timeBetweenShots = 1f;

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
}
