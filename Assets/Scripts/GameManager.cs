using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    public int lives = 3;
    public int bricks = 66;
    public int bricks2 = 66;
    public float resetDelay = 1f;
    public Text livesText;
    public GameObject GameOver;
    public GameObject YouWon;
   // public GameObject BricksPrefab;
    public GameObject Paddle;
    public GameObject deathParticles;
    public static GameManager instance = null;
    public GameObject PracticeGreenBrick;
    public GameObject PracticeOrangeCube;
    public GameObject PracticeRedCube;
    public int gridX;
    public int gridY;
    public float x_space;
    public float y_space;



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
        //var Instantiatedbrick = Instantiate(BricksPrefab, transform.position, Quaternion.identity);
        //Instantiatedbrick.tag = BricksPrefab.tag;

        //Green
        for (int x = 0; x < gridX; x++)
        {
            for (int y = 0; y < 2; y++)
            {
                var position = new Vector3(x_space * x, y_space * y, z: 0);

                Instantiate(PracticeGreenBrick, position, Quaternion.identity);
            }
        }

        //Orange
        for (int x = 0; x < gridX; x++)
            for (int y = 2; y < 4; y++)
            {
                var position = new Vector3(x_space * x, y_space * y, z: 0);
                Instantiate(PracticeOrangeCube, position, Quaternion.identity);


            }
        //Red

        for (int x = 0; x < gridX; x++)
            for (int y = 4; y < 6; y++)
            {
                var position = new Vector3(x_space * x, y_space * y, z: 0);

                Instantiate(PracticeRedCube, position, Quaternion.identity);

            }
        clonePaddle = Instantiate(Paddle, transform.position, Quaternion.identity) as GameObject;

    }

    //Checking for when game is over, also added a slow motion for dramatic effect when the game is over.
    void CheckGameOver()
    {
        if (bricks < 1)
        {
            YouWon.SetActive(true);
            Time.timeScale = .25f;
            Invoke("aaa", resetDelay);
            

        }
        if (lives < 1)
        {
            GameOver.SetActive(true);
            Time.timeScale = .25f;
            Invoke("aaa", resetDelay);
            
        }
        

    }

    //Reloading the game when the player has lost all of their lives
    void aaa()
    {
        //Reset the score board
        if (lives < 1)
        {
            Time.timeScale = .25f;
            Invoke("aaa", ScoreScript.scoreValue = 0);


        }
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
