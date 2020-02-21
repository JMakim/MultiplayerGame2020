using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public bool active = true;

    public GameObject Cross;
    public GameObject Circle;

    public int Check;
    // Start is called before the first frame update
    void Start()
    {
        GetObjects();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (GetComponentInParent<Game>().activeGame == true)
            {


                if (active == true)
                {
                    if (GetComponentInParent<Game>().Player1 == true)
                    {
                        Cross.SetActive(true);
                        GetComponentInParent<Game>().Player1 = false;
                        GetComponentInParent<Game>().Player2 = true;
                        Check = 1;
                    }
                    else
                    {
                        Circle.SetActive(true);
                        GetComponentInParent<Game>().Player1 = true;
                        GetComponentInParent<Game>().Player2 = false;
                        Check = 2;
                    }

                    active = false;
                }
            }
        }
    }

    void GetObjects()
    {
        Cross = this.transform.Find("Cross").gameObject;
        Circle = this.transform.Find("Circle").gameObject;
    }
}
