using UnityEngine;
using System.Collections;
using System;

public class VRInput : MonoBehaviour {


    public event Action OnClickEvent;
    
    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if( Input.GetMouseButton( 0 ) )
        {
            Click();
        }
	}
    private void Click()
    {
        if( OnClickEvent != null )
        {
            print( "click" );
            OnClickEvent();
            
        }
    }
}
