using UnityEngine;

public class RecourcesLoad : MonoBehaviour
{
    void Start()
    {
        var model = Resources.Load<TextAsset>("glock.fbx");
        var textureNor_M = Resources.Load<Texture2D>("Glock_normal_map/Main_metall_second_normal_map4k");
        var textureSpec_M = Resources.Load<Texture2D>("Glock_normal_map/MetalSpottyDiscoloration001_NRM_4K_SPECULAR"); 
    }
}