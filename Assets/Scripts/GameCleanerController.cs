using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameCleanerController : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
           other.GetComponent<PlayerHealth> ().MakeDead ();     
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene ("GameLevel");
    }

    public void StopGame()
    {
        Application.Quit();
    }
}
