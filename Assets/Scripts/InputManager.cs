using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class InputManager : MonoBehaviour
{
    private XRController controller = null;

    void Awake()
    {
        controller = GetComponent<XRController>();
    }

    // Update is called once per frame
    void Update()
    {
        
        //Quand le bouton B (Secondary button, right controller) est enfoncé, faira apparaitre ou disparaitre
        //Le menu d'objets

    }
}
