using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gauntlet : MonoBehaviour
{
    public GameObject Normal;
    public GameObject Snap;
    public Transform White;


    public float timer;
    private bool PosBottom;
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
    private void OnMouseDown()
    {
        timer = 10.05f;
        if (timer <= 10f && timer >= 5f && PosBottom == true)
        {
            White.transform.Translate(0f, 100f, 0, Space.World);
            PosBottom = false;
        }
        if (timer <= 10f && timer >= 5f && PosBottom == false)
        {
            White.transform.Translate(0f, -100f, 0, Space.World);
            PosBottom = true;
        }
            Debug.Log("Thanos snaps his fingers and half of all life is killed!");
            Normal.SetActive(false);
            Snap.SetActive(true);

    }
    private void OnMouseExit()
    {
        Normal.SetActive(true);
        Snap.SetActive(false);
    }
}
