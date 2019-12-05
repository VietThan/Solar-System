﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbiter : MonoBehaviour
{
    public double OrbitTime = 365; // in seconds
    public Vector3 OrbitAxis = Vector3.up;
    public double X; // pos
    public double Y; // pos
    public double Z; // pos
    public Vector3d mPosition;
    public Vector3d mScaledPosition;

    // Start is called before the first frame update
    void Start()
    {
        mPosition = new Vector3d(X, Y, Z);
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(gameObject.name + ": " + mPosition);
    }

    void FixedUpdate()
    {
        Debug.Log(gameObject.name + ": " +  mScaledPosition.ToString() + " ; " + Vector3d.Magnitude(mScaledPosition));
        if (Vector3d.Magnitude(mScaledPosition) < 100000)
        {
            // Show planet in from of us
            // find some way to lock on & leave
            transform.position = new Vector3((float) mScaledPosition.x, (float) mScaledPosition.y,(float) mScaledPosition.z);
            MeshRenderer mesh = gameObject.GetComponent<MeshRenderer>();
            if (mesh != null)
            {
                mesh.enabled = true;
            }
            else
            {
                gameObject.transform.GetChild(0).GetComponent<MeshRenderer>().enabled = true;
            }
        }
        else
        {
            transform.position = new Vector3(0f, -100f, 0);
            MeshRenderer mesh = gameObject.GetComponent<MeshRenderer>();
            if (mesh != null)
            {
                mesh.enabled = false;
            }
            else
            {
                gameObject.transform.GetChild(0).GetComponent<MeshRenderer>().enabled = false;
            }
        }
    }
}
