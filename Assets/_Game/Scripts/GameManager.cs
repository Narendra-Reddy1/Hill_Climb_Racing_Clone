using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance { get; private set; }

    [HideInInspector]
    public int score ;
    [HideInInspector]
    public float fillFuel = 1;

    private void Awake()
    {
        instance = this;
    }


}
