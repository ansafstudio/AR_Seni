using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MateriMgr : MonoBehaviour {
    public GameObject[] materi;
    int index = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        for (int i = 0; i < materi.Length; i++)
        {
            if (index == i)
            {
                materi[i].SetActive(true);
            }
            else
            {
                materi[i].SetActive(false);
            }
        }
	}

    public void Next()
    {
        index = index + 1;
        if (index == materi.Length)
        {
            index = 0;
        }
    }

    public void Prev()
    {
        if (index == 0)
        {
            index = materi.Length;
        }
        index = index - 1;
    }
}
