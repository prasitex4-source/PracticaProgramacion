using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float jumpForce = 2f;
    private InputManager inputManager;
    private Rigidbody rb;
    public bool isGrounded = true;


    void Awake()
    {
        inputManager = GetComponent<InputManager>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 move = new Vector3(inputManager.movementInput.x, 0, inputManager.movementInput.y);
        transform.position += move * speed * Time.deltaTime;

        if (inputManager.jumpPressed && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce);
            isGrounded = false;
            Debug.Log("salta");
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Suelo"))
        {
            isGrounded = true;
        }
    }
}
