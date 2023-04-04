using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public unitScript selectedUnit;
    //public unitScript us;
    //public unitScript us;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray) == false)
            {
                if (selectedUnit != null)
                {
                    selectedUnit.selected = false;
                    selectedUnit = null;
                    selectedUnit.TargetButton.SetActive(false);
                }
            }
        }

    }

}
