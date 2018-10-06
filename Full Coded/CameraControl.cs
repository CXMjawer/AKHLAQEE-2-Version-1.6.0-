using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    private const float Y_ANGLE_MIN = 0.0f;
    private const float Y_ANGLE_MAX = 50.0f;

    public Transform lookAt;
    public Transform camTransform;
    Transform SaveCameraProgress;
    public float distance = 10.0f;

    private float currentX = 0.0f;
    private float currentY = 45.0f;
    private float sensitivityX = 4.0f;
    private float sensitivityY = 1.0f;

    private void Start()
    {   SaveCameraProgress = camTransform;
        camTransform = transform;
    }

    private void Update()
    {
                 if( Input.GetAxis("Mouse X")<0 || Input.GetAxis("Mouse X")>0 ){ 
                currentX += Input.GetAxis("Mouse X");
                currentY += Input.GetAxis("Mouse Y");

                currentY = Mathf.Clamp(currentY, Y_ANGLE_MIN, Y_ANGLE_MAX);
    }
                    else if (!(Input.GetAxis("Mouse X")<0 || Input.GetAxis("Mouse X")>0)){
                        camTransform = SaveCameraProgress;
                        Debug.Log(" Else is activated. ");
                    }

       
    }

    private void LateUpdate()
    {
        Vector3 dir = new Vector3(0, 0, -distance);
        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
        camTransform.position = lookAt.position + rotation * dir;
        camTransform.LookAt(lookAt.position);
    }
}
