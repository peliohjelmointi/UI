using UnityEngine;

public class PrintHealth : MonoBehaviour
{
    [Header("Drag Scriptable Object here")]
    [SerializeField] SO so;

    private void Start()
    {
        print(so.name);
        print(so.health);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject go = Instantiate(so.prefab);
            go.name = so.name;
        }
    }
}
