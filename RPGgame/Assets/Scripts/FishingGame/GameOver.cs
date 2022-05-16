using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public GameObject gameoverPanel;
    public Text gameoverText;

    // Start is called before the first frame update
    void Start()
    {
        gameoverPanel.SetActive(false);
    }
    public void Gameover()
    {
        char[] levelChar = { 'S', 'M', 'L' }; 
        gameoverText.text = fishingButton.isSuccess ? "GAME CLEAR\n<color=yellow>you got "+levelChar[GameLevel.level-1]+ " Fish!</color>" : "GAMEOVER";
        gameoverPanel.SetActive(true);
        Hearts.heart--;
        Hearts.HeartControll();
        fishingButton.isSuccess = false;
    }

    public void BackToMap()
    {
        SceneManager.LoadScene("Forest");
    }

    public void PlayAgain()
    {
        GameLevel.level = 1;
        GameLevel.size = 0.35f;
        GameLevel.speed = 3f;
        SceneManager.LoadScene("GameFishing");
    }
}
