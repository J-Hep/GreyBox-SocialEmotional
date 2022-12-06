using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLose : MonoBehaviour
{

    public GameObject[] NPC;
    public GameObject fireHolder;
    public bool hasAllNpcs, clearedAllFire, escaped = false;

    public GameObject panel, fireWin, fireNPCwin, NPCWin, lose, nice, intro, winPlate;
    

    // Update is called once per frame
    void Update()
    {

        if (!NPC[0].activeInHierarchy && !NPC[1].activeInHierarchy && !NPC[2].activeInHierarchy && !hasAllNpcs )
        {
            Debug.Log("All NPCs Saved");
            hasAllNpcs = true;
        }

        if(fireHolder.transform.childCount <= 1 && !clearedAllFire)
        {
            Debug.Log("All Fire Cleared");
            clearedAllFire = true;
        }

        if(intro.activeInHierarchy == true && Input.GetKeyDown(KeyCode.E))
        {

            intro.SetActive(false);

            panel.SetActive(false);

        }

        if (winPlate.transform.GetChild(0).gameObject.activeInHierarchy == false && !escaped)
        {
            Debug.Log("Escaped");

            panel.SetActive(true);

            //Both
            if(hasAllNpcs && clearedAllFire)
            {
                fireNPCwin.SetActive(true);
                nice.SetActive(true);
            }

            //Npc win
            if (hasAllNpcs && !clearedAllFire)
            {
                NPCWin.SetActive(true);
                nice.SetActive(true);
            }

            //Fire win
            if (clearedAllFire && !hasAllNpcs)
            {

                fireWin.SetActive(true);
                nice.SetActive(true);
            }

            //Loss
            if (!hasAllNpcs && !clearedAllFire)
            {
                lose.SetActive(true);
            }






        }




    }
}
