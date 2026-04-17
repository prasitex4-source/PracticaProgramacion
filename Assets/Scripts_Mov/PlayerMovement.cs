using UnityEditor.Callbacks;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    private InputManager inputManager;

    void Awake()
    {
        inputManager = GetComponent<InputManager>();
    }

    void Update()
    {
        Vector3 move = new Vector3(inputManager.movementInput.x, 0, inputManager.movementInput.y);

        transform.position += move * speed * Time.deltaTime;
    }
}
