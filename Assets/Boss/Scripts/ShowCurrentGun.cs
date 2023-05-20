using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCurrentGun : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite[] newSprite = new Sprite[3];
    public HP_system hp;
    private void Update()
    {
        spriteRenderer.sprite = newSprite[hp.current_gun];
    }
}
