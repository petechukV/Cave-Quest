using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextLvl : MonoBehaviour {

    public int nextlvl;
   
   void OnTriggerEnter(Collider col)
    {
      
        if (col.tag == "Player")
        {
            SceneManager.LoadScene(nextlvl);
        }
    }

}
