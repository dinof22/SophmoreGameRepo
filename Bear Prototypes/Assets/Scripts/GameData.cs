using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour {


    public int templeDoubleButtonsPressed = 0;


    private void Start()
    {
        PublicVariables.templeDoubleButtonsPressed = templeDoubleButtonsPressed;
    }
}
