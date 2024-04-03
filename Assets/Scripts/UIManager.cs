using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using Unity.VisualScripting.FullSerializer;

public class UIManager : MonoBehaviour
{
    public GameObject Map;

    void Start()
    {

    }


    void Update()
    {

    }

   public void ChangeScene()
    {

    }

    public void TurnOnMap()
    {
        Map.SetActive(true);
        print("Ya entendí");
    }

    public void TurnOffMap()
    {
        Map.SetActive(false);
    }

    
}
