using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public Vector2 movementInput;
    public void OnMove(InputValue value)
    {
        movementInput = value.Get<Vector2>();
    }
}
