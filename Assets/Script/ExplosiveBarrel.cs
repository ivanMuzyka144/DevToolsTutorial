using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;

[ExecuteAlways]
public class ExplosiveBarrel : MonoBehaviour
{
    [Range(1f,8f)]
    public float radius = 1;
    public float damage = 10;
    public Color color = Color.red;


    private void OnEnable() => ExplosiveBarrelManager.allBarrels.Add(this);
    private void OnDisable() => ExplosiveBarrelManager.allBarrels.Remove(this);
    
    private void OnDrawGizmosSelected()
    {
        //Gizmos.DrawWireSphere(transform.position, radius);

        Gizmos.color = new Color(color.r, color.g, color.b, 0.1f);
        Gizmos.DrawSphere(transform.position, radius);
    }

}
