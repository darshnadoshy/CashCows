using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class URLOpener : MonoBehaviour
{
    public string Url1; 
    public string Url2; 

    public void Open(int val)
    {
    	if (val == 1) { 
    		Application.OpenURL(Url1); 
    	}
    	if (val == 2) { 
    		Application.OpenURL(Url2); 
    	}
    }
}
