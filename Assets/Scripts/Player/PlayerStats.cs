using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    PlayerData playerData;
  
    [SerializeField]
    public class PlayerData
    {
        #region MainStats
        int catchingSpeed; //Can be upgrades  //Catching Speed
        public int CatchingSpeed { get => catchingSpeed; set => catchingSpeed = value; }
       
        int cargoCapacity; //Can be upgrades //Capacity
        public int CargoCapacity { get => cargoCapacity; set => cargoCapacity = value; }   
       
        int tentaclesCount; //Can be upgrades //Catching Tentacles
        public int TentaclesCount { get => tentaclesCount; set => tentaclesCount = value; }

        int tentatclesGroup; //Can be upgrades //Group Attack
        public int TentatclesGroup { get => tentatclesGroup; set => tentatclesGroup = value; }

        int alienSpeed; //Can be upgrades //Alien Speed
        public int AlienSpeed { get => alienSpeed; set => alienSpeed = value; }

        float catchingRadius; //Can be upgrades //Catching Radius
        public float CatchingRadius { get => catchingRadius; set => catchingRadius = value; }

        int maxHP; //Can be upgrades //HP
        public int MaxHP { get => maxHP; set => maxHP = value; }
        #endregion

        #region OtherStats
        int damageResistance; //
        public int DamageResistance { get => damageResistance; set => damageResistance = value; }

        int extraExp; //
        public int ExtraExp { get => extraExp; set => extraExp = value; }

        int doubleResourcesChance; //
        public int DoubleResourcesChance { get => doubleResourcesChance; set => doubleResourcesChance = value; }

        int extraSnowFlake; //
        public int ExtraSnowFlake { get => extraSnowFlake; set => extraSnowFlake = value; }

        int extraHumanCost; //
        public int ExtraHumanCost { get => extraHumanCost; set => extraHumanCost = value; }
        
        int targetSlowdown; //
        public int TargetSlowdown { get => targetSlowdown; set => targetSlowdown = value; }
        
        int healthRegen; //
        public int HealthRegen { get => healthRegen; set => healthRegen = value; }
        
        int doubleExpChance; //
        public int DoubleExpChance { get => doubleExpChance; set => doubleExpChance = value; }
       
        int extraCatchingSpeed; //for WINTER ZONE ?
        public int ExtraCatchingSpeed { get => extraCatchingSpeed; set => extraCatchingSpeed = value; }
        #endregion

        public PlayerData()
        {
            //Main stats
            CatchingSpeed = 18;
            CargoCapacity = 8;
            TentaclesCount = 1;
            TentatclesGroup = 1;
            AlienSpeed = 15;
            CatchingRadius = 15.5f;
            MaxHP = 22;

            //Other Stats
            DamageResistance = 0;
            ExtraExp = 0;
            DoubleResourcesChance = 0;
            ExtraSnowFlake = 0;
            ExtraHumanCost = 0;
            TargetSlowdown = 0;
            HealthRegen = 0;
            DoubleExpChance = 0;
            ExtraCatchingSpeed = 0;
        }
    }

    void Start()
    {
        playerData = new PlayerData();
    }

    public void UpgradeCatchingSpeed(int upgradeAmount)
    {
        playerData.CatchingSpeed = playerData.CatchingSpeed + upgradeAmount;
    }

    public void UpgradeCapacity(int upgradeAmount)
    {
        playerData.CargoCapacity = playerData.CargoCapacity + upgradeAmount;
    }

    public void UpgradeCatchingTentacles(int upgradeAmount)
    {
        playerData.TentaclesCount = playerData.TentaclesCount + upgradeAmount;
    }

    public void UpgradeGroupAttack(int upgradeAmount)
    {
        playerData.TentatclesGroup = playerData.TentatclesGroup + upgradeAmount;
    }

    public void UpgradeAlienSpeed(int upgradeAmount)
    {
        playerData.AlienSpeed = playerData.AlienSpeed + upgradeAmount;
    }

    public void UpgradeCatchingRadius(float upgradeAmount)
    {
        playerData.CatchingRadius = playerData.CatchingRadius + upgradeAmount;
    }

    public void UpgradeHP(int upgradeAmount)
    {
        playerData.MaxHP = playerData.MaxHP + upgradeAmount;
    }
}
