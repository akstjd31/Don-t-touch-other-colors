using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private void Start()
    {
        GameObject.Find("GameManager").SendMessage("GameStart");
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Obstacles") || collision.gameObject.CompareTag("Bullets") || collision.gameObject.CompareTag("Cubes"))
        {
            if (collision.gameObject.GetComponent<MeshRenderer>().material.color != gameObject.GetComponent<MeshRenderer>().material.color)
            {
                GameObject.Find("GameManager").SendMessage("Death");
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Lines") || other.gameObject.CompareTag("Bullets"))
        {
            if (other.gameObject.GetComponent<MeshRenderer>().material.color == Color.yellow)
            {
                gameObject.GetComponent<MeshRenderer>().material.color = Color.yellow;
            }
            else
            {
                gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
            }
        }

        if(other.gameObject.CompareTag("NextStage"))
        {
            GameObject.Find("GameManager").SendMessage("NextStage");
        }

    }

    public void GetInput()
    {
        m_horizontalInput = Input.GetAxis("Horizontal");
        m_verticalInput = 0.5f;
        
    }

    private void Steer()
    {
        m_steeringAngle = maxSteerAngle * m_horizontalInput;
        frontDriverW.steerAngle = m_steeringAngle;
        frontPassengerW.steerAngle = m_steeringAngle;
    }

    private void Accelerate()
    {
        frontDriverW.motorTorque = m_verticalInput * motorForce;
        frontPassengerW.motorTorque = m_verticalInput * motorForce;
    }

    private void UpdateWheelPoses()
    {
        UpdateWheelPose(frontDriverW, frontDriverT);
        UpdateWheelPose(frontPassengerW, frontPassengerT);
        UpdateWheelPose(rearDriverW, rearDriverT);
        UpdateWheelPose(rearPassengerW, rearPassengerT);
    }

    private void UpdateWheelPose(WheelCollider _collider, Transform _transform)
    {
        Vector3 _pos = _transform.position;
        Quaternion _quat = _transform.rotation;

        _collider.GetWorldPose(out _pos, out _quat);

        _transform.position = _pos;
        _transform.rotation = _quat;
    }

    private void FixedUpdate()
    {
        GetInput();
        Steer();
        Accelerate();
        UpdateWheelPoses();
    }

    private float m_horizontalInput;
    private float m_verticalInput;
    private float m_steeringAngle;

    public WheelCollider frontDriverW, frontPassengerW;
    public WheelCollider rearDriverW, rearPassengerW;
    public Transform frontDriverT, frontPassengerT;
    public Transform rearDriverT, rearPassengerT;
    public float maxSteerAngle = 30;
    public float motorForce = 50;
}
