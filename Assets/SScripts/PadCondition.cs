using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadCondition : MonoBehaviour
{
    public List<Material> materials; // List of materials to switch between
    public int currentIndex = 0; // Current index of the active material
    public bool yes;
    private void OnTriggerEnter(Collider other)
    {
        if (materials != null && materials.Count > 0)
        {
            // Disable the current material
            Renderer renderer = GetComponent<Renderer>();
            renderer.material = null;
            currentIndex = 1;

            // Assign the new material to the renderer
            renderer.material = materials[currentIndex];
        }
    }
    void Update()
    {
        
    }
   
}