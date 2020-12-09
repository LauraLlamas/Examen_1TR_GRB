using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverNave : MonoBehaviour
{

    //Unir el prefab con el instanciador
    [SerializeField] GameObject Nave;
    Vector3 pos1;
    
    
    void Start()
    {
        pos1 = new Vector3(0, 0, 0);
        Instantiate(Nave, pos1, Quaternion.identity);
    }

    
    void Update()
    {
        
    }
}
