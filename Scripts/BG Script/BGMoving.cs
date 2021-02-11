using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMoving : MonoBehaviour
{
    public float scroll_Speed = 0.1f;
    private MeshRenderer mesh_Renderer;

    
    void Awake() {
        mesh_Renderer = GetComponent<MeshRenderer>();
    }

    
    void Update()
    {
        Scroll();
    }

    void Scroll() {

        Vector2 offset = mesh_Renderer.sharedMaterial.GetTextureOffset("_MainTex");
        offset.x += Time.deltaTime * scroll_Speed;

        mesh_Renderer.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }



}
