using UnityEngine;
using System.Collections;

public class LightFade : MonoBehaviour {

	void Start () 
    {
	
	}

	void Update () 
    {
        light.range = Mathf.Lerp(light.range, 0, Time.deltaTime);
	}
}
