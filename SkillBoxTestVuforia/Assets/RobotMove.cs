using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class RobotMove : MonoBehaviour
{
    public Rigidbody rb;
    public bool UseJoystick;
    public bool Up;
    public bool Down;
    public bool Left;
    public bool Right;
    public Animator RobotAnim;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        UseJoystick = true;
        RobotAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
            Vector3 localPos = transform.localPosition;
            localPos.y = 0;
            transform.localPosition = localPos;
            
        
        if(Up)
        {
            PositionUp();
        }
        if(Down)
        {
            PositionDown();
        }
        if (Left)
        {
            PositionLeft();
        }
        if (Right)
        {
            PositionRight();
        }
        
        if (Right||Left||Down||Up)
        {
           
            RobotAnim.Play("Run");

        }
        else
            RobotAnim.Play("Stop");

    }
    public void MakeDown()
    {
        if (Up)
        {
            Up = false;
        }
        else
            Up = true;
    }
    public void MakeUp()
    {
        if (Down)
        {
           Down = false;
        }
        else
           Down = true;
    }
    public void MakeLeft()
    {
        if (Left)
        {
            Left = false;
        }
        else
            Left = true;
    }
    public void MakeRight()
    {
        if (Right)
        {
            Right = false;
        }
        else
            Right = true;
    }
    public void PositionDown()
    {
        transform.Translate(0f, 0f, 1 * Time.deltaTime);
        transform.localRotation = Quaternion.Euler(0, 0, 0);
    }

    public void PositionUp()
    {
        transform.Translate(0f, 0f, 1 * Time.deltaTime);
        transform.localRotation = Quaternion.Euler(0, 180, 0);
    }

    public void PositionRight()
    {
       transform.Translate(0f, 0f, 1 * Time.deltaTime);
       transform.localRotation = Quaternion.Euler(0, 90, 0);
    }

    public void PositionLeft()
    {
       transform.Translate(0f, 0f, 1f * Time.deltaTime);
       transform.localRotation = Quaternion.Euler(0, 270, 0);
    }
}
