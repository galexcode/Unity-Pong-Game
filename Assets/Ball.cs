using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

    // Use this for initialization
    void Start () {
        float initialVelocity = 700.0f;
        float xVel = Random.value;
        float zVel = Random.value;

        transform.position = new Vector3(0, 0, 0);

        Vector3 baseVector = new Vector3(xVel, 0, zVel);
        Vector3 startVector = initialVelocity * baseVector.normalized;

        rigidbody.AddForce(
            startVector,
            ForceMode.Impulse);
    }
    
    // Update is called once per frame
    void Update () {
        
    }

    void FixedUpdate () {
    }
    
    void OnCollisionEnter(Collision collision) {
        if (collision.collider.name == "WallLeft") {
            GameObject camera = GameObject.Find("Main Camera");
            GameGUI gui = camera.GetComponent<GameGUI>();
            gui.IncLeftScore();
            this.Start();
        }

        else if (collision.collider.name == "WallRight") {
            GameObject camera = GameObject.Find("Main Camera");
            GameGUI gui = camera.GetComponent<GameGUI>();
            gui.IncRightScore();
            this.Start(); 
        }
    }
}
