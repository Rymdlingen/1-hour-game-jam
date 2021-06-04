using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KiwiCount : MonoBehaviour
{
    TextMeshProUGUI kiwiCountText;
    TextMeshProUGUI gameOver;
    TextMeshProUGUI highScoreText;

    int kiwisInScene;
    int highScore;

    // Start is called before the first frame update
    void Start()
    {
        kiwiCountText = GetComponent<TextMeshProUGUI>();
        gameOver = GameObject.Find("GameOverText").GetComponent<TextMeshProUGUI>();
        highScoreText = GameObject.Find("HighScoreText").GetComponent<TextMeshProUGUI>();

        kiwisInScene = FindObjectsOfType<MoveKiwi>().Length;
        highScore = kiwisInScene;
        kiwiCountText.SetText(kiwisInScene.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        if (FindObjectsOfType<MoveKiwi>().Length != kiwisInScene)
        {
            kiwisInScene = FindObjectsOfType<MoveKiwi>().Length;
            kiwiCountText.SetText(kiwisInScene.ToString());
        }

        if (kiwisInScene > highScore)
        {
            highScore = kiwisInScene;
        }

        if (kiwisInScene == 0)
        {
            gameOver.SetText("The kiwis did not find enough food and because of that they did not survive.");
            if (highScore < 2)
            {
                highScoreText.SetText("At most you had " + highScore + " kiwi.");
            }
            else
            {
                highScoreText.SetText("At most you had " + highScore + " kiwis.");
            }
        }
    }
}
