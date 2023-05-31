using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "TutorialData", menuName = "Game Events/Tutorial")]
public class TutorialData : ScriptableObject
{
    public string[] movementTutorial;
    public string[] shootingTutorial;
    public string[] goalTutorial;
    public bool toShooting;
    public bool toGoal;
    public bool movementDone;
    public bool shootingDone;
    public bool goalDone;
}
