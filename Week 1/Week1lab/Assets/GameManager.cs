using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Text scoreCountText;

    [SerializeField] private GameObject victoryScreen;
    [SerializeField] private GameObject gameOverScreen;

    private GameObject player;
    private PlayerController playerScript;

    private GameObject enemy;
    private EnemyController enemyScript;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        playerScript = player.GetComponent<PlayerController>();

        enemy = GameObject.Find("Enemy");
        enemyScript = enemy.GetComponent<EnemyController>();
    }

    // Update is called once per frame
    void Update()
    {
        DisplayUI();
    }

    private void DisplayUI()
    {
        scoreCountText.text = "Score = " + playerScript.currentScore();

        if (playerScript != null && enemyScript != null)
        {
            //if(playerScript.killPlayer())
            if (playerScript.currentScore() >= 3)
            {
                victoryScreen.SetActive(true);
            }
        }
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void restartScene()
    {
        SceneManager.LoadScene(0);
    }
}
