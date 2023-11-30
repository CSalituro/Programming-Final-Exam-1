using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void StartGame()
    {
        UiManager.instance.GameStart();
        ScoreManager.instance.startScore();
    }

    void GameOver()
    {
        UiManager.instance.GameOver();
        ScoreManager.instance.StopScore();
        
    }
}
