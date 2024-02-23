using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Vector3 firstPersonPos;
    private Vector3 thirdPersonPos;
    
    // Start is called before the first frame update
    void Start()
    {
        firstPersonPos = new Vector3(0, 0.5f, 0);
        thirdPersonPos = new Vector3(2, 2.5f, -3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CameraSwitch()
    {

    }
}
