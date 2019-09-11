using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class Levelswitcher : MonoBehaviour {


    void Start()
    {


        Advertisement.Initialize("2626287");

    }
    public void LevelI()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void LevelII()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        
    }
    public void LevelIII()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }
    public void LevelIV()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }
    public void LevelV()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
    }
    public void I()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
    }
    public void II()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }
    }
    public void III()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }
    }
    public void IV()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }
    }
    public void V()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
