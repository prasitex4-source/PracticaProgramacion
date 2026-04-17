using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAnim : MonoBehaviour
{
    Animator anim;

    NavMeshAgent navMeshA;

    void Start()
    {
        anim = GetComponent<Animator>();
        navMeshA = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if(navMeshA.isOnOffMeshLink)
        {
            anim.SetInteger("jump", 1);
        }

        else
        {
            anim.SetInteger("jump", 0);
        }
    }

    /*void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Salta"))
        {
            Debug.Log("Salta");
            anim.SetInteger("jump", 1);
        }
    }*/
}
