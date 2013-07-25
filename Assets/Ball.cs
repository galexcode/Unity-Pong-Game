using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

    // Use this for initialization
    void Start () {

        /*
        rigidbody.velocity = new Vector3(1.0f,
                                         0.0f,
                                         0.0f);
        */
        rigidbody.AddForce(new Vector3(500, 0, 500), ForceMode.Impulse);
    }
    
    // Update is called once per frame
    void Update () {
        
    }

    void FixedUpdate () {
        //rigidbody.velocity = rigidbody.velocity.normalized * 500.0f;
    }
    
    void OnCollisionEnter(Collision collision) {
        if (collision.collider.name == "WallLeft") {
            
        }

        else if (collision.collider.name == "WallRight") {
            
        }
        
        else if (collision.collider.name == "WallTop") {
            /*
            rigidbody.velocity = new Vector3(rigidbody.velocity.x,
                                             rigidbody.velocity.y,
                                             rigidbody.velocity.z * -1.0f); 
            */
        }
        
        else if (collision.collider.name == "WallBottom") {
            /*
            rigidbody.velocity = new Vector3(rigidbody.velocity.x,
                                             rigidbody.velocity.y,
                                             rigidbody.velocity.z * -1.0f);
            */
        }
        
        else if (collision.collider.name == "PaddleLeft") {
            /*
            rigidbody.velocity = new Vector3(rigidbody.velocity.x * -1.0f,
                                             rigidbody.velocity.y,
                                             rigidbody.velocity.z);
            */
        }
         
        else if (collision.collider.name == "PaddleRight") {
            /*
            rigidbody.velocity = new Vector3(rigidbody.velocity.x * -1.0f,
                                             rigidbody.velocity.y,
           */ 
        }

    }
}
