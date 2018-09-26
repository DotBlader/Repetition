using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gauntlet : MonoBehaviour
{
    public GameObject Normal;
    public GameObject Snap;
    
    public float timer;
    
    // Use this for initialization
    void Start()
    {
        Normal.SetActive(true);
        Snap.SetActive(false);
        
        timer = 0f;
        
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
