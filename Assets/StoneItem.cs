using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneItem : MonoBehaviour
{
    public string itemDes;
    public string itemUse;
    private SpriteRenderer spriteR;

    // Use this for initialization
    void Start()
    {
        spriteR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseEnter()
    {
        Debug.Log(itemDes);
        spriteR.color = Color.Lerp(Color.white, Color.gray, 10);

    }
    private void OnMouseExit()
    {
        spriteR.color = Color.Lerp(spriteR.color, Color.white, 10);
    }
    private void OnMouseDown()
    {
        Debug.Log(itemUse);
        spriteR.color = Color.Lerp(spriteR.color, Color.black, 10);
    }
    private void OnMouseUpAsButton()
    {
        spriteR.color = Color.Lerp(spriteR.color, Color.gray, 10);
    }
}
