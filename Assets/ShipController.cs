using UnityEngine;
using UnityEngine.InputSystem;

public class ShipController : MonoBehaviour
{
  Vector2 movement = Vector2.zero;

  float speed = 5f;

  [SerializeField]
  GameObject boltPrefab;
 
  void Update()
  {
    Instantiate(boltPrefab, transform.position, Quaternion.identity);
    transform.Translate(movement * speed * Time.deltaTime);
  }
  
  void OnMove(InputValue value)
  {
    movement = value.Get<Vector2>();
    // print("I'd like to move it, move it");
  }
}
