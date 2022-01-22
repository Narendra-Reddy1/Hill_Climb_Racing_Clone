using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager instance { get; private set; }

    public TMP_Text coinsText;
    private void Awake()
    {
        instance = this;
    }


    public void UpdateScore()
    {
        coinsText.text = GameManager.instance.score.ToString();
    }
}
