using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;

    public int P1Life;
    public int P2Life;

    public GameObject p1Wins;
    public GameObject p2Wins;

    public GameObject[] p1sticks;
    public GameObject[] p2sticks;

    public AudioSource hurtSound;

    public string mainMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(P1Life <= 0)
        {
            player1.SetActive(false);
            p2Wins.SetActive(true);
        }
        if(P2Life <= 0)
        {
            player2.SetActive(false);
            p1Wins.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(mainMenu);
        }
    }
    public void HurtP1()
    {
        P1Life -= 1;
        for(int i = 0; i < p1sticks.Length; i++)
        {
            if(P1Life > i)
            {
                p1sticks[i].SetActive(true);
            }
            else
            {
                p1sticks[i].SetActive(false);
            }
        }
        hurtSound.Play();
    }
    public void HurtP2()
    {
        P2Life -= 1;
        for (int i = 0; i < p2sticks.Length; i++)
        {
            if (P2Life > i)
            {
                p2sticks[i].SetActive(true);
            }
            else
            {
                p2sticks[i].SetActive(false);
            }
        }
        hurtSound.Play();
    }
    
}
