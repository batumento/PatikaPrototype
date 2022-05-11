using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float turnSpeed = 30f;
    private float speed = 12f;
    private float horizontalInput;
    private float verticalInput;
    [SerializeField] string InputID;
    // Start is called before the first frame update
    private void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {
        InputController();
    }
    private void InputController()
    {
        horizontalInput = Input.GetAxis("Horizontal" + InputID);
        verticalInput = Input.GetAxis("Vertical" +InputID);

        transform.Translate(Vector3.forward*Time.deltaTime * speed * verticalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);            
        
        
    }
}
