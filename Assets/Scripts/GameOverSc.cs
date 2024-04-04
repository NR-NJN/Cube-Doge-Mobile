using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Threading;
public class GameOverSc : MonoBehaviour
{
    public GameObject gameOverscreen;
    public TextMeshProUGUI secondsSurvived;

    bool isGameOver;

    private void Start()
    {
        FindObjectOfType<PlayerController>().OnPlayerdeath += OnGameOver;
    }
    void Update()
    {
        if (isGameOver)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(0);
            }
        }
    }

    void OnGameOver()
    {
        gameOverscreen.SetActive(true);
        secondsSurvived.text = Mathf.RoundToInt(Time.timeSinceLevelLoad).ToString(); 
        isGameOver = true;
        Spawner.counter = 0;
    }
}
