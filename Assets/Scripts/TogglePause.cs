using UnityEngine;

public class TogglePause : MonoBehaviour
{
    bool show;
    
    Animator animator;

    void Awake(){
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            show = !show; //muuttaa boolean-arvon vastakkaiseksi         
            
            animator.SetBool("Show", show); //asetetaan animaattorin
                                                    //parametriksi booleanin arvo
        }
    }
}
