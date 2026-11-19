using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] float speedOfTime;
    private float timeLimit = 20f;
    private float currentTime;
    private float otherCurrentTime;

    public TMP_Text textThingy;
    void Start()
    {
        currentTime = timeLimit;
        textThingy.SetText("Time: " + currentTime);;
    }

    private void FixedUpdate()
    {
        currentTime -= Time.fixedDeltaTime * speedOfTime;

        otherCurrentTime = Mathf.Round(currentTime);
        
        textThingy.SetText("Time: " + otherCurrentTime);;

        if (currentTime <= 0f)
        {
            SceneManager.LoadScene("YouDied");
        }
    }
}
