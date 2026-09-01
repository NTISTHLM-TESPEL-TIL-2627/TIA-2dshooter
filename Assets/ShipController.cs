using UnityEngine;
using UnityEngine.InputSystem;

public class ShipController : MonoBehaviour
{
  void Start()
  {

  }

  void Update()
  {
    Vector2 movement = new(0.1f, 0);
    transform.Translate(movement);
  }
  
  void OnMove(InputValue value)
  {
    print("I'd like to move it, move it");
  }
}
