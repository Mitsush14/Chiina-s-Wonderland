using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showingScaleText : MonoBehaviour
{
    GameObject cameraToLook;
    float scale;
    GameObject text;
    [SerializeField]
    private GameObject scaleText;
    // Start is called before the first frame update
    void Start()
    {
        scale = transform.localScale.x;
        cameraToLook = GameObject.FindGameObjectWithTag("HandCamera");
        if(scaleText){
            showScaleText();
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v = cameraToLook.transform.position - transform.position;
        v.x = v.z = 1.0f;
        transform.LookAt(cameraToLook.transform.position - v);
        transform.Rotate(0,180,0);
        if(scale != transform.localScale.x){
            scale = transform.localScale.x;
            Destroy(text);
            showScaleText();
        }
    }

    void showScaleText(){
        text = Instantiate(scaleText, transform.position, Quaternion.identity, transform);
        text.GetComponent<TextMesh>().text = transform.localScale.x.ToString();
    }
}
