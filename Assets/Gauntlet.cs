using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gauntlet : MonoBehaviour
{
    public GameObject Normal; //objektet för handen när den är normal
    public GameObject Snap; //objektet för handen när den knäpper
    public SpriteRenderer NormalGaunt; //spriten för normala handen
    
    public float Uses; //floaten för hur många uses man har
    public string UseText; //string för " uses remaining"
    
    // Use this for initialization
    void Start()
    {
        Normal.SetActive(true); //sätter på normala handen
        Snap.SetActive(false); //stänger av knäppta handen

        Uses = 2; //sätter att man ska ha två uses
    }

    // Update is called once per frame
    void Update()
    {
       if (Uses == 2) //om uses är två
        {
            UseText = " use remaining!"; //gör texten till use
        }
       else
        {
            UseText = " uses remaining!"; //gör texten till uses
        }

    }
    private void OnMouseEnter() //när man markerar objektet
    {
        Debug.Log("Make Thanos snap his fingers!" + "Uses left: " + Uses); //skriver vad som händer om man klickar och hur många uses man har i console
        NormalGaunt.color = Color.Lerp(NormalGaunt.color, Color.grey, 10); //ändrar färgen på normala handen för att visa att den blir markerad
    }
    private void OnMouseDown() //när man klickar
    {
        if (Uses > 0) //om man har uses kvar
        {
            Normal.SetActive(false); //stänger av normala handen
            Snap.SetActive(true); //sätter på knäppta handen
            Use(); //utför use funktionen
            Debug.Log("Thanos snaps his fingers and half of all life is killed! " + "You have " + Uses + UseText); //skriver vad som händer osv
            NormalGaunt.color = Color.Lerp(NormalGaunt.color, Color.white, 10); //ändrar tillbaka färgen på handen
        }

    }
    private void OnMouseExit() //när musen inte längre markerar objektet
    {
        Normal.SetActive(true); //sätter på normala handen
        Snap.SetActive(false); //stänger av knäppta handen
        NormalGaunt.color = Color.Lerp(NormalGaunt.color, Color.white, 10); //ändrar tillbaka färgen på handen
    }
    void Use() //funktionen för use
    {
        Uses = Uses - 1; //tar bort en från uses
    }
    
}
