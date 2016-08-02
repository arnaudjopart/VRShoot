using UnityEngine;
using System.Collections;

public class VREyeTracker : MonoBehaviour {

    public LayerMask m_layerMask;
    public VRInput m_vrInput;

    // Use this for initialization
	void Start () {
        m_transform = transform;
	}

    void OnEnable()
    {
        m_vrInput.OnClickEvent += HandleClick;
    }
	
	// Update is called once per frame
	void Update () {
        Debug.DrawRay( m_transform.position, m_transform.position + m_transform.forward * 30 );
        Ray eyeTracker = new Ray(m_transform.position,m_transform.forward);

        if(Physics.Raycast(eyeTracker, out m_hit, 30, m_layerMask ) )
        {
            VRInteractiveItem item = m_hit.collider.GetComponent<VRInteractiveItem>();
            m_vrInput.m_isGazeOnAnItem = true;
            m_currentInteractiveItem = item;

            if(item && item != m_lastInteractiveItem )
            {
                item.Over();
            }

            if(item != m_lastInteractiveItem )
            {
                DesactivateLastItem();
            }
            m_lastInteractiveItem = item;

        }else
        {
            DesactivateLastItem();
            m_vrInput.m_isGazeOnAnItem = false;
            m_currentInteractiveItem = null;
        }
	}

    private void DesactivateLastItem()
    {
        if( m_lastInteractiveItem == null )
        {
            return;
        }
        m_lastInteractiveItem.Out();
        m_lastInteractiveItem = null;
    }

    private void HandleClick()
    {
        m_vrInput.OnClickEvent += m_currentInteractiveItem.Click;
    }
    private RaycastHit m_hit;
    private Transform m_transform;
    private VRInteractiveItem m_currentInteractiveItem;
    private VRInteractiveItem m_lastInteractiveItem;
}
