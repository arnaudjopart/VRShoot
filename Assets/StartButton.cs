using UnityEngine;
using System.Collections;
using System;

public class StartButton : MonoBehaviour {


    [SerializeField]    private VRInteractiveItem m_interactiveItem;
    // Use this for initialization
    void Start()
    { 

    }
	
	// Update is called once per frame
	void Update () {
	
	}
    private void OnEnable()
    {
        m_interactiveItem.OnOutEvent += HandleOutEvent;
        m_interactiveItem.OnOverEvent += HandleOver;
        m_interactiveItem.OnClickEvent += HandleClick;
    }

    private void HandleOutEvent()
    {
        Debug.Log( "Out" );
    }

    private void HandleOver()
    {
        Debug.Log( "Over" );
    }

    private void HandleClick()
    {
        print( "Click On Start Btn" );
    }
    #region Private Variables

    #endregion
}
