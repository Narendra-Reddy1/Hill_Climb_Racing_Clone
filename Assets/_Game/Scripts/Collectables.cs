using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour
{

    [SerializeField] private CarController carController;

    [SerializeField] private bool isCoin;
    [SerializeField] private bool isFuel;

    private void Awake()
    {
        if (carController == null)
            carController = GameObject.Find("Car Controller").GetComponent<CarController>();
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (isCoin) 
        { 
            GameManager.instance.score++;
            UIManager.instance.UpdateScore();
        }

        else if (isFuel) carController.m_fuel = GameManager.instance.fillFuel;

        Debug.Log(GameManager.instance.score);
        Destroy(gameObject);
    }
}
