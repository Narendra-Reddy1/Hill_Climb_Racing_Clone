using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{

/*
    public Rigidbody2D FrontTyre;
    public Rigidbody2D BackTyre;*/
   [SerializeField]private Rigidbody2D m_carRigidbody;
   [SerializeField]private WheelJoint2D frontWheel;
   [SerializeField]private WheelJoint2D rearWheel;
   [SerializeField]private  UnityEngine.UI.Image fuelImage;

    public float m_fuel;
    private float fuelConsumption = 0.1f;
    private float movement;
    [SerializeField]private float m_carSpeed = 100;


    private void Awake()
    {
        m_fuel = GameManager.instance.fillFuel;
        CheckDependecies();
    }


    void Update()
    {
        movement = Input.GetAxis("Horizontal");
        fuelImage.fillAmount = m_fuel;
    }
    private void FixedUpdate()
    {
        JointMotor2D motor = new JointMotor2D {motorSpeed= -movement *m_carSpeed , maxMotorTorque=10000f };
       
    
       if (m_fuel > 0)
        {
            rearWheel.motor = motor;
        }

        m_fuel -= fuelConsumption*Mathf.Abs(movement)*Time.fixedDeltaTime;
    }

    private void CheckDependecies()
    {

        if (m_carRigidbody == null)
            m_carRigidbody = GetComponent<Rigidbody2D>();
        if (frontWheel == null || rearWheel == null)
            Debug.LogError("Add front and rear wheel dependecis!! ");
            
    }
}
