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
    [SerializeField] private int totalLevels = 15;

    void Start()
    {
        for (int i = 0; i < totalLevels; i++)
        {
            GameObject newLevel = Instantiate(level, LevelsGrid);
            SRIPTABLE_ITEM item = newLevel.GetComponent<SRIPTABLE_ITEM>();
            item.setup(i + 1);
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
