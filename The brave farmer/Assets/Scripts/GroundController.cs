using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GroundController : MonoBehaviour
{
    [SerializeField]  Plant sunflower;
    [SerializeField]  Plant tomatoes;
    [SerializeField]  Plant paprika;
    [SerializeField]  Plant pumpkin;
    [SerializeField]  Plant cucumber;

    [SerializeField] Text water;
    [SerializeField] Text description;
    public int WaterCounter;
    private int StartWater;


    [Space]
    [SerializeField] Sprite sprite1;
    [SerializeField] Sprite sprite2;
    [Space]

    Plant selectedPlant;
    [SerializeField] GameObject waterParticle;


    private void Start()
    {
        StartWater = WaterCounter;
        UpdateCounter();
        Select(sunflower);

    }

    private void UpdateCounter()
    {
        water.text = WaterCounter.ToString();
    }

    public void SubtractWater()
    {
        WaterCounter--;
        UpdateCounter();
    }

    public void AddWater()
    {
        WaterCounter++;
        UpdateCounter();
    }

    public void ResetWater()
    {
        WaterCounter = StartWater;
        UpdateCounter();
    }

    private void Select(Plant plant)
    {
        if(selectedPlant != null)
        {
            selectedPlant.image.sprite = sprite1;
        }
        selectedPlant = plant;
        description.text = plant.description;
        selectedPlant.image.sprite = sprite2;
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            Select(sunflower);
        }
        else if (Input.GetKey(KeyCode.Alpha2))
        {
            Select(pumpkin);
        }
        else if (Input.GetKey(KeyCode.Alpha3))
        {
            Select(tomatoes);
        }else if (Input.GetKey(KeyCode.Alpha4))
        {
            Select(paprika);
        }else if (Input.GetKey(KeyCode.Alpha5))
        {
            Select(cucumber);
        }
    }


    public Plant GetSeeds()
    {
        return selectedPlant;
    }
    
    public GameObject GetWaterParticle()
    {
        return waterParticle;
    }




}
