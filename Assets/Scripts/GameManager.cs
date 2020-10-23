using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    public int lives = 3;
    public int bricks = 66;
    public float resetDelay = 1f;
    public Text livesText;
    public GameObject GameOver;
    public GameObject YouWon;
    public GameObject BricksPrefab;
    public GameObject Paddle;
    public GameObject deathParticles;
    public static GameManager instance = null;
    public Text score_count;
    static public int score = 0;
    

    private GameObject clonePaddle;






    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        Setup();
    }

    //Cloning the paddle and ball when the player starts a new game
    public void Setup()
    {
        clonePaddle = Instantiate(Paddle, transform.position, Quaternion.identity) as GameObject;
        Instantiate(BricksPrefab, transform.position, Quaternion.identity);
        
    }

    //Checking for when game is over, also added a slow motion for dramatic effect when the game is over.
    void CheckGameOver()
    {
        if (bricks < 1)
        {
            YouWon.SetActive(true);
            Time.timeScale = .25f;
            Invoke("Reset", resetDelay);


        }
        if (lives < 1)
        {
            GameOver.SetActive(true);
            Time.timeScale = .25f;
            Invoke("Reset", resetDelay);

        }

    }
    //Reloading the game when the player has lost all of their lives
    void Reset()
    {

        Time.timeScale = 1f;
        SceneManager.LoadScene("MainGame");

    }
    //when the player loses a life
    public void LoseLife()
    {
        lives--;
        livesText.text = "Lives:" + lives;
        Instantiate(deathParticles, clonePaddle.transform.position, Quaternion.identity);
        Destroy(clonePaddle);
        Invoke("SetupPaddle", resetDelay);
        CheckGameOver();

    }

    void SetupPaddle()
    {
        clonePaddle = Instantiate(Paddle, transform.position, Quaternion.identity) as GameObject;
    }

    //Destroying brick
    public void DestroyBrick()
    {
        bricks--;
        CheckGameOver();
    }

}
