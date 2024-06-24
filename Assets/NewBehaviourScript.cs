using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    int conteo = 1;
    public GameObject[] Aparición;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            conteo++;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {

        }
    }
}
