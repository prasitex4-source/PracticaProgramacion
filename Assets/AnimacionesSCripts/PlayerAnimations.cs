using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAnimations : MonoBehaviour
{
    Animator anim;
    PlayerMovement playerMov;
    InputManager inputMan;

    void Start()
    {
        anim = GetComponent<Animator> ();
        playerMov = GetComponent<PlayerMovement>();
        inputMan = GetComponent<InputManager>();
    }

    void Update()
    {
        
       
       if (!playerMov.isGrounded)
        {
            anim.SetInteger("Movement", 2);
        }

        else if (inputMan.movementInput.sqrMagnitude > 0)
        {
            anim.SetInteger("Movement", 1);
        }

        else
        {
            anim.SetInteger("Movement", 0);
        }

        if (inputMan.movementInput.x == -1)
        {
            Quaternion currentRotation = Quaternion.Euler(new Vector3 (0, -90, 0));
            transform.rotation = currentRotation;
        }
        if (inputMan.movementInput.x == 1)
        {
            Quaternion currentRotation = Quaternion.Euler(new Vector3 (0, 90, 0));
            transform.rotation = currentRotation;
        }
        if (inputMan.movementInput.y == -1)
        {
            Quaternion currentRotation = Quaternion.Euler(new Vector3 (0, 180, 0));
            transform.rotation = currentRotation;
        }
        if (inputMan.movementInput.y == 1)
        {
            Quaternion currentRotation = Quaternion.Euler(new Vector3 (0, 0, 0));
            transform.rotation = currentRotation;
        }
    }
}