using System;
using Unity.VisualScripting;
using UnityEngine;

public class MenyController : MonoBehaviour
{
    [SerializeField] private GameObject playButton;
    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject backButton;
    [SerializeField] private GameObject openLevel;
    [SerializeField] private GameObject lockedLevel;
    [SerializeField] private Transform LevelsGrid;
    [SerializeField] private int totalLevelNumber = 15;
    [SerializeField] private int openLevelNumber = 13;

    void Start()
    {
        for (int i = 0; i < openLevelNumber; i++)
        {
            GameObject newLevel = Instantiate(openLevel, LevelsGrid);
            SRIPTABLE_ITEM item = newLevel.GetComponent<SRIPTABLE_ITEM>();
            item.setup(i + 1);
            LevelsGrid.gameObject.SetActive(false);
        }
        for (int i = 0; i < totalLevelNumber - openLevelNumber; i++)
        {
            GameObject newLockedLevel = Instantiate(lockedLevel, LevelsGrid);
        }
    }

    public void Play()
    {
        playButton.SetActive(false);
        backButton.SetActive(true);
        panel.SetActive(true);
        LevelsGrid.gameObject.SetActive(true);
    }

    public void Back()
    {
        playButton.SetActive(true);
        backButton.SetActive(false);
        panel.SetActive(false);
        LevelsGrid.gameObject.SetActive(false);
    }
}
