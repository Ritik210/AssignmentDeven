using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int speed = 10;
    public int sideMovement = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        float translation = Input.GetAxis("Horizontal") *Time.deltaTime * sideMovement;
        transform.Translate(translation,0,0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Follow")
        {
            collision.transform.GetComponent<FollowPlayer>().enabled = true;
        }

    }
}
