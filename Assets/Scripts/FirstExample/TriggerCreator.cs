using System;
using System.Collections;
using System.Collections.Generic;
using Dreamteck.Splines;
using UnityEngine;

public class TriggerCreator : MonoBehaviour
{
    private SplineComputer _spline;

    private void Start()
    {
        _spline = GetComponent<SplineComputer>();
        TriggerGroup triggerGroup = _spline.triggerGroups[0];
        SplineTrigger trigger = new SplineTrigger(SplineTrigger.Type.Double);
        trigger.name = "NewTrigger";
        trigger.onCross.AddListener(OnTriggerCrossed);
        triggerGroup.triggers = new SplineTrigger[] {trigger };
    }

    private void OnTriggerCrossed(SplineUser arg0)
    {
        Debug.Log("Triggered");
    }
}
