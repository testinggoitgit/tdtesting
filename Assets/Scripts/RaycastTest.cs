using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class RaycastTest : MonoBehaviour
{
    RaycastHit hit;
    [SerializeField] private float distance = 25f;
    public LayerMask layer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RaycastingTest();
    }

    public void RaycastingTest()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        Debug.DrawRay(transform.position, ray.direction * distance, Color.red);

        if (Physics.Raycast(ray, out hit, distance, layer))
        {
            Debug.Log(hit.collider.name);
        }
    }
}
