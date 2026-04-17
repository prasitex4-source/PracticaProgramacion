using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAnimations : MonoBehaviour
{
    Animator anim;
    [SerializeField] int mov;
    void Start()
    {
        anim = GetComponent<Animator> ();
        mov = anim.GetInteger("Movement");
    }

    void Update()
    {
       
    }
}
