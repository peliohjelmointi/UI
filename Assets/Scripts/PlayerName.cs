using UnityEngine;

public class PlayerName : MonoBehaviour
{
    [SerializeField] Transform lookAt;
    [SerializeField] Vector3 offset;

    Camera cam; void Awake()
    {
        cam = Camera.main;
    }
    void Update()
    {
        Vector3 position = cam.WorldToScreenPoint(lookAt.position + offset);
        if (transform.position != position)
            transform.position = position;




    }
}
