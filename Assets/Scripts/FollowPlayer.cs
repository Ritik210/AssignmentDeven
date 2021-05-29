using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowPlayer : MonoBehaviour
{
    public Transform playerObj;
    public NavMeshAgent follower;
    // Start is called before the first frame update

    private void Awake()
    {
        GetComponent<FollowPlayer>().enabled = false;
    }
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        follower.SetDestination(playerObj.position);
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Follow")
        {
            collision.transform.GetComponent<FollowPlayer>().enabled = true;
        }
    }


}
