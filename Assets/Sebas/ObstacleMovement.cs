
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField] Transform initialPos;
    [SerializeField] Transform endPos;
    
    bool isGoing;
    Vector3 dir;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if( isGoing )
        {
          dir= endPos.position - transform.position;
          if((transform.position - endPos.position).sqrMagnitude <0.2)
            {
                isGoing = false;
            }
        }
        else
        {
            dir = initialPos.position - transform.position;
             if((transform.position - initialPos.position).sqrMagnitude <0.2)
            {
                isGoing = true;
            }
        }

<<<<<<< HEAD
        transform.position += dir.normalized * 0.001f;
=======
        transform.position += dir.normalized * 0.01f * Time.deltaTime;
>>>>>>> 9c040d1ff877fd8d3673c0852a7afc5b262574ae
    }
}
