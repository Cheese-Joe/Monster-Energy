using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Temple", menuName = "Game Events/Temple")]

public class TempleData : ScriptableObject
{
    public int donation;
    public bool rainbow_bullet;
    public bool halo;
    public bool immortality;
    public int tomfoolery;
}
