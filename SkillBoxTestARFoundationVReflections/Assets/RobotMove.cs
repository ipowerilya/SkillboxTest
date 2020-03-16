using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class RobotMove : MonoBehaviour
{
    
    public Rigidbody rb;
    private Animator RobotAnim;
    public bool MoveWithJoystick;
    // Start is called before the first frame update
    public void Awake()
    {
        rb = GetComponent<Rigidbody>();
      
        RobotAnim = GetComponent<Animator>();
        MoveWithJoystick = true;
    }
    // Update is called once per frame
    void Update()
    {
        float x = CrossPlatformInputManager.GetAxis("Horizontal");
        float y = CrossPlatformInputManager.GetAxis("Vertical");
       
        Vector3 movement = new Vector3(x, 0, y);
        rb.velocity = movement * 0.3f;
        if (rb.velocity.x != 0 || rb.velocity.z != 0)
        {
            transform.localEulerAngles = new Vector3(0, Mathf.Atan2(rb.velocity.x, rb.velocity.z) * Mathf.Rad2Deg, 0);

            RobotAnim.Play("Run");
        }
        else
        {
            RobotAnim.Play("Stop");
        }
    }
}
