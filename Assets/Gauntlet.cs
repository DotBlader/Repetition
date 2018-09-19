using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gauntlet : MonoBehaviour
{
    public GameObject Normal;
    public GameObject Snap;
    


    public float timer;
    public bool PosBottom;
    // Use this for initialization
    void Start()
    {
        Normal.SetActive(true);
        Snap.SetActive(false);
        
        timer = 0f;
        PosBottom = true;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

    }
    private void OnMouseEnter()
    {
        Debug.Log("Make Thanos snap his fingers!");
    }
    private void OnMouseDown()
    {
        
        if (PosBottom == true)
        {
            PosBottom = false;
        }
        if (PosBottom == false)
        {
            PosBottom = true;
        }
        Normal.SetActive(false);
        Snap.SetActive(true);
        Debug.Log("Thanos snaps his fingers and half of all life is killed!");

    }
    private void OnMouseExit()
    {
        Normal.SetActive(true);
        Snap.SetActive(false);
    }
}
