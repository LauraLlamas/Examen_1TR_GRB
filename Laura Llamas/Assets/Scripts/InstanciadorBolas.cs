﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstanciadorBolas : MonoBehaviour
{
    [SerializeField] GameObject Bola;
    Vector3 pos;
    [SerializeField] Informacion BolasNumero;
    [SerializeField] Informacion Bolasnumero;

    private float randomNumber;
    Vector3 RandomPos;
    void Start()
    {
        bolasIniciales();
        StartCoroutine("InstanciadorEsferas");
        Bolasnumero = FindObjectOfType<Informacion>();
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

    void crearBolas()
    {
        float randomPosZAux = Random.Range(-20f, 20f);
        float randomPosXAux = Random.Range(-20f, 20f);
        float randomPosYAux = Random.Range(2f, 20f);
        pos = new Vector3(randomPosXAux, randomPosYAux, randomPosZAux);
        Instantiate(Bola, pos, Quaternion.identity);
    }

    IEnumerator InstanciadorEsferas()
    {
        for (; ; )
        {

            crearBolas();
            float interval = 1f;

            yield return new WaitForSeconds(interval);
            // contaodor++

        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            print("Chocado");
            Destroy(gameObject);
            Destroy(other.gameObject);

            //contador++;
            // print(contador);

            //creador.numeroBalas--;

        }
    }

}