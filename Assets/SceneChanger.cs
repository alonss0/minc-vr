using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    //public GameObject fader;
    public void NextScene()
    {
        //fader.gameObject.GetComponent<OVRScreenFade>().FadeOut();
        SceneManager.LoadScene("FirstScene");
    }
}
