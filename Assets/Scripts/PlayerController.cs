using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20;
    private float turnSpeed = 45;
    private float horizontalInput;
    private float verticalInput;
    public GameObject behindCam;
    public GameObject perspectiveCam;
    [SerializeField]
    private KeyCode switchCamKey;

    public static PlayerController _instance { private set; get; }

    [SerializeField]
    public string inputID;

    void Awake() {
        _instance = this;
    }

    void Start()
    {
        behindCam = GameObject.Find("BehindCamera" + inputID); 
        perspectiveCam = GameObject.Find("PerspectiveCamera" + inputID);
        perspectiveCam.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       

        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        verticalInput = Input.GetAxis("Vertical" + inputID);
        //Move forward car
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        //Rotates car
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);

    }
    void LateUpdate() {
        if (Input.GetKeyUp(switchCamKey))
        {
            //behindCam.GetComponent<Camera>().enabled = !perspectiveCam.GetComponent<Camera>().enabled;
            //perspectiveCam.GetComponent<Camera>().enabled = !behindCam.GetComponent<Camera>().enabled;
            behindCam.SetActive(perspectiveCam.active);
            perspectiveCam.SetActive(!behindCam.active);
        }
    }
}
