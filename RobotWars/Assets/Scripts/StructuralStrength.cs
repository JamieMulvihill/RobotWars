using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StructuralStrength : MonoBehaviour
{
    [SerializeField] private int maxHealth;
    [SerializeField] private int currentHealth;
    [SerializeField] private int maxHull;
    [SerializeField] private int currentHull;
    [SerializeField] private int maxElectrics;
    [SerializeField] private int currentElectrics;
    [SerializeField] private int maxWeapon;
    [SerializeField] private int currentWeapon;
    [SerializeField] private int maxEngine;
    [SerializeField] private int currentEngine;

    // Start is called before the first frame update
    void Start()
    {
        maxHealth = (maxHull + maxElectrics + maxWeapon + maxEngine) /4;
        currentHealth = (maxHull + maxElectrics + maxWeapon + maxEngine) / 4;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
