using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gauntlet : MonoBehaviour
{
    public GameObject Normal;
    public GameObject Snap;
    
    public int Uses;
    public string UseText;
    
    // Use this for initialization
    void Start()
    {
        Normal.SetActive(true);
        Snap.SetActive(false);

        Uses = 2;
    }

    // Update is called once per frame
    void Update()
    {
       if (Uses == 2)
        {
            UseText = " use remaining!";
        }
       else
        {
            UseText = " uses remaining!";
        }

    }
    private void OnMouseEnter()
    {
        Debug.Log("Make Thanos snap his fingers!" + "Uses left: " + Uses);
    }
    private void OnMouseDown()
    {
        if (Uses > 0)
        {
            Normal.SetActive(false);
            Snap.SetActive(true);
            Use();
            Debug.Log("Thanos snaps his fingers and half of all life is killed! " + "You have " + Uses + UseText);

        }

    }
    private void OnMouseExit()
    {
        Normal.SetActive(true);
        Snap.SetActive(false);
        
    }
    void Use()
    {
        Uses = Uses - 1;
    }
    
}
