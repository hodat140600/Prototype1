using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerspectiveCamera : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset = new Vector3(0, 3.5f, -0.8f);
    // Start is called before the first frame update
    void Start()
    {
        //player = GameObject.Find("Vehicle");
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        //transform.rotation = player.transform.rotation;
    }
}
