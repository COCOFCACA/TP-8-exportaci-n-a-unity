using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    int conteo = 1;
    public GameObject[] arrayobjectos;
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject modelo in arrayobjectos)
        {
            modelo.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            conteo += 1;
            if (conteo > arrayobjectos.Length - 1)
            {
                conteo = 0;
            }
            foreach (GameObject modelo in arrayobjectos)
            {
                modelo.SetActive(false);
            }
            arrayobjectos[conteo].SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            conteo -= 1;
            if (conteo < 0)
            {
                conteo = arrayobjectos.Length - 1;
            }
            foreach (GameObject modelo in arrayobjectos)
            {
                modelo.SetActive(false);
            }
            arrayobjectos[conteo].SetActive(true);
        }
    }
}
