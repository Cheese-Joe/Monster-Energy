using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "HP", menuName = "Game Events/HP")]
public class HP_system : ScriptableObject
{
    public int HP_max;
    public int HP_current;
    public int current_gun;
    public int damage;
    public float direction;
}
