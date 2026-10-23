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
    [SerializeField] private int lockedLevelStart = 13;
    [SerializeField] private int[] starsForLevels;

    void Start()
    {
        if (lockedLevelStart > totalLevelNumber) lockedLevelStart = totalLevelNumber;

        for (int i = 0; i < totalLevelNumber; i++)
        {
            int currentLevelNumber = i + 1;
            if (currentLevelNumber < lockedLevelStart)
            {
                GameObject newLevel = Instantiate(openLevel, LevelsGrid);
                SRIPTABLE_ITEM item = newLevel.GetComponent<SRIPTABLE_ITEM>();
                int stars = (i < starsForLevels.Length) ? starsForLevels[i] : 0;
                item.setup(currentLevelNumber, stars);
            }
            else
            {
                GameObject newlockedLevel = Instantiate(lockedLevel, LevelsGrid);
            }

            LevelsGrid.gameObject.SetActive(false);
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
