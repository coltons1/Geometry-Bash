using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Health", menuName = "ScriptableObjects/Healthbar")]
public class Health : ScriptableObject
{
    public int MAX_HEALTH = 100;
    public int health = 100;
    public Slider healthbar;

}
