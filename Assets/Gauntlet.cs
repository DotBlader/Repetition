using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gauntlet : MonoBehaviour
{
    public GameObject Normal;
    public GameObject Snap;
    public GameObject White;

    private float timer;

    // Use this for initialization
    void Start()
    {
        Normal.SetActive(true);
        Snap.SetActive(false);
        White.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseDown()
    {
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
