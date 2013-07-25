using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {
    
    public KeyCode key_up;
    public KeyCode key_down;

    // Use this for initialization
    void Start () {
    
    }
    
    // Update is called once per frame
    void Update () {
    
    }
    
    void FixedUpdate () {

        GameObject wallTop = GameObject.Find("WallTop");
        GameObject wallBottom = GameObject.Find("WallBottom");

        Vector3 pos = transform.position;
        Vector3 sca = transform.lossyScale;
        Vector3 topPos = wallTop.transform.position;
        Vector3 topSca = wallTop.transform.lossyScale; 
        Vector3 bottomPos = wallBottom.transform.position;
        Vector3 bottomSca = wallBottom.transform.lossyScale;
        
        if (Input.GetKey(key_up)) {
            if (!(pos.z + (sca.z / 2.0f) >= (topPos.z - (topSca.z / 2.0f)))) {
                transform.position = new Vector3(pos.x, pos.y, pos.z + 10.0f);
            }
        }
        
        if (Input.GetKey(key_down)) {
            if (!(pos.z - (sca.z / 2.0f) <= (bottomPos.z + (bottomSca.z / 2.0f)))) {
                transform.position = new Vector3(pos.x, pos.y, pos.z - 10.0f);
            }
        }
    }

}
