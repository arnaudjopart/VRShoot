using UnityEngine;
using System.Collections;
using System;

public class VRInput : MonoBehaviour {


    public event Action OnClickEvent;
    public bool m_isGazeOnAnItem;
    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if( Input.GetMouseButtonDown( 0 ) )
        {
            Click();
        }
	}
    private void Click()
    {
        if( OnClickEvent != null && m_isGazeOnAnItem)
        {
            print( "click" );
            OnClickEvent();
            
        }
    }
}
