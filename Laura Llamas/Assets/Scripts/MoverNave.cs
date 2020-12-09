using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoverNave : MonoBehaviour
{

    public float speed;
    Vector3 pos1;
    private float moveSpeed = 5f;

    [SerializeField] Text Tiempo;
    [SerializeField] GameObject bola;
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

    }
}
