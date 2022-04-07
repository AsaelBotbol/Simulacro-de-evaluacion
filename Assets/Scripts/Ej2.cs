using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej2 : MonoBehaviour
{
    public int prod1;
    public int prod2;
    public int prod3;
    public int dinerodisp;
    // Start is called before the first frame update
    void Start()
    {
        int suma = prod1 + prod2 + prod3;
        if(suma > dinerodisp)
        {
            int falta = suma - dinerodisp;
            Debug.Log("No tenes el dinero suficiente, te faltan $" + falta);

        }else if(suma < dinerodisp)
        {
            int sobra = dinerodisp - suma;
            Debug.Log("Si, puedes comprar los productos. Te sobran $" + sobra);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
