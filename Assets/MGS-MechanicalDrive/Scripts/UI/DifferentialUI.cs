﻿/*************************************************************************
 *  Copyright © 2017-2018 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  DifferentialUI.cs
 *  Description  :  Draw scene UI to control differential.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  0.1.0
 *  Date         :  6/6/2018
 *  Description  :  Initial development version.
 *************************************************************************/

using UnityEngine;

namespace Mogoson.Machinery
{
    [RequireComponent(typeof(Differential))]
    public class DifferentialUI : MonoBehaviour
    {
        #region Field and Property
        public float top = 10;
        public float left = 10;
        public string info = "Help Info.";

        private Differential differential;
        private float coefficient = 0;
        #endregion

        #region Private Method
        private void Start()
        {
            differential = GetComponent<Differential>();
        }

        private void OnGUI()
        {
            GUILayout.Space(top);
            GUILayout.BeginHorizontal();
            GUILayout.Space(left);

            GUILayout.BeginVertical();
            GUILayout.Label(info);
            var sliderValue = GUILayout.HorizontalSlider(coefficient, -2, 2, GUILayout.Width(240));
            if (coefficient != sliderValue)
            {
                coefficient = sliderValue;
                differential.Coefficient = coefficient;
            }
            GUILayout.EndVertical();

            GUILayout.EndHorizontal();
        }
        #endregion
    }
}