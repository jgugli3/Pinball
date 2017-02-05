using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightFlipper : MonoBehaviour
{
    HingeJoint2D[] hingeJoints;
    JointMotor2D jointMotor;

    void Start()
    {
        hingeJoints = gameObject.GetComponents<HingeJoint2D>();
        jointMotor = hingeJoints[1].motor;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            jointMotor.motorSpeed = -1000;
        }
        else
        {
            jointMotor.motorSpeed = 500;
        }
        hingeJoints[1].motor = jointMotor;
    }
}
