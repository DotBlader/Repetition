using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class THANUS : MonoBehaviour
{
    public GameObject thanus; //objekt för thanos sprites
    public GameObject thanus2;
    public GameObject thanus3;

    

    // Use this for initialization
    void Start()
    {
        
        thanus.SetActive(true); //sätter på och stänger av objekten
        thanus2.SetActive(false);
        thanus3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseEnter() //när man markerar objektet
    {
        
        changeFace();
    }
    private void OnMouseExit() //när man inte längre markerar objektet
    {
        thanus3.SetActive(false); //sätter på stänger av
        thanus2.SetActive(false);
        thanus.SetActive(true);
    }
    private void OnMouseDown() //när man klickar
    {
        changeFaceMore(); //kör funktionen
    }
    void changeFace() //funktion för ändra ansiktet
    {
        thanus3.SetActive(false); //sätter på stänger av
        thanus2.SetActive(true);
        thanus.SetActive(false);
        
    }
    void changeFaceMore() //funktion för att ändra ansiktet igen
    {
        thanus3.SetActive(true); //sätter på stänger av
        thanus2.SetActive(false);
        thanus.SetActive(false);
    }
}
