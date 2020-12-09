using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Informacion : MonoBehaviour
{

    [SerializeField] Text Tiempo;
    [SerializeField] Text Bolasnumero;
    public float speed;
    [SerializeField] InstanciadorBolas Bola;
    public static int contador = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Distancia");
      Bola = FindObjectOfType<InstanciadorBolas>();
    }

    // Update is called once per frame
    void Update()
    {
        Bolasnumero.text = "Bolas: " + contador;
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