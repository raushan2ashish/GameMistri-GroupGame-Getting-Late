using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timer = 0.0f;
    public Text text;
    float TextTimer;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frameW 
    void Update()
    {

        timer += Time.deltaTime;

        if (timer < 0.0f)
        {
            timer = 0.0f;
        }

        TextTimer = Mathf.Round(timer * 10.0f) * 0.1f;
        text.text = TextTimer.ToString("F1"); // Show 1 decimal place, even for whole numbers like 30.0
    }

    public void TimePowerUp()
    {
        timer = timer - 10.0f;
    }


}
