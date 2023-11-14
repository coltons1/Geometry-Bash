using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Health", menuName = "Health System/Health")]
public class Health : ScriptableObject
{
    public float maxHP = 100;
    public Slider healthbar;

}
