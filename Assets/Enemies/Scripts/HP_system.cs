using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "HP", menuName = "Game Events/HP")]
public class HP_system : ScriptableObject
{
    public int HP_max;
    public int HP_current;
}