using TMPro;
using UnityEngine;

public class DetectorGemasPuntuacion : MonoBehaviour

{
    public TMP_Text textObject; 

    public int puntuacion = 0;
    public int puntosPorGema = 1;

    private void OnTriggerEnter(Collider other){
        print("Fin del trigger");
        puntuacion=puntuacion+puntosPorGema;
        textObject.GetComponentInChildren<TextMeshProUGUI>().SetText(puntuacion.ToString());
    
    }
}  