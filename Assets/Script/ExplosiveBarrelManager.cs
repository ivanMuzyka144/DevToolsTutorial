using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
public class ExplosiveBarrelManager : MonoBehaviour
{
    public static List<ExplosiveBarrel> allBarrels = new List<ExplosiveBarrel>();


    #if UNITY_EDITOR
    private void OnDrawGizmos()
    {
        foreach (ExplosiveBarrel barrel in allBarrels)
        {
            Vector3 manPos = transform.position;
            Vector3 barrelPos = barrel.transform.position;
            float halfHeight = (manPos.y - barrelPos.y) * 0.5f;
            Vector3 offset = Vector3.up * halfHeight;
            Handles.DrawBezier(manPos, 
                               barrelPos, 
                               manPos - offset, 
                               barrelPos + offset, 
                               Color.white, 
                               EditorGUIUtility.whiteTexture,
                               1f);
        }
    }
    #endif
}
