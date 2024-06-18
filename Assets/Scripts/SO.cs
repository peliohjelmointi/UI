using UnityEngine;

[CreateAssetMenu(menuName ="SO/PlayerSO", fileName ="PlayerSO")]
public class SO : ScriptableObject
{
    [Header("Prefab")]
    public GameObject prefab;
       
    public string playerName;

    public int health;
}
