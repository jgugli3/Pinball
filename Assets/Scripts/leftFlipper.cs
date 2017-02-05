using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftFlipper : MonoBehaviour
{
    HingeJoint2D[] hingeJoints;
    JointMotor2D jointMotor;

    void Start()
    {
        hingeJoints = gameObject.GetComponents<HingeJoint2D>();
        jointMotor = hingeJoints[0].motor;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            jointMotor.motorSpeed = 500;
        }
        else
        {
            jointMotor.motorSpeed = 0;
        }
        hingeJoints[0].motor = jointMotor;
    }
}
