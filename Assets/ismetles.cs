using UnityEngine;

class ismetles : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("Hello Krumpli");
        // állítás átfordítása bool fireIsHot = true; true|DE! !fireIsHot = false

        //negálás -: int szam = 10; int osszeg = -szam;( -szam = -10)

        //modulo: maradékszámítás: %

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

        //kasztolás

        float f = 5.4f;
        int rnumb = 3;

        float fII = rnumb; //a 3 az float lett
        int rnumbII = (int)f; // 5.4 -> 5-lett, mint int.

    }
}
