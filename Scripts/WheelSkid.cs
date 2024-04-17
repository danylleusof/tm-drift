using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelSkid : MonoBehaviour
{

    [SerializeField] float intensityModifier = 1.5f;

    Skidmarks skidmarkController;
    PlayerCar playerCar;
    ParticleSystem particleSystem;

    int lastSkidID = -1;

    // Start is called before the first frame update
    void Start()
    {
        skidmarkController = FindObjectOfType<Skidmarks>();
        playerCar = GetComponentInParent<PlayerCar>();
        particleSystem = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        float intensity = playerCar.SideSlipAmount;
        if (intensity < 0)
            intensity = -intensity;

        if (intensity > 0.2f)
        {
            // Show skids
            lastSkidID = skidmarkController.AddSkidMark(transform.position, transform.up, intensity * intensityModifier, lastSkidID);
            if (particleSystem != null && !particleSystem.isPlaying)
                particleSystem.Play();
        }

        else
        {
            // Stop skids
            lastSkidID = -1;
            if (particleSystem != null && particleSystem.isPlaying)
                particleSystem.Stop();
        }
        
    }
}
