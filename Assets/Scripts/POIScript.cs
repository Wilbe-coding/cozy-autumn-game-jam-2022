using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POIScript : MonoBehaviour
{
    public bool isVisible;
    public bool isDrawable;

    public void OnBecameVisible(){ //if it mattered, then this method would return a ray instead 
        isVisible = true;    
    }
    public void OnBecameInvisible(){ //if it mattered, then this method would return a ray instead 
        isVisible = false;  
    }
}
