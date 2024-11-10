using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject titleScreen;

    public List<GameObject> targets;
    private float spawnRate = 1.0f;

    private int score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;

    public bool isGameActive;

    public Button restartButton;


    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame(int difficulty){
        titleScreen.gameObject.SetActive(false);
        isGameActive = true;
        spawnRate /= difficulty;
        StartCoroutine(SpawnTarget());
        score = 0;
        UpdateScore(0);
    }

    public void GameOver(){
        isGameActive = false;
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);

        restartButton.onClick.AddListener(RestartGame);
    }

    IEnumerator SpawnTarget(){
        while (isGameActive){
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
        }
    }

    public void UpdateScore(int scoreToAdd){
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }

    void RestartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
