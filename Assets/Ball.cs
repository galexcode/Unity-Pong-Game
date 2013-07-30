using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

    // Use this for initialization
    void Start () {
        float initialVelocity = 700.0f;
        float xVel = Random.Range(1, 10);
        float zVel = Random.Range(1, 2);

        // Randomly adjust direction so the ball doesn't always fly up/right.
        if (Random.value > 0.5) {
            xVel *= -1;
        }

        if (Random.value > 0.5) {
            zVel *= -1;
        }

        // Reset position and velocity.
        transform.position = new Vector3(0, 0, 0);
        rigidbody.velocity = new Vector3(0, 0, 0);

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

        else if (collision.collider.name == "PaddleLeft") {
            GameObject paddle = GameObject.Find("PaddleLeft");
            float pPos = paddle.transform.position.z;
            float bPos = transform.position.z;
            rigidbody.AddForce(
                new Vector3(0, 0, (8.0f * (bPos - pPos))),
                ForceMode.Impulse);
        }

        else if (collision.collider.name == "PaddleRight") {
            GameObject paddle = GameObject.Find("PaddleRight");
            float pPos = paddle.transform.position.z;
            float bPos = transform.position.z;
            rigidbody.AddForce(
                new Vector3(0, 0, (8.0f * (bPos - pPos))),
                ForceMode.Impulse);
        }
    }
}
