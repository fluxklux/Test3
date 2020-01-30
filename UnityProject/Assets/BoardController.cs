using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        callout();
    }

    void callout()
    {
        Debug.Log("Loggar från callout-funktion i BoarController");
    }
}
