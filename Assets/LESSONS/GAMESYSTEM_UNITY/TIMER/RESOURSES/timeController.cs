using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Rendering;
using Unity.Collections;

public class timeController : MonoBehaviour
{

    [SerializeField] Image clocks;
    [SerializeField] TMP_Text timerText;
    [SerializeField] TMP_Text timesOn;
    [SerializeField] private float timeSec = 5f;
    private bool isTimerOn = false;
    private float timeLeft;
    private int timeCount = 0;



    public void startTimer()
    {
        timeLeft = timeSec;
        isTimerOn = true;
    }

    void Start()
    {
        timerText.text = timeSec.ToString();
    }

    void Update()
    {
        if (isTimerOn)
        {
            timeLeft = timeLeft - Time.deltaTime;
            timerText.text = timeLeft.ToString("F1");
            clocks.fillAmount = timeLeft / timeSec;
            if (timeLeft <= 0)
            {
                isTimerOn = false;
                timeLeft = 0;
                timerText.text = timeSec.ToString();
                clocks.fillAmount = 1;
                timeCount++;
                timesOn.text = timeCount.ToString();
            }
        }
    }



}