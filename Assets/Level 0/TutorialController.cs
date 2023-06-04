using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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
    private bool waitWait;
    private bool Epress;
    public AudioSource audioSource;
    public AudioClip clip;


    void Start()
    {
        player.GetComponent<shootingNormal>().enabled = false;
        player.GetComponent<Reloading>().enabled = false;
        player.GetComponent<Movement>().enabled = false;
        data.toGoal = false;
        data.toShooting = false;
        data.movementDone = false;
        data.shootingDone = false;
        data.goalDone = false;
        audioSource.PlayOneShot(clip, 0.5f);
        StartCoroutine(ShowSpaceGirl());

    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Epress = true;
        }
    }
    void FixedUpdate()
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
        if (Epress == true)
        {
            Epress = false;
            if (textCounter < data.movementTutorial.Length && !data.movementDone)
            {
                audioSource.PlayOneShot(clip, 0.5f);
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
                StartCoroutine (HideSpaceGirl());
            }
            if (textCounter <= data.shootingTutorial.Length && !data.shootingDone && data.toShooting)
            {
                if (textCounter < data.shootingTutorial.Length)
                    text.text = data.shootingTutorial[textCounter];
                player.GetComponent<shootingNormal>().enabled = false;
                player.GetComponent<Movement>().enabled = false;
                player.GetComponent<Reloading>().enabled = false;
                audioSource.PlayOneShot(clip, 0.5f);

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
                player.GetComponent<Reloading>().enabled = true;

                data.shootingDone = true;
                textCounter = 0;
                StartCoroutine(HideSpaceGirl());
            }
            if (textCounter <= data.goalTutorial.Length && !data.goalDone && data.toGoal)
            {
                if (textCounter < data.goalTutorial.Length)
                    text.text = data.goalTutorial[textCounter];
                player.GetComponent<shootingNormal>().enabled = false;
                player.GetComponent<Movement>().enabled = false;
                player.GetComponent<Reloading>().enabled = false;
                audioSource.PlayOneShot(clip, 0.5f);

                textCounter++;

            }
            if (textCounter > data.goalTutorial.Length && !data.goalDone && data.toGoal)
            {
                player.GetComponent<shootingNormal>().enabled = true;
                player.GetComponent<Movement>().enabled = true;
                player.GetComponent<Reloading>().enabled = true;

                data.goalDone = true;
                textCounter = 0;
                StartCoroutine(HideSpaceGirl());
            }
        }
        if (textCounter == 0)
        {
            if (!data.shootingDone && data.toShooting)
            {
                player.GetComponent<shootingNormal>().enabled = false;
                player.GetComponent<Movement>().enabled = false;
                player.GetComponent<Reloading>().enabled = false;
                audioSource.PlayOneShot(clip, 0.5f);

                text.text = data.shootingTutorial[textCounter];
                textCounter++;
            }
            if (!data.goalDone && data.toGoal)
            {
                player.GetComponent<shootingNormal>().enabled = false;
                player.GetComponent<Movement>().enabled = false;
                player.GetComponent<Reloading>().enabled = false;
                audioSource.PlayOneShot(clip, 0.5f);

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
        audioSource.PlayOneShot(clip, 0.5f);
        textCounter = 4;
        data.toShooting = true;
    }
    IEnumerator ShowSpaceGirl()
    {
        waitWait = true;
        for (int i = 0; i < 35; i++)
        {
            spaceGirl.transform.Translate(Vector3.right);
            yield return new WaitForSeconds(0.01f);
        }
        waitWait = false;
    }
    IEnumerator HideSpaceGirl()
    {
        waitWait = true;
        for (int i = 0; i < 35; i++)
        {
            spaceGirl.transform.Translate(Vector3.left);
            yield return new WaitForSeconds(0.01f);
        }
        waitWait = false;
    }
}
