//El supermercado TicMarket nos pide que realicemos un programa para que sus clientes puedan calcular el costo de algunos productos que se encuentran en promoción

//Se pide que se ingrese por inspector:
//. Los nombre de tres productos
//.Los precios de cada producto
//.La cantidad de unidades deseada de cada producto

//El programa debe cumplir los siguientes requerimientos:
//Debe calcularse un descuento del 20% sobre la compra de un producto si la cantidad de unidades del mismo supera las 3. 
//El programa debe devolver un mensaje de error descriptivo si el precio del producto o la cantidad de unidades son menores a 1.
//El programa debe devolver el total de la compra de los tres productos mostrando un mensaje que incluya el monto total sin descuento, el monto de los descuentos aplicados y el total con los descuentos aplicados.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TicMarket : MonoBehaviour
{
    public string producto1;
    public string producto2;
    public string producto3;
    public float precio1;
    public float precio2;
    public float precio3;
    public int cant1;
    public int cant2;
    public int cant3;
    float descuento1;
    float descuento2;
    float descuento3;
    float descuentos;
    float montototalSinDescuento;
    float montototalConDescuento;

    // Start is called before the first frame update
    void Start()
    {
        if (precio1 < 1 || precio2 < 1 || precio3 < 1 || cant1 < 1 || cant2 < 1 || cant3 < 1)
        {
            Debug.Log("Error");
        }
          if (cant1 > 3)
           {
             descuento1 = precio1 * 0.20f;
           }
             if (cant2 > 3)
            {
                descuento2 = precio2 * 0.20f;
            }
                if (cant3 > 3)
                {
                    descuento3 = precio3 * 0.20f;
                }
                  
                   montototalSinDescuento = precio1 + precio2 + precio3;
                   descuentos = descuento1 + descuento2 + descuento3;
                   montototalConDescuento = (precio1 - descuento1) + (precio2 - descuento2) + (precio3 - descuento3);
                   Debug.Log("El monto total sin descuento es : " + montototalSinDescuento);
                   Debug.Log("El monto de los descuentos aplicados es : " + descuentos);
                   Debug.Log(" El monto total con los descuentos aplicados es : " + montototalConDescuento);
                
                  

               


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
