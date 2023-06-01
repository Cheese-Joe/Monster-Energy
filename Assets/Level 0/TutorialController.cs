using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;

public class TutorialController : MonoBehaviour
{
    public TutorialData data;
    public GameObject player;
    public GameObject cameraA;
    public HP_system hp;
    private int textCounter;
    public TMP_Text text;
    public GameObject spaceGirl;
    public MoneyCount money;

    // Start is called before the first frame update
    void Start()
    {
        player.GetComponent<shootingNormal>().enabled = false;
        player.GetComponent<Movement>().enabled = false;
        data.toGoal = false;
        data.toShooting = false;
        data.movementDone = false;
        data.shootingDone = false;
        data.goalDone = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!money.gameBeaten)
        {
            if (hp.HP_current < 2)
            {
                hp.HP_current = hp.HP_max;
            }
        }
        if (!data.toGoal)
        {
            hp.current_gun = 0;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (textCounter < data.movementTutorial.Length && !data.movementDone)
            {
                textCounter++;
                if (textCounter < data.movementTutorial.Length)
                {
                    text.text = data.movementTutorial[textCounter];

                }
            }
            if (textCounter == data.movementTutorial.Length && !data.movementDone)
            {
                player.GetComponent<Movement>().enabled = true;
                textCounter = 0;
                data.movementDone = true;
                spaceGirl.transform.DOMoveX(-40f, 1f).SetRelative(true).SetLoops(2, LoopType.Incremental);
            }
            if (textCounter <= data.shootingTutorial.Length && !data.shootingDone && data.toShooting)
            {
                if (textCounter < data.shootingTutorial.Length)
                    text.text = data.shootingTutorial[textCounter];
                player.GetComponent<shootingNormal>().enabled = false;
                player.GetComponent<Movement>().enabled = false;
                textCounter++;
                if (textCounter == 2)
                {
                    StartCoroutine(cameraJokes());
                }
            }
            if (textCounter > data.shootingTutorial.Length && !data.shootingDone && data.toShooting)
            {
                player.GetComponent<shootingNormal>().enabled = true;
                player.GetComponent<Movement>().enabled = true;
                cameraA.GetComponent<Camera2s>().enabled = true;
                data.shootingDone = true;
                textCounter = 0;
                spaceGirl.transform.DOMoveX(-40f, 1f).SetRelative(true).SetLoops(2, LoopType.Incremental);
            }
            if (textCounter <= data.goalTutorial.Length && !data.goalDone && data.toGoal)
            {
                if (textCounter < data.goalTutorial.Length)
                    text.text = data.goalTutorial[textCounter];
                player.GetComponent<shootingNormal>().enabled = false;
                player.GetComponent<Movement>().enabled = false;
                textCounter++;

            }
            if (textCounter > data.goalTutorial.Length && !data.goalDone && data.toGoal)
            {
                player.GetComponent<shootingNormal>().enabled = true;
                player.GetComponent<Movement>().enabled = true;
                data.goalDone = true;
                textCounter = 0;
                spaceGirl.transform.DOMoveX(-40f, 1f).SetRelative(true).SetLoops(2, LoopType.Incremental);
            }
        }
        if (textCounter == 0)
        {
            if (!data.shootingDone && data.toShooting)
            {
                player.GetComponent<shootingNormal>().enabled = false;
                player.GetComponent<Movement>().enabled = false;
                text.text = data.shootingTutorial[textCounter];
                textCounter++;
            }
            if (!data.goalDone && data.toGoal)
            {
                player.GetComponent<shootingNormal>().enabled = false;
                player.GetComponent<Movement>().enabled = false;
                text.text = data.goalTutorial[textCounter];
                textCounter++;
            }
        }
    }
    IEnumerator cameraJokes()
    {
        data.toShooting = false;
        cameraA.GetComponent<Camera2s>().enabled = false;
        textCounter = 3;
        cameraA.transform.DOMoveX(15f, 4f).SetRelative(true).SetLoops(1, LoopType.Incremental);
        yield return new WaitForSeconds(4f);
        text.text = data.shootingTutorial[textCounter];
        textCounter = 4;
        data.toShooting = true;
    }
}
