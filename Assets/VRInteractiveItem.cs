using UnityEngine;
using System.Collections;
using System;

public class VRInteractiveItem : MonoBehaviour {


    public event Action OnOverEvent;             // Called when the gaze moves over this object
    public event Action OnOutEvent;              // Called when the gaze leaves this object
    public event Action OnClickEvent;            // Called when click input is detected whilst the gaze is over this object.
    public event Action OnDoubleClick;      // Called when double click input is detected whilst the gaze is over this object.
    public event Action OnUp;               // Called when Fire1 is released whilst the gaze is over this object.
    public event Action OnDown;             // Called when Fire1 is pressed whilst the gaze is over this object.

    private bool m_IsOver;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void Over()
    {
        m_IsOver = true;

        if( OnOverEvent != null )
            OnOverEvent();
    }


    public void Out()
    {
        m_IsOver = false;

        if( OnOutEvent != null )
            OnOutEvent();
    }


    public void Click()
    {
        if( OnClickEvent != null )
            OnClickEvent();
    }


    public void DoubleClick()
    {
        if( OnDoubleClick != null )
            OnDoubleClick();
    }


    public void Up()
    {
        if( OnUp != null )
            OnUp();
    }


    public void Down()
    {
        if( OnDown != null )
            OnDown();
    }
}

