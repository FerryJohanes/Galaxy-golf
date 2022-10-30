using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject gameOverPanel;
    [SerializeField] TMP_Text gameOverText;
    [SerializeField] PlayerController player;
    [SerializeField] Hole hole;
    [SerializeField] AudioSource holesfx;

    private void Start()
    {
        gameOverPanel.SetActive(false);
    }
    private void Update()
    {
        if (hole.Entered && gameOverPanel.activeInHierarchy == false)
        {
            gameOverPanel.SetActive(true);
            holesfx.Play();
            gameOverText.text = "Level Completed! " +
                "\n Shoot Count: " + player.ShootCount;
        }
    }
    public void BackToMainMenu()
    {
        SceneLoader.Load("MainMenu");
    }
    
    public void Replay()
    {
        SceneLoader.ReloadLevel();
    }

    public void PlayNext()
    {
        SceneLoader.LoadNextLevel();
    }
}
