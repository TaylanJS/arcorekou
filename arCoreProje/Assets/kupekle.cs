using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kupekle : MonoBehaviour
{
    private GameObject kup;
    private Duzlem halka;
    void Start()
    {
        halka = FindAnyObjectByType<Duzlem>();
        // kup = GameObject.CreatePrimitive(PrimitiveType.Cube);
        kup = Instantiate(Resources.Load("plant1")) as GameObject;
        kup.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);


    }

    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            GameObject go = Instantiate(kup, halka.transform.position, halka.transform.rotation);
        }
    }
}
