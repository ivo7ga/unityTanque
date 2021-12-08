using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlTanque : MonoBehaviour
{

    public float speed;
    public float speedRotation;
    public GameObject bala;
    public GameObject cañon;
    public bool bReady;
    public float contador;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
        if (bReady == true)
        {
            contador += Time.deltaTime;
            if (contador > 0.5f)
            {
                Debug.Log("Cañon cargado de nuevo");
                contador = 0;
                bReady = false;

            }
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject g = Instantiate(bala, cañon.transform.position, cañon.transform.rotation);
            g.GetComponent<Rigidbody>().AddForce(g.transform.forward * 1000);
            bReady = true;

        }

            if (Input.GetKey(KeyCode.W)|| Input.GetKey(KeyCode.UpArrow))
            {
                this.transform.Translate(new Vector3(0, 0, 1) * speed * Time.deltaTime, Space.Self);

            }
            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                this.transform.Translate(new Vector3(0, 0, -1) * speed * Time.deltaTime, Space.Self);

            }
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                this.transform.Rotate(new Vector3(0, 1, 0) * speedRotation * Time.deltaTime);

            }
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                this.transform.Rotate(new Vector3(0, -1, 0) * speedRotation * Time.deltaTime);

            }
    }
        
}
