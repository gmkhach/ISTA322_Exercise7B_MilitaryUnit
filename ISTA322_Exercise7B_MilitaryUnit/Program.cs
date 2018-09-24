using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponSystems.Vehicles;
using WeaponSystems;

namespace ISTA322_Exercise7B_MilitaryUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            Tank myTank = new Tank();
            myTank.Move();

            Personnel myTroops = new Personnel();
            myTroops.FallIn();
            myTroops = new ChainOfCommand();
            myTroops.FallIn();
            myTroops = new Troops();
            myTroops.FallIn();
            Vehicle myFleet = new Vehicle();
            myFleet.StageVehicles();
            myFleet = new WheeledVehicle();
            myFleet.StageVehicles();
            myFleet = new TrackedVehicle();
            myFleet.StageVehicles();
            myFleet = new FixedWingAircraft();
            myFleet.StageVehicles();
            myFleet = new RotaryWingAircraft();
            myFleet.StageVehicles();
            Weapon myArsenal = new Weapon();
            myArsenal.Fire();
            myArsenal = new SmallCaliberWeapon();
            myArsenal.Fire();
            myArsenal = new CrewServedWeapon();
            myArsenal.Fire();
            Mission myMission = new Mission();
            myMission.Execute();
            myMission = new Rescue();
            myMission.Execute();
            myMission = new Assault();
            myMission.Execute();
            myMission = new ReconMission();
            myMission.Execute();
        }
    }
}
