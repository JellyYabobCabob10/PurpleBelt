using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControls: MonoBehaviour
{
    private Text timerText;

    private int timerCount;
    void Start()
    {
        Time.timeScale = 1f;
        StartCoroutine(CountTime());
        timerText = GameObject.Find("Score").GetComponent<Text>();
    }

    IEnumerator CountTime() 
    {
        yield return new WaitForSeconds(1f);
        timerCount++;
        timerText.text = "Score: " + timerCount;
        StartCoroutine(CountTime());
    }
}
