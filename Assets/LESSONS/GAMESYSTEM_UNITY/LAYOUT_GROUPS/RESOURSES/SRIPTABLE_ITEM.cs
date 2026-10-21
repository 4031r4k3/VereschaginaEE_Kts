using UnityEngine;
using TMPro;

public class SRIPTABLE_ITEM : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI numberText;
    [SerializeField] private GameObject[] brightStars;
    

    public void setup(int levelNumber)
    {
        string number = levelNumber.ToString();
        numberText.text = number;
        int starsToShow = Random.Range(0, 4);
        for (int i = 0; i < brightStars.Length; i++)
        {
            if (i < starsToShow)
            {
                brightStars[i].SetActive(true);
            }
            else
            {
                brightStars[i].SetActive(false);
            }
        }
    }
}
