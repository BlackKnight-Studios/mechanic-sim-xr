using System;
using UnityEngine;

namespace OmegaGaze.MechanicSim
{
    public class TorqueFastener : MonoBehaviour
    {
        public float TargetTorqueNm = 75f;
        public float CurrentTorqueNm { get; private set; }
        public bool IsTorqued => Mathf.Abs(CurrentTorqueNm - TargetTorqueNm) <= ToleranceNm;
        public float ToleranceNm = 2.5f;

        public void ApplyTorque(float deltaNm)
        {
            CurrentTorqueNm += deltaNm;
        }
    }
}
