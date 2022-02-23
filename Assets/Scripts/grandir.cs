using System.Collections ;
using System.Collections.Generic ;
using UnityEngine ;
public class grandir : MonoBehaviour
{   //Création des variables globales
    public int compteur;
    // Start is called before the first frame update
    void Start () { compteur = 0; }
    // Update is called once per frame
    void Update () {}
    //Code sur la collision
    void OnCollisionEnter (Collision collision)
    {   //On prépare la transformation de l'objet
        Vector3 objectScale = transform.localScale ;
        Vector3 CubeScale = collision.transform.localScale ;
        //On gère l'ingestion de l'ennemi (Cube est l'ennemi)
        if (CubeScale.x < objectScale.x)
        {
            transform.localScale = new Vector3 (objectScale.x + (CubeScale.x / 2) , objectScale.y + (CubeScale.x / 2) , objectScale.z + (CubeScale.x / 2)) ;
            collision.gameObject.SetActive (false) ;
            if (this.tag == "Chiina"){
                compteur ++ ;
                uiChiina.changeChiinaScale(objectScale.x + (CubeScale.x / 2));
            }
        }
    }

    public int getCompteur(){return compteur;}
}