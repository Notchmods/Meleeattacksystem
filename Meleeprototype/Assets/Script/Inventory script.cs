using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attackscript : MonoBehaviour
{
    public Transform Sword;
    public Transform Rapier;
    public Transform Axe;
    public int Weaponary = 0;
    public int Swordnum;
    public int Rapiernum;
    public int Axenum;
    public bool gotweapon;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit Rayshit;
            if (Physics.Raycast(transform.position, transform.forward, out Rayshit, 5f))
            {
                if (Rayshit.transform.tag == "Enemies")
                {
                    if(gotweapon == true)
                    {
                        Rayshit.transform.gameObject.SetActive(false);
                    }
                }
                if (Rayshit.transform.tag == "Sword")
                {
                    Swordnum = Weaponary + 1;
                    Weaponary += 1;
                    gotweapon = true;
                    if(Weaponary == 1)
                    {
                        Sword.gameObject.SetActive(true);
                    }
                    Rayshit.transform.gameObject.SetActive(false);
                }
                if (Rayshit.transform.tag == "Rapier")
                {
                    Rapiernum = Weaponary + 1;
                    Weaponary += 1;
                    gotweapon = true;
                    if (Weaponary == 1)
                    {
                        Rapier.gameObject.SetActive(true);
                    }
                    Rayshit.transform.gameObject.SetActive(false);
                }
                if (Rayshit.transform.tag == "Axe")
                {
                    Axenum = Weaponary + 1;
                    Weaponary += 1;
                    gotweapon = true;
                    if (Weaponary == 1)
                    {
                        Axe.gameObject.SetActive(true);
                    }
                    Rayshit.transform.gameObject.SetActive(false);
                }
            }
        }
        if (Input.GetKeyDown(Swordnum.ToString()))
        {
            Axe.gameObject.SetActive(false);
            Sword.gameObject.SetActive(true);
            Rapier.gameObject.SetActive(false);
        }
        if (Input.GetKeyDown(Axenum.ToString()))
        {
            Axe.gameObject.SetActive(true);
            Sword.gameObject.SetActive(false);
            Rapier.gameObject.SetActive(false);
        }
        if (Input.GetKeyDown(Rapiernum.ToString()))
        {
            Axe.gameObject.SetActive(false);
            Sword.gameObject.SetActive(false);
            Rapier.gameObject.SetActive(true);
        }
    }

}
