using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform target;
    private Vector3 offSet;
    private Vector3 rotateCamera =new Vector3(13,0,0);
    [SerializeField] GameObject player;
    [SerializeField] GameObject cameraPoint;
    bool cameraCheck = false;



    private void Awake()
    {
        target = GameObject.FindWithTag(player.tag).transform;
    }
    void Start()
    {
        offSet = transform.position - target.position;
    }

    
    private void LateUpdate()
    {
        CameraPoint();
    }
   
    private void CameraPoint()
    {
        if (cameraCheck)
        {
            target = GameObject.FindWithTag(cameraPoint.tag).transform;
            transform.position = target.position;
            transform.rotation = target.rotation;
        }
        else
        {
            target = GameObject.FindWithTag(player.tag).transform;
            transform.position = target.position + offSet;
            transform.rotation = Quaternion.Euler(13,0,0);
        }
    }
    private void CameraPointCheck()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            cameraCheck = true;
        }
        else if (Input.GetKey(KeyCode.Alpha1))
        {
            cameraCheck = false;
        }

    }
}
