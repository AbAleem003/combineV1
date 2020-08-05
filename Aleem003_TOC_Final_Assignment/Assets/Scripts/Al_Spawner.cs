using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Al_Spawner : MonoBehaviour
{
    public GameObject POS_1, POS_2, POS_3, POS_4, POS_5, POS_6, POS_7, POS_8, POS_9, POS_10, POS_11, POS_12, POS_13, POS_14, POS_15, POS_16, POS_17, POS_18, POS_19, POS_20;
    public int CUBE_AMOUNT = 0, RANDOM_POSITION;
    public bool SPACE_CHECKER_1 = true, SPACE_CHECKER_2 = true, SPACE_CHECKER_3 = true, SPACE_CHECKER_4 = true, SPACE_CHECKER_5 = true, SPACE_CHECKER_6 = true, SPACE_CHECKER_7 = true,
                SPACE_CHECKER_8 = true, SPACE_CHECKER_9 = true, SPACE_CHECKER_10 = true, SPACE_CHECKER_11 = true, SPACE_CHECKER_12 = true, SPACE_CHECKER_13 = true,
                SPACE_CHECKER_14 = true, SPACE_CHECKER_15 = true, SPACE_CHECKER_16 = true, SPACE_CHECKER_17 = true, SPACE_CHECKER_18 = true, SPACE_CHECKER_19 = true,
                SPACE_CHECKER_20 = true;
    public GameObject CUBE_PREFAB, PREFAB_1, PREFAB_2, PREFAB_3, PREFAB_4, PREFAB_5, PREFAB_6, PREFAB_7, PREFAB_8, PREFAB_9, PREFAB_10, PREFAB_11, PREFAB_12, PREFAB_13, PREFAB_14, PREFAB_15,
                      PREFAB_16, PREFAB_17, PREFAB_18, PREFAB_19, PREFAB_20;
    void Start()
    {
        COLLECTIBLE_GENERATOR();
    }
    void COLLECTIBLE_GENERATOR()
    {
        InvokeRepeating("INSTANTIATE_PREFABS", 0.1f, 0.3f);
    }
    void INSTANTIATE_PREFABS()
    {
        if (CUBE_AMOUNT < 10)
        {
            RANDOM_POSITION = Random.Range(1, 21);
            if (RANDOM_POSITION == 1 && SPACE_CHECKER_1 == true)
            {
                PREFAB_1 = Instantiate(CUBE_PREFAB, POS_1.transform.position, POS_1.transform.rotation);
                CUBE_AMOUNT += 1;
                SPACE_CHECKER_1 = false;
            }
            else if (RANDOM_POSITION == 2 && SPACE_CHECKER_2 == true)
            {
                PREFAB_2 = Instantiate(CUBE_PREFAB, POS_2.transform.position, POS_2.transform.rotation);
                CUBE_AMOUNT += 1;
                SPACE_CHECKER_2 = false;
            }
            else if (RANDOM_POSITION == 3 && SPACE_CHECKER_3 == true)
            {
                PREFAB_3 = Instantiate(CUBE_PREFAB, POS_3.transform.position, POS_3.transform.rotation);
                CUBE_AMOUNT += 1;
                SPACE_CHECKER_3 = false;
            }
            else if (RANDOM_POSITION == 4 && SPACE_CHECKER_4 == true)
            {
                PREFAB_4 = Instantiate(CUBE_PREFAB, POS_4.transform.position, POS_4.transform.rotation);
                CUBE_AMOUNT += 1;
                SPACE_CHECKER_4 = false;
            }
            else if (RANDOM_POSITION == 5 && SPACE_CHECKER_5 == true)
            {
                PREFAB_5 = Instantiate(CUBE_PREFAB, POS_5.transform.position, POS_5.transform.rotation);
                CUBE_AMOUNT += 1;
                SPACE_CHECKER_5 = false;
            }
            else if (RANDOM_POSITION == 6 && SPACE_CHECKER_6 == true)
            {
                PREFAB_6 = Instantiate(CUBE_PREFAB, POS_6.transform.position, POS_6.transform.rotation);
                CUBE_AMOUNT += 1;
                SPACE_CHECKER_6 = false;
            }
            else if (RANDOM_POSITION == 7 && SPACE_CHECKER_7 == true)
            {
                PREFAB_7 = Instantiate(CUBE_PREFAB, POS_7.transform.position, POS_7.transform.rotation);
                CUBE_AMOUNT += 1;
                SPACE_CHECKER_7 = false;
            }
            else if (RANDOM_POSITION == 8 && SPACE_CHECKER_8 == true)
            {
                PREFAB_8 = Instantiate(CUBE_PREFAB, POS_8.transform.position, POS_8.transform.rotation);
                CUBE_AMOUNT += 1;
                SPACE_CHECKER_8 = false;
            }
            else if (RANDOM_POSITION == 9 && SPACE_CHECKER_9 == true)
            {
                PREFAB_9 = Instantiate(CUBE_PREFAB, POS_9.transform.position, POS_9.transform.rotation);
                CUBE_AMOUNT += 1;
                SPACE_CHECKER_9 = false;
            }
            else if (RANDOM_POSITION == 10 && SPACE_CHECKER_10 == true)
            {
                PREFAB_10 = Instantiate(CUBE_PREFAB, POS_10.transform.position, POS_10.transform.rotation);
                CUBE_AMOUNT += 1;
                SPACE_CHECKER_10 = false;
            }
            else if (RANDOM_POSITION == 11 && SPACE_CHECKER_11 == true)
            {
                PREFAB_11 = Instantiate(CUBE_PREFAB, POS_11.transform.position, POS_11.transform.rotation);
                CUBE_AMOUNT += 1;
                SPACE_CHECKER_11 = false;
            }
            else if (RANDOM_POSITION == 12 && SPACE_CHECKER_12 == true)
            {
                PREFAB_12 = Instantiate(CUBE_PREFAB, POS_12.transform.position, POS_12.transform.rotation);
                CUBE_AMOUNT += 1;
                SPACE_CHECKER_12 = false;
            }
            else if (RANDOM_POSITION == 13 && SPACE_CHECKER_13 == true)
            {
                PREFAB_13 = Instantiate(CUBE_PREFAB, POS_13.transform.position, POS_13.transform.rotation);
                CUBE_AMOUNT += 1;
                SPACE_CHECKER_13 = false;
            }
            else if (RANDOM_POSITION == 14 && SPACE_CHECKER_14 == true)
            {
                PREFAB_14 = Instantiate(CUBE_PREFAB, POS_14.transform.position, POS_14.transform.rotation);
                CUBE_AMOUNT += 1;
                SPACE_CHECKER_14 = false;
            }
            else if (RANDOM_POSITION == 15 && SPACE_CHECKER_15 == true)
            {
                PREFAB_15 = Instantiate(CUBE_PREFAB, POS_15.transform.position, POS_15.transform.rotation);
                CUBE_AMOUNT += 1;
                SPACE_CHECKER_15 = false;
            }
            else if (RANDOM_POSITION == 16 && SPACE_CHECKER_16 == true)
            {
                PREFAB_16 = Instantiate(CUBE_PREFAB, POS_16.transform.position, POS_16.transform.rotation);
                CUBE_AMOUNT += 1;
                SPACE_CHECKER_16 = false;
            }
            else if (RANDOM_POSITION == 17 && SPACE_CHECKER_17 == true)
            {
                PREFAB_17 = Instantiate(CUBE_PREFAB, POS_17.transform.position, POS_17.transform.rotation);
                CUBE_AMOUNT += 1;
                SPACE_CHECKER_17 = false;
            }
            else if (RANDOM_POSITION == 18 && SPACE_CHECKER_18 == true)
            {
                PREFAB_18 = Instantiate(CUBE_PREFAB, POS_18.transform.position, POS_18.transform.rotation);
                CUBE_AMOUNT += 1;
                SPACE_CHECKER_18 = false;
            }
            else if (RANDOM_POSITION == 19 && SPACE_CHECKER_19 == true)
            {
                PREFAB_19 = Instantiate(CUBE_PREFAB, POS_19.transform.position, POS_19.transform.rotation);
                CUBE_AMOUNT += 1;
                SPACE_CHECKER_19 = false;
            }
            else if (RANDOM_POSITION == 20 && SPACE_CHECKER_20 == true)
            {
                PREFAB_20 = Instantiate(CUBE_PREFAB, POS_20.transform.position, POS_20.transform.rotation);
                CUBE_AMOUNT += 1;
                SPACE_CHECKER_20 = false;
            }
        }
    }
}
