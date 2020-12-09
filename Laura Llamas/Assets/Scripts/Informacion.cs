using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Informacion : MonoBehaviour
{

    [SerializeField] Text Tiempo;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Distancia");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Distancia()
    {
       
        for (int n = 0; ; n++)
        {
            
           Tiempo.text = "Tiempo: " + n ;

           
            yield return new WaitForSeconds(1f);
        }
    }
}