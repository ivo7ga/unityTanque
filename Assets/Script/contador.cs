using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contador : MonoBehaviour
{

    public int time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (time > 1)
        {
            time--;
            
        }
        else if (time ==1)
        {
            time--;
            this.GetComponent<controlTanque>().enabled = false;
            Debug.Log("Lo siento mucho, te has quedado sin gasolina");
            Debug.Log("La proxima vez tienes que estar más listo");

        }

    }
}
