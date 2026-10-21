using System;
using Unity.VisualScripting;
using UnityEngine;

public class MenyController : MonoBehaviour
{
    [SerializeField] private GameObject playButton;
    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject backButton;
    [SerializeField] private GameObject level;
    [SerializeField] private Transform LevelsGrid;
    [SerializeField] private int levelNumber = 15;

    void Start()
    {
        for (int i = 0; i < levelNumber; i++)
        {
            GameObject newLevel = Instantiate(level, LevelsGrid);
            newLevel.GetComponent<SRIPTABLE_ITEM>();
        }
    }

    public void Play()
    {
        playButton.SetActive(false);
        backButton.SetActive(true);
        panel.SetActive(true);
    }

    public void Back()
    {
        playButton.SetActive(true);
        backButton.SetActive(false);
        panel.SetActive(false);
    }
}
