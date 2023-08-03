using UnityEngine;
using UnityEngine.SceneManagement;

public class OnButtonXHold : MonoBehaviour
{
    private float pointerDownTimer;
    private OVRScreenFade screenFade;
    public float requiredHoldTime;
    public GameObject cameraFade;

    private void Start()
    {
        screenFade = cameraFade.GetComponent<OVRScreenFade>();
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.Three))
        {
            pointerDownTimer += Time.deltaTime;
            OVRInput.SetControllerVibration(0, 1);
            screenFade.SetUIFade(pointerDownTimer);
            if (pointerDownTimer >= requiredHoldTime)
            {
                SceneManager.LoadScene("IntroScene");
            }
        }

        if (OVRInput.GetUp(OVRInput.Button.Three))
        {
            Reset();
        }
    }

    public void Reset()
    {
        pointerDownTimer = 0;
        screenFade.SetUIFade(pointerDownTimer);
    }
}
