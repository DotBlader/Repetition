using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class THANUS : MonoBehaviour
{
    public GameObject thanus;
    public GameObject thanus2;
    public GameObject thanus3;

    

    // Use this for initialization
    void Start()
    {
        
        thanus.SetActive(true);
        thanus2.SetActive(false);
        thanus3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseEnter()
    {
        
        changeFace();
    }
    private void OnMouseExit()
    {
        thanus3.SetActive(false);
        thanus2.SetActive(false);
        thanus.SetActive(true);
    }
    private void OnMouseDown()
    {
        changeFaceMore();
    }
    void changeFace()
    {
        thanus3.SetActive(false);
        thanus2.SetActive(true);
        thanus.SetActive(false);
        
    }
    void changeFaceMore()
    {
        thanus3.SetActive(true);
        thanus2.SetActive(false);
        thanus.SetActive(false);
    }
}
