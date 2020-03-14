using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Photon : MonoBehaviour
{
    public GameObject photon;
    public Vector3 localOffSet = new Vector3(0, 0, 0);

    void Update()
    {
        GetMouseClickDown();
       
    }

    void GetMouseClickDown ()
    {

       
        if (Input.GetMouseButtonDown(button: 0))
        {
            SpawnPhoton();
        }
    }

    void SpawnPhoton()
    {
        GameObject photonClone;
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); // mouse position
        photonClone = Instantiate(photon, transform.TransformPoint(Vector3.left + localOffSet), Quaternion.Euler(0,0, transform.eulerAngles.z)) as GameObject;

        Rigidbody2D projectileRigidBody = photonClone.AddComponent<Rigidbody2D>();
        projectileRigidBody.velocity = mousePos * 2.0f;
        projectileRigidBody.gravityScale = 0f;

    }


}
