using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mesh_collider : MonoBehaviour
{
    // private Collider[] object_collider_vec = gameObject.GetComponentsInChildren<Collider>();

    public void ativaMeshCollider() {
        Collider[] object_collider_vec = gameObject.GetComponentsInChildren<Collider>();

        for(var index = 0; index < object_collider_vec.Length; index++) {
            var item_collider = object_collider_vec[index];
            item_collider.enabled = true;
        }
    }

    public void desativaMeshCollider() {
        Collider[] object_collider_vec = gameObject.GetComponentsInChildren<Collider>();

        for(var index = 0; index < object_collider_vec.Length; index++) {
            var item_collider = object_collider_vec[index];
            item_collider.enabled = false;
        }
    }
}