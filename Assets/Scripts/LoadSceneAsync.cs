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

            //ei näytetä skeneä vielä
            async.allowSceneActivation = false;
        }

        if (waitForLoad == true) //kun painettu spacea
        {
            timer += Time.deltaTime;
            
            //Simuloidaan "raskasta peliä, jossa lataus kestäisi n. 5 sekuntia:
            //if (timer > waitTime) //5 sekuntia on kulunut
            
            //todellisuudessa esim. näin:
            if(async.progress >= 0.9f) //kun 90% skenestä ladattu
            {
                waitForLoad = false;
                //vaihdetaan skene
                async.allowSceneActivation = true;
            }
        }
    }
}
