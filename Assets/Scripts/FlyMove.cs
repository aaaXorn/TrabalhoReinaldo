using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyMove : MonoBehaviour
{
    private Vector3 movement, rotation;
    public GameObject meshship;

    [SerializeField]
    private FixedJoystick moveJoystick;
    
    private void Start()
    {
        
    }
    
    private void Update()
    {
        /*
        movement = new Vector3(Input.GetAxis("Horizontal"),
                               Input.GetAxis("Vertical"), 0);
        */
        movement = new Vector3(moveJoystick.Horizontal, moveJoystick.Vertical, 0);

        rotation = new Vector3(-movement.y, movement.x, -movement.x);
        meshship.transform.localRotation = Quaternion.Euler(rotation * 30);

        transform.Translate(movement * Time.deltaTime * 40);

        transform.localPosition = Vector3.Lerp(transform.localPosition, Vector3.zero, Time.deltaTime);
    }
}
