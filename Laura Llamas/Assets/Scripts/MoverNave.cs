using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MoverNave : MonoBehaviour
{
    [SerializeField] Text Alerta;
 
    Vector3 pos1;
    private float moveSpeed = 5f;

 
    void Start()
    {
       
    }

    
    void Update()
    {
        moverNave();
    }


    void moverNave()
    {
        float desplX = Input.GetAxis("Horizontal");
        float desplY = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * desplY);
        transform.Translate(Vector3.right * Time.deltaTime * moveSpeed * desplX);
        transform.Translate(Vector3.up * Time.deltaTime * moveSpeed * desplY);
       /*
        void alerta()
        {
            if (desplX <=20f || >=20f)
            {
                Alerta.text = "Alerta"
            }
            if(desplY <= 20f || >= 20f)
            {
                Alerta.text = "Alerta"
            }

        }
       */
    }
   

}

    
