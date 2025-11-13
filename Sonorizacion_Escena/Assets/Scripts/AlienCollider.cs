using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AlienCollider : MonoBehaviour
{
    private Collider _col;

    private AlienClick _alien;

    private float _delayTime = 16f;
    void Start()
    {
        _col = GetComponent<Collider>();

        _alien = transform.Find("Alien10").GetComponent<AlienClick>();
    }


    private void OnTriggerExit(Collider other)
    {
        _col.enabled = false;

        // Inicia el timer que habilita el click del hijo
        StartCoroutine(TimerEnableClicks());
    }

    private IEnumerator TimerEnableClicks()
    {
        // Espera la cantidad de segundos indicada
        yield return new WaitForSeconds(_delayTime);

        // Luego de esperar, avisa al hijo que puede procesar clicks
        _alien.EnableClicks();
    }

}
