using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SPAWNER : MonoBehaviour
{

    // Start is called before the first frame update
    public GameObject POS_1;
    public GameObject POS_2;
    public GameObject POS_3;
    public GameObject POS_4;
    public GameObject POS_5;
    public GameObject POS_6;
    public GameObject POS_7;
    public GameObject POS_8;
    public GameObject POS_9;
    public GameObject POS_10;
    public GameObject POS_11;
    public GameObject POS_12;
    public GameObject POS_13;
    public GameObject POS_14;
    public GameObject POS_15;
    public GameObject POS_16;
    public GameObject POS_17;
    public GameObject POS_18;
    public GameObject POS_19;
    public GameObject POS_20;
    public GameObject POS_21;
    public GameObject POS_22;
    public GameObject POS_23;
    public GameObject POS_24;
    public GameObject POS_25;
    public GameObject POS_26;
    public GameObject POS_27;
    public GameObject POS_28;
    public GameObject POS_29;
    public GameObject POS_30;
    public GameObject POS_31;
    public GameObject POS_32;
    public GameObject POS_33;

    public GameObject COLLECTIBLE_PREFAB;

    public int COLLECTIBLE_AMOUNT;


    //  public int RANDOM_CHECKER_1;
    //public int RANDOM_CHECKER_2;
    //public int RANDOM_CHECKER_3;
    //public int RANDOM_CHECKER_4;
    //public int RANDOM_CHECKER_5;

    public int RANDOM_POSITION;
    public int POSITIONFILLER;

     GameObject PREFAB_1;
    GameObject PREFAB_2;
    GameObject PREFAB_3;
    GameObject PREFAB_4;
    GameObject PREFAB_5;
    GameObject PREFAB_6;
    GameObject PREFAB_7;
    GameObject PREFAB_8;
    GameObject PREFAB_9;
    GameObject PREFAB_10;
    GameObject PREFAB_11;
    GameObject PREFAB_12;
    GameObject PREFAB_13;
    GameObject PREFAB_14;
    GameObject PREFAB_15;
    GameObject PREFAB_16;
    GameObject PREFAB_17;
    GameObject PREFAB_18;
    GameObject PREFAB_19;
    GameObject PREFAB_20;
    GameObject PREFAB_21;
    GameObject PREFAB_22;
    GameObject PREFAB_23;
    GameObject PREFAB_24;
    GameObject PREFAB_25;
    GameObject PREFAB_26;
    GameObject PREFAB_27;
    GameObject PREFAB_28;
    GameObject PREFAB_29;
    GameObject PREFAB_30;
    GameObject PREFAB_31;
    GameObject PREFAB_32;
    GameObject PREFAB_33;

    void Start()
    {
        RANDOM_POSITION = -1;
        COLLECTIBLE_GENERATOR();


    }

    void COLLECTIBLE_GENERATOR()
    {
        Debug.Log("COLLECTIBLE_FUNCTIONS");
        InvokeRepeating("callingPrefabs", 0.1f, 0.3f);

    }


    void callingPrefabs()
    {

        RANDOM_POSITION++;
        if (RANDOM_POSITION == 1 )
        {
            PREFAB_1 = Instantiate(COLLECTIBLE_PREFAB, POS_1.transform.position, POS_1.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;

        }
        if (RANDOM_POSITION == 2 )
        {
            PREFAB_2 = Instantiate(COLLECTIBLE_PREFAB, POS_2.transform.position, POS_2.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;

        }
        if (RANDOM_POSITION == 3 )
        {
            PREFAB_3 = Instantiate(COLLECTIBLE_PREFAB, POS_3.transform.position, POS_3.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;

        }
        if (RANDOM_POSITION == 4 )
        {
            PREFAB_4 = Instantiate(COLLECTIBLE_PREFAB, POS_4.transform.position, POS_4.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;

        }
        if (RANDOM_POSITION == 5 )
        {
            PREFAB_5 = Instantiate(COLLECTIBLE_PREFAB, POS_5.transform.position, POS_5.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;

        }
        if (RANDOM_POSITION == 6 )
        {
            PREFAB_6 = Instantiate(COLLECTIBLE_PREFAB, POS_6.transform.position, POS_6.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;

        }
        if (RANDOM_POSITION == 7 )
        {
            PREFAB_7 = Instantiate(COLLECTIBLE_PREFAB, POS_7.transform.position, POS_7.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;

        }
        if (RANDOM_POSITION == 8 )
        {
            PREFAB_8 = Instantiate(COLLECTIBLE_PREFAB, POS_8.transform.position, POS_8.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;

        }
        if (RANDOM_POSITION == 9 )
        {
            PREFAB_9 = Instantiate(COLLECTIBLE_PREFAB, POS_9.transform.position, POS_9.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;

        }
        if (RANDOM_POSITION == 10 )
        {
            PREFAB_10 = Instantiate(COLLECTIBLE_PREFAB, POS_10.transform.position, POS_10.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;

        }
        if (RANDOM_POSITION == 11 )
        {
            PREFAB_11 = Instantiate(COLLECTIBLE_PREFAB, POS_11.transform.position, POS_11.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;

        }
        if (RANDOM_POSITION == 12 )
        {
            PREFAB_12 = Instantiate(COLLECTIBLE_PREFAB, POS_12.transform.position, POS_12.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;

        }
        if (RANDOM_POSITION == 13 )
        {
            PREFAB_13 = Instantiate(COLLECTIBLE_PREFAB, POS_13.transform.position, POS_13.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;

        }
        if (RANDOM_POSITION == 14)
        {
            PREFAB_14 = Instantiate(COLLECTIBLE_PREFAB, POS_14.transform.position, POS_14.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;

        }
        if (RANDOM_POSITION == 15 )
        {
            PREFAB_15 = Instantiate(COLLECTIBLE_PREFAB, POS_15.transform.position, POS_15.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;

        }
        if (RANDOM_POSITION == 16 )
        {
            PREFAB_16 = Instantiate(COLLECTIBLE_PREFAB, POS_16.transform.position, POS_16.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;

        }
        if (RANDOM_POSITION == 17 )
        {
            PREFAB_17 = Instantiate(COLLECTIBLE_PREFAB, POS_17.transform.position, POS_17.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;

        }
        if (RANDOM_POSITION == 18 )
        {
            PREFAB_18 = Instantiate(COLLECTIBLE_PREFAB, POS_18.transform.position, POS_18.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;

        }
        if (RANDOM_POSITION == 19 )
        {
            PREFAB_19 = Instantiate(COLLECTIBLE_PREFAB, POS_19.transform.position, POS_19.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;

        }
        if (RANDOM_POSITION == 20 )
        {
            PREFAB_20 = Instantiate(COLLECTIBLE_PREFAB, POS_20.transform.position, POS_20.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;

        }
        if (RANDOM_POSITION == 21)
        {
            PREFAB_21 = Instantiate(COLLECTIBLE_PREFAB, POS_21.transform.position, POS_21.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;

        }
        if (RANDOM_POSITION == 22 )
        {
            PREFAB_22 = Instantiate(COLLECTIBLE_PREFAB, POS_22.transform.position, POS_22.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;

        }
        if (RANDOM_POSITION == 23 )
        {
            PREFAB_23 = Instantiate(COLLECTIBLE_PREFAB, POS_23.transform.position, POS_23.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;

        }
        if (RANDOM_POSITION == 24 )
        {
            PREFAB_24 = Instantiate(COLLECTIBLE_PREFAB, POS_24.transform.position, POS_24.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;
        }
        if (RANDOM_POSITION == 25 )
        {
            PREFAB_25 = Instantiate(COLLECTIBLE_PREFAB, POS_25.transform.position, POS_25.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;
        }
        if (RANDOM_POSITION == 26)
        {
            PREFAB_26 = Instantiate(COLLECTIBLE_PREFAB, POS_26.transform.position, POS_26.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;
        }
        if (RANDOM_POSITION == 27 )
        {
            PREFAB_27 = Instantiate(COLLECTIBLE_PREFAB, POS_27.transform.position, POS_27.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;
        }
        if (RANDOM_POSITION == 28 )
        {
            PREFAB_28 = Instantiate(COLLECTIBLE_PREFAB, POS_28.transform.position, POS_28.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;
        }
        if (RANDOM_POSITION == 29 )
        {
            PREFAB_29 = Instantiate(COLLECTIBLE_PREFAB, POS_29.transform.position, POS_29.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;
        }
        if (RANDOM_POSITION == 30 )
        {
            PREFAB_30 = Instantiate(COLLECTIBLE_PREFAB, POS_30.transform.position, POS_30.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;
        }
        if (RANDOM_POSITION == 31 )
        {
            PREFAB_31 = Instantiate(COLLECTIBLE_PREFAB, POS_31.transform.position, POS_31.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;
        }
        if (RANDOM_POSITION == 32 )
        {
            PREFAB_32 = Instantiate(COLLECTIBLE_PREFAB, POS_32.transform.position, POS_32.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;
        }
        if (RANDOM_POSITION == 33)
        {
            PREFAB_33 = Instantiate(COLLECTIBLE_PREFAB, POS_33.transform.position, POS_33.transform.rotation);
            COLLECTIBLE_AMOUNT += 1;
        }

    }
}


