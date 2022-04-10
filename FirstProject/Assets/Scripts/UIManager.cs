using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<UIManager>();
            }
            return instance;
        }
    }
    private static UIManager instance;

    public Image hp;
    public Text scoreText;
    int score = 0;

    private void Start()
    {
        StartCoroutine(ScoreCount());
    }

    public void HpDecrease()
    {
        hp.fillAmount -= 0.1f;
    }

    IEnumerator ScoreCount()
    {
        while (true)
        {
            scoreText.text = "Á¡¼ö : " + score;
            yield return new WaitForSeconds(0.1f);
        }
    }

    public void GetScore()
    {
        score++;
    }
}
