using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdManager : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (Advertisement.IsReady("video"))
            {
                Advertisement.Show("video");
            }
        }

       /* if (Input.GetKeyDown(KeyCode.R))
        {
            if (Advertisement.IsReady("rewardedvideo"))
            {
                Advertisement.Show("rewardedvideo");
            }
        }*/
    }
}
