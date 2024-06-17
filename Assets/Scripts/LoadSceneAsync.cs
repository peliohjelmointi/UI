using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneAsync : MonoBehaviour
{
    AsyncOperation async;

    bool waitForLoad;
    float timer;
    float waitTime;

    private void Start()
    {
        waitTime = 5.0f; //5 sekuntia
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            waitForLoad = true;
            //aloitetaan skenen lataaminen taustalla
            async = SceneManager.LoadSceneAsync("UI");

            //ei n�ytet� skene� viel�
            async.allowSceneActivation = false;
        }

        if (waitForLoad == true) //kun painettu spacea
        {
            timer += Time.deltaTime; //timer l�htee nollasta etenem��n
            
            //Simuloidaan "raskasta peli�, jossa lataus kest�isi n. 5 sekuntia:
            //if (timer > waitTime) //5 sekuntia on kulunut
            
            //todellisuudessa esim. n�in:
            if(async.progress >= 0.9f) //kun 90% skenest� ladattu
            {
                waitForLoad = false;
                //vaihdetaan skene
                async.allowSceneActivation = true;
            }
        }
    }
}
