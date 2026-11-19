using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float speedOfTime;
    private float timeLimit = 20f;
    [SerializeField] private  float currentTime;
    private float otherCurrentTime;
    private float currentTimeOnEnterIf;
    private bool somethingCheckThingy = true;

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
            SceneManager.LoadScene(1);
        }

        if (speedOfTime == 1f)
        {
            somethingCheckThingy = true;
        }

        if (speedOfTime < 1f)
        {
            if (somethingCheckThingy == true)
            {
                currentTimeOnEnterIf = currentTime - 2.5f;
                somethingCheckThingy = false;
            }

            if (currentTimeOnEnterIf >= currentTime)
            {
                speedOfTime = 1f;
            }
        }
    }
}
