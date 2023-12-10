using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleOutline : MonoBehaviour
{
    Outline outline;

    private void Start()
    {
        outline = GetComponent<Outline>();
    }

    public void ToggleOutlineVisualizer()
    {
        if(outline.enabled)
        {
            outline.enabled = false;
        }
        else
        {
            outline.enabled = true;
        }
    }
}
