using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animationscript : MonoBehaviour
{
    public Animator Meleeanimation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Animationcorroutine());
    }

    IEnumerator Animationcorroutine()
    {
        Meleeanimation.SetBool("Attack", true);
        yield return new WaitForSeconds(1f);
        Meleeanimation.SetBool("Attack", false);
    }
}
