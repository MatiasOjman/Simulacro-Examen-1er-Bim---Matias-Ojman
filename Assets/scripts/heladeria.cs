using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heladeria : MonoBehaviour
{
    public string gusto;
    public int cantidad;

    float valorHelado ;
    float precioGramo =1.25f;
    // Start is called before the first frame update
    void Start()
    {
        if (cantidad<250 || cantidad > 3000 || gusto!="CHO" && gusto != "FRU" && gusto != "DDL")
        {
            Debug.Log("error");
            return;
        }
        if (gusto == "CHO" || gusto == "DDL")
        {
            valorHelado = cantidad * precioGramo;
            Debug.Log  (valorHelado); 
        }
        else if (gusto == "FRU")
        {
            valorHelado = (cantidad * precioGramo) * .9f;
            Debug.Log  (valorHelado);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
