using System.Collections ;
using System.Collections.Generic ;
using UnityEngine ;
public class ennemi_mouv : MonoBehaviour
{
    GameObject plusProcheEnnemi ;
    GameObject [] toutEnnemi = new GameObject [4] ;
    float speed = 0.01f;
    // Start is called before the first frame update
    void Start ()
    {
        plusProcheEnnemi = null ;
        toutEnnemi [0] = GameObject.FindGameObjectWithTag ("Chiina") ;
        toutEnnemi [1] = GameObject.FindGameObjectWithTag ("Cube") ;
        toutEnnemi [2] = GameObject.FindGameObjectWithTag ("GreenQuad") ;
        toutEnnemi [3] = GameObject.FindGameObjectWithTag ("BlueQuad") ;
    }
    // Update is called once per frame
    void Update ()
    {
        ObjetProche () ;
        //Récupération des données des entités
        Vector3 EnnemiPosition = plusProcheEnnemi.transform.position ;
        Vector3 cubePosition = transform.position ;
        //Mouvement de l'entité
        if (EnnemiPosition.z > cubePosition.z)
        {
            cubePosition.z += speed ;
            transform.position = cubePosition ;
        }
        if (EnnemiPosition.z < cubePosition.z)
        {
            cubePosition.z -= speed ;
            transform.position = cubePosition ;
        }
        if (EnnemiPosition.x > cubePosition.x)
        {
            cubePosition.x += speed ;
            transform.position = cubePosition ;
        }
        if (EnnemiPosition.x < cubePosition.x)
        {
            cubePosition.x -= speed ;
            transform.position = cubePosition ;
        }
    }
    //Détection de l'objet le plus proche
    void ObjetProche ()
    {   //Création des variables utiles
        float distanceEnnemiProche = Mathf.Infinity ;
        plusProcheEnnemi = null ;
        //On regarde la distance de l'objet courrant à tous les autres objes de type GameObject et on change la distance
        foreach (GameObject ennemiCourant in toutEnnemi)
        {
            if (this.tag != ennemiCourant.tag)
            {   //On récupère la distance entre l'objet courrant et le nouvel ennemi
                float distanceEnnemi = (ennemiCourant.transform.position - this.transform.position).sqrMagnitude ;
                //On regarde si la distance est plus grande que la distance à l'ennemi le plus proche
                if (distanceEnnemi < distanceEnnemiProche)
                {   //Si oui, on change l'ennemi courant et la distance à l'ennemi le plus proche
                    distanceEnnemiProche = distanceEnnemi ;
                    plusProcheEnnemi = ennemiCourant ;
                }
            }
        }
    }
}