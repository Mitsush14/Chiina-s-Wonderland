using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uiChiina : MonoBehaviour
{
    GameObject Chiina;
    private static float ChiinaScale;
    [SerializeField]
    private Text ChiinaScaleText;
    [SerializeField]
    private Text ChiinaCompteur;

    // Start is called before the first frame update
    public void Start()
    {
        Chiina = GameObject.FindGameObjectWithTag("Chiina");
        ChiinaScale = 0.25f;
    }

    // Update is called once per frame
    void Update()
    {
        ChiinaScaleText.text = "Taille de Chiina : " + ChiinaScale.ToString();
        ChiinaCompteur.text = "Compteur de Chiina : " + Chiina.GetComponent<grandir>().getCompteur().ToString();
    }

    public static void changeChiinaScale(float x){
        ChiinaScale = x-2.0f;
    }
}
