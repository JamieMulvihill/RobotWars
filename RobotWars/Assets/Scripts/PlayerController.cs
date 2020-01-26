using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb {
        get {
            return GetComponent<Rigidbody>();
        }
    }

    public string playerHOR, PlayerVer, PlayerInter;
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 current = rb.velocity;
        if (Mathf.Abs(Input.GetAxis(playerHOR)) > 0.01f || Mathf.Abs(Input.GetAxis(PlayerVer)) > 0.01f){
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(new Vector3(Input.GetAxis(playerHOR), 0, Input.GetAxis(PlayerVer)), transform.up), 0.3f);
        }

        rb.velocity = transform.forward *
            new Vector3( Mathf.Abs(Input.GetAxis(playerHOR)), 0, Mathf.Abs(Input.GetAxis(PlayerVer))).magnitude;
        rb.velocity = new Vector3(rb.velocity.x, 0, rb.velocity.z) * 10;
        rb.velocity += new Vector3(0, 0, 0);
    }
}
