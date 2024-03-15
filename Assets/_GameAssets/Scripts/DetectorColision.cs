using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorColision : MonoBehaviour
{
    void OnCollisionEnter(Collision c){
        GetComponent<SpaceShipController>().enabled=false;//Desactivar componente
        GetComponent<Rigidbody>().useGravity=true;
    }
}
