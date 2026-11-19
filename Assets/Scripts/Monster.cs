using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Monster : MonoBehaviour
{    
    [SerializeField] private float Health;
    public Button button;
    [SerializeField] private Timer _timer;

    public void Start()
    {
        button.onClick.AddListener(loseHealth);
    }

    public void loseHealth()
    {
        Health--;

        if (Health <= 0)
        {
            Destroy(gameObject);
            _timer.speedOfTime = 0.5f;

        }
    }
}

