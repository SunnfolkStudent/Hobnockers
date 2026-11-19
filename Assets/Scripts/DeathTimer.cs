using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathTimer : MonoBehaviour
{
    private float timeLimit = 5f;
    private float currentTime;
    private float otherCurrentTime;
    
    void Start()
    {
        currentTime = timeLimit;
    }

    private void FixedUpdate()
    {
        currentTime -= Time.fixedDeltaTime;

        if (currentTime <= 0f)
        {
            SceneManager.LoadScene("MainScene");
        }
    }
}