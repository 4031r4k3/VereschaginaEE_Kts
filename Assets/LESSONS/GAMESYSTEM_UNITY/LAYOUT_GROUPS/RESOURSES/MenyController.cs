using UnityEngine;

public class MenyController : MonoBehaviour
{
    [SerializeField] private GameObject playButton;
    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject backButton;
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
