using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    //public GameObject fader;
    public void SceneGym()
    {
        SceneManager.LoadScene("SceneGym");
    }
    public void SceneTienda()
    {
        SceneManager.LoadScene("SceneTienda");
    }
    public void SceneTrocha()
    {
        SceneManager.LoadScene("SceneTrocha");
    }
    public void SceneHotel()
    {
        SceneManager.LoadScene("SceneHotel");
    }
    public void IntroScene()
    {
        SceneManager.LoadScene("IntroScene");
    }
}
