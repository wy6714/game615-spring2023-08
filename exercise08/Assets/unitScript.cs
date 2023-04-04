using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class unitScript : MonoBehaviour
{
    // Start is called before the first frame update
    public string unitName;
    public bool selected = false;
    public GameObject TargetButton;
    public GameObject SunButton;
    public GameObject WaterButton;

    public GameManager gm;
    public Animator sunanim;
    public Animator wateranim;
    void Start()
    {
        GameObject gmObj = GameObject.Find("GameManager");
        gm = gmObj.GetComponent<GameManager>();
        GameObject TargetButton = GameObject.Find(unitName);
        TargetButton.SetActive(false);

        GameObject SunButton = GameObject.Find("SunButton");
        SunButton.SetActive(false);
        GameObject WaterButton = GameObject.Find("WaterButton");
        WaterButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // if (selected == true)
        // {
        //     TargetButton.SetActive(true);
        // }
        // else
        // {
        //     TargetButton.SetActive(false);
        // }




    }
    // private void OnMouseEnter()
    // {
    //     if (selected == false)
    //     {
    //         TargetButton.SetActive(true);
    //     }
    // }
    // private void OnMouseExit()
    // {
    //     if (selected == false)
    //     {
    //         TargetButton.SetActive(false);
    //     }

    // }

    private void OnMouseDown()
    {

        if (gm.selectedUnit != null)
        {
            gm.selectedUnit.selected = false;

            SunButton.SetActive(false);
            WaterButton.SetActive(false);
        }
        selected = true;
        TargetButton.SetActive(true);

        if (gm.selectedUnit == null)
        {
            SunButton.SetActive(false);
            WaterButton.SetActive(false);
        }

        gm.selectedUnit = this;
        //---------------------------------------------------











    }
    public void giveSun()
    {
        //play give sun animation
        sunanim.SetTrigger("giveSun");
    }

    public void giveWater()
    {
        //play give water animation
        wateranim.SetTrigger("giveWater");
    }
}
