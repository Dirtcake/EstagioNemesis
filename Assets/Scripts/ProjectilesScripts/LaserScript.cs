﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class LaserScript : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> lasers = new List<GameObject>();
    public BarsManager barsManager;

    void Start()
    {
        for (int i = 0; i < lasers.Count; i++)
        {
            lasers[i].transform.DOScaleY(40, .8f);
            lasers[i].GetComponent<CheckLaserCollision>().barsManager = barsManager;
            lasers[1].transform.DORotate(new Vector3(Random.Range(-30,30), 0 , Random.Range(-30, 30)), .5f);
            lasers[2].transform.DORotate(new Vector3(Random.Range(-30, 30), 0, Random.Range(-30, 30)), .5f);

        }

        Destroy(gameObject, 1f);
    }

}
