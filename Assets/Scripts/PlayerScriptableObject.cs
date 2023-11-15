using UnityEngine;

[CreateAssetMenu(fileName = "Player", menuName = "ScriptableObjects/Player")]

public class PlayerScriptableObject : ScriptableObject
{
    public int health = 100;
    
    public float moveSpeed = 10f;
    public float jumpHeight = 18f;
    
    

}
