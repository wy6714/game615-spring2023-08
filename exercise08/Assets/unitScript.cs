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

    public GameManager gm;
    void Start()
    {
        GameObject TargetButton = GameObject.Find(unitName);
        TargetButton.setActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseEnter()
    {
        if (selected == false)
        {
            TargetButton.SetActive(true);
        }
    }
    private void OnMouseExit()
    {
        if (selected == false)
        {
            TargetButton.SetActive(false);
        }

    }

    private void OnMouseDown()
    {
        if (gm.selectedUnit != null)
        {
            gm.selectedUnit.selected = false;
            gm.selectedUnit = null;
            TargetButton.SetActive(false);
        }
        selected = true;

    }
}
