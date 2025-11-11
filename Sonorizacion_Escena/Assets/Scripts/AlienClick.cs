using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienClick : MonoBehaviour
{
    // El collider del objeto (está desactivado al inicio)
    private Collider _col;

    private void Awake()
    {
        // Obtiene el collider, lo guarda
        _col = GetComponent<Collider>();

        // Desactiva el collider para evitar clicks prematuros
        _col.enabled = false;
    }

    // Esta función será llamada por el padre cuando ocurra la colisión
    public void EnableClicks()
    {
        // Activa el collider para que ahora sí detecte clicks
        _col.enabled = true;
    }

    private void OnMouseDown()
    {
        // Esto se ejecuta solo si el collider ya fue activado
        Debug.Log("Click recibido correctamente!");
    }
}
