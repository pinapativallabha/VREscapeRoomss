using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anicontrolroom1 : MonoBehaviour
{
    private Animator pa;
    public PadCondition pc;
    // Start is called before the first frame update
    void Start()
    {
        pa = GetComponent<Animator>();
        pc = GameObject.Find("r").GetComponent<PadCondition>();
        pa.SetBool("trig", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (pc.currentIndex == 1)// THIS WAS SUPPOSED TO WORK FOR 0 NOT 1 AAAAAAAAHHHHHHHHHHHHHHHHHHHHHHHHHHHH
        {
            pa.SetBool("trig",true);
        }
        
        
    }
}
