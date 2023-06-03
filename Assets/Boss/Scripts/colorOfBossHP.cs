using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colorOfBossHP : MonoBehaviour
{
    public bossSpeedChanger boss;
    public Image[] sprite;

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < sprite.Length; i++)
        {
            if (boss.bossColor == 1)
            {
                sprite[i].color = new Color(0, 0, 1, 1);
            }
            else if (boss.bossColor == 2)
            {
                sprite[i].color = new Color(1, 0, 0, 1);
            }
            else if (boss.bossColor == 3)
            {
                sprite[i].color = new Color(0, 1, 0, 1);
            }
            else
            {
                sprite[i].color = new Color(0.7f, 0, 1, 1);
            }
        }
    }
}
