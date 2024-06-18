using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] FloatVariable playerHealth;

    [SerializeField] FloatVariable pearlsCollected;

    int score;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            playerHealth.ChangeValue(-10f);
        }

        if (Input.GetKeyDown(KeyCode.P)) //ker‰‰ valkoisen helmen
        {
            pearlsCollected.Value += 1;
            score = 100;
        }


        if (Input.GetKeyDown(KeyCode.R)) //ker‰‰ valkoisen helmen
        {
            pearlsCollected.Value += 1;
            score = 300;
        }

     
    }

    private void OnApplicationQuit() //Kun editorista stoppaa pelin
    {        // (EI TARVITSE BUILDISSA)
        playerHealth.Value = 100;
    }
}
