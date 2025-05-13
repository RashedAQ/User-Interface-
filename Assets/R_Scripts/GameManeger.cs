using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManeger : MonoBehaviour
{
    public List<GameObject> targetList;
    private float spawnRate  = 1.0f;
     int score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public bool isGameActive = true;
    public Button restartButton;
    public GameObject TitleScreen;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
   
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SpawnTarget()
    {

        while (isGameActive)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targetList.Count);
            Instantiate(targetList[index]);
         
        }
    }
    public void UpdateScore(int scoreToAdd)
    {
        scoreText.text = "Score: " + score;
        score += scoreToAdd;
    }
   public void GameOver()
    {
     
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
           isGameActive = false;
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void StartGame(int Difficulty)
    {
        isGameActive = true;
        StartCoroutine(SpawnTarget());
        score = 0;
       
        UpdateScore(0);
        TitleScreen.gameObject.SetActive(false);
        spawnRate /= Difficulty;
    }
}
