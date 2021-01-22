using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closs : MonoBehaviour
{
    public GameObject layout;

    public void Close()
    {
        layout.gameObject.SetActive(false);
    }
}
