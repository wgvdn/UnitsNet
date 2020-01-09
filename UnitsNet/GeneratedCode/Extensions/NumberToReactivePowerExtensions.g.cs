﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
                        
namespace UnitsNet.Extensions.NumberToReactivePower
{
    /// <summary>
    /// A number to ReactivePower Extensions
    /// </summary>
    public static class NumberToReactivePowerExtensions
    {

        #region GigavoltampereReactive

        /// <inheritdoc cref="ReactivePower.FromGigavoltamperesReactive(UnitsNet.QuantityValue)" />
        public static ReactivePower GigavoltamperesReactive<T>(this T value) =>
             ReactivePower.FromGigavoltamperesReactive(Convert.ToDouble(value));

        #endregion

        #region KilovoltampereReactive

        /// <inheritdoc cref="ReactivePower.FromKilovoltamperesReactive(UnitsNet.QuantityValue)" />
        public static ReactivePower KilovoltamperesReactive<T>(this T value) =>
             ReactivePower.FromKilovoltamperesReactive(Convert.ToDouble(value));

        #endregion

        #region MegavoltampereReactive

        /// <inheritdoc cref="ReactivePower.FromMegavoltamperesReactive(UnitsNet.QuantityValue)" />
        public static ReactivePower MegavoltamperesReactive<T>(this T value) =>
             ReactivePower.FromMegavoltamperesReactive(Convert.ToDouble(value));

        #endregion

        #region VoltampereReactive

        /// <inheritdoc cref="ReactivePower.FromVoltamperesReactive(UnitsNet.QuantityValue)" />
        public static ReactivePower VoltamperesReactive<T>(this T value) =>
             ReactivePower.FromVoltamperesReactive(Convert.ToDouble(value));

        #endregion

    }
}
