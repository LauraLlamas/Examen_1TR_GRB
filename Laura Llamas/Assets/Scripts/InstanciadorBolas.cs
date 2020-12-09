using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciadorBolas : MonoBehaviour
{
    [SerializeField] GameObject Bola;
    Vector3 pos;

    private float randomNumber;
    Vector3 RandomPos;
    void Start()
    {
        bolasIniciales();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void bolasIniciales()

    {
        for (int n = 1; n <= 19; n++)
        {
            float randomPosZAux = Random.Range(-20f, 20f);
            float randomPosXAux = Random.Range(-20f, 20f);
            float randomPosYAux = Random.Range(2f, 20f);
            pos = new Vector3(randomPosXAux, randomPosYAux, randomPosZAux);
            Instantiate(Bola, pos, Quaternion.identity);
        }
    }
}
