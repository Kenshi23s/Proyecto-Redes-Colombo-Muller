using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DroneInput
{
    DroneShooting droneShoot;
    Drone_Movement dronemovement;
    protected Camera cam;
    IModel myModel;

    protected DroneInput(DroneShooting droneShoot, Drone_Movement dronemovement, Camera cam)
    {
        this.droneShoot = droneShoot;
        this.dronemovement = dronemovement;
        this.cam = cam;
    }

    protected abstract bool ShootInput(out Ray ray);
    protected abstract bool MovementInput(out NodeDirection direction);
    public abstract void InputGizmos();

    public void SetModel(IModel model) => myModel = model;
    
    public void ListenInputs()
    {
        //Ray ray;
        //if (ShootInput(out ray))
        //{
        //    droneShoot.Shoot(ray);
        //}

        NodeDirection direction;
        if (MovementInput(out direction))
        {
            dronemovement.SetDirection(direction);
        }
    }

    public void PlayPhysicsInputs()   {  }
  
}
