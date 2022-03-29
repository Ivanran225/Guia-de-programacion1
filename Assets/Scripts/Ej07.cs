using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * 7. Realizá un programa que al ingresar por Inspector tres números enteros num1, num2 y
num3, muestre el valor del mayor de todos.
En caso de igualdad entre los tres imprimir &quot;Los números son iguales&quot;. Test1: num1 =
12, num2 = 4, num3= 7. Resultado esperado: El mayor número es num1 Test2: num1

= 2, num2 = 65, num3= 8. Resultado esperado: El mayor número es num2
 */
public class Ej07 : MonoBehaviour
{
    public int num1;
    public int num2;
    public int num3;
    // Start is called before the first frame update
    void Start()
    {
        if (num1 == num2 && num1 == num3)
        {
            Debug.Log("Los 3 numeros son iguales");
        }

        Debug.Log(numeroalto(num1,num2,num3));

        numeroalto(num1, num2, num3);

    }
        int numeroalto(int n1, int n2, int n3)
        {
            if (n1 > n2 && n1 > n3)
            {
                return n1;
            }
            else if (n2 >= n3 && n2 >= n3)
            {
                return n2;
            }
            else
            {
                return n3;
            }
        }

    // Update is called once per frame
    void Update()
    {
        
    }
}
