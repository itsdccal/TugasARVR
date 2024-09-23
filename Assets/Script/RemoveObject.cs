using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveObject : MonoBehaviour
{
    public int jarakRaycast = 20;
    private RaycastHit raycastHit;

    void Start()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }

    void Update()
    {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
        if (Physics.Raycast(ray, out raycastHit, jarakRaycast))
        {
            if (raycastHit.transform.CompareTag("Benda"))
            {
                Destroy(raycastHit.transform.gameObject);
            }
        }
    }
}
