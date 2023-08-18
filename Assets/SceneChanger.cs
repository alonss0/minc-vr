using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    //public GameObject fader;
    public void FirstScene()
    {
        SceneManager.LoadScene("FirstScene");
    }
    public void SecondScene()
    {
        SceneManager.LoadScene("SecondScene");
    }
    public void ThirdScene()
    {
        SceneManager.LoadScene("ThirdScene");
    }
    public void IntroScene()
    {
        SceneManager.LoadScene("IntroScene");
    }
}
