using UnityEngine;

class ismetles : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("Hello Krumpli");
        // �ll�t�s �tford�t�sa bool fireIsHot = true; true|DE! !fireIsHot = false

        //neg�l�s -: int szam = 10; int osszeg = -szam;( -szam = -10)

        //modulo: marad�ksz�m�t�s: %

        /*int number = 23;
        int numberII = 5;

        Debug.Log(number % numberII); //3
        */

        // float

        var vmi = 5; //integer
        var vmiII = 5f; //float
        float vmiIIV = 5.4f; //float
        float vmiIV = 5; //float
        float vmiV = 2.4f + 4f; //float

        //kasztol�s

        float f = 5.4f;
        int rnumb = 3;

        float fII = rnumb; //a 3 az float lett
        int rnumbII = (int)f; // 5.4 -> 5-lett, mint int.

    }
}
