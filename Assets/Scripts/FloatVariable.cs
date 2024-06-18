using UnityEngine;

[CreateAssetMenu(menuName="SO/Float Variable", fileName ="Float Variable")]
public class FloatVariable : ScriptableObject
{
    public float Value;

    public void ChangeValue(float amount)
    {
        Value += amount;
    }

    //private void OnDisable()
    //{
    //    Value = 50f;
    //}
}
