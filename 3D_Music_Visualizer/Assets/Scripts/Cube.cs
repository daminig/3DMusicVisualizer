using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {
    public int band;
    public float startScale;
    public float scaleMultiplier;
    // Use this for initialization
    void Start () {
		for (int i = 0; i < 8; i++)
        {
            
        }
	}
	
	// Update is called once per frame
	void Update () {
        for (int i = 0; i < 8; i++)
        {
            
            transform.localScale = new Vector3(1.0f, (startScale + SpectrumAnalyzer.audioBands[band - 1] * scaleMultiplier), 1.0f);


            
        }
    }
}
