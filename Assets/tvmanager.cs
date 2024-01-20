using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tvmanager : MonoBehaviour
{
    public MeshRenderer materials;

    public Material offMaterial;
    public Material onMaterial;

    public void TvOff()
    {
        Material[] ms = new Material[2];
        ms[0] = offMaterial;
        ms[1] = offMaterial;
        materials.materials = ms;
    }

    public void TvOn()
    {
        Material[] ms = new Material[2];
        ms[0] = offMaterial;
        ms[1] = onMaterial;
        materials.materials = ms;
    }
}