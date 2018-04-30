using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour
{
    public static int sizeRatio =3;
    //3:p2 big, p1 small
    //2:p2 small, p1 big
    public static int totalCount = 0;
    public hiddenP1Script hiddenP1Script;
    public hiddenP2Script hiddenP2Script;
    public GameObject POWER1;
    public GameObject POWER2;
    public GameObject POWER3;
    public GameObject BlockToBeHide;
    public GameObject BlockToBeHide2;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!POWER1.activeSelf&&!POWER2.activeSelf && !POWER3.activeSelf)
        {
            BlockToBeHide.SetActive(false);
            BlockToBeHide2.SetActive(false);
        }

        totalCount = hiddenP1Script.getCount()+ hiddenP2Script.getCount();
        Debug.Log("total_count: " + totalCount);
    }
}
