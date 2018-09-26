using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneItem : MonoBehaviour
{
    public string itemDes; //föremålets beskrivning
    public string itemUse; //beskrivning för när man använder föremålet
    private SpriteRenderer spriteR; //sprite för föremålet

    // Use this for initialization
    void Start()
    {
        spriteR = GetComponent<SpriteRenderer>(); //get:ar componenten
    }

    private void OnMouseEnter() //när manmarkerar objektet
    {
        Debug.Log(itemDes); //skriver beskrivningen i console
        spriteR.color = Color.Lerp(Color.white, Color.gray, 10); //ändrar färgen

    }
    private void OnMouseExit() //när musen slutar markera
    {
        spriteR.color = Color.Lerp(spriteR.color, Color.white, 10); //ändra färgen igen
    }
    private void OnMouseDown() //när man klickar
    {
        Debug.Log(itemUse); //skriver användningstexten
        spriteR.color = Color.Lerp(spriteR.color, Color.black, 10); //ändrar färgen
    }
    private void OnMouseUpAsButton() //när man släpper upp musknappen efter man har klickat
    {
        spriteR.color = Color.Lerp(spriteR.color, Color.gray, 10); //ändrar färgen igen
    }
}
