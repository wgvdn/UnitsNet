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
                        
namespace UnitsNet.Extensions.NumberToSpecificVolume
{
    /// <summary>
    /// A number to SpecificVolume Extensions
    /// </summary>
    public static class NumberToSpecificVolumeExtensions
    {

        #region CubicFootPerPound

        /// <inheritdoc cref="SpecificVolume.FromCubicFeetPerPound(UnitsNet.QuantityValue)" />
        public static SpecificVolume CubicFeetPerPound<T>(this T value) =>
             SpecificVolume.FromCubicFeetPerPound(Convert.ToDouble(value));

        #endregion

        #region CubicMeterPerKilogram

        /// <inheritdoc cref="SpecificVolume.FromCubicMetersPerKilogram(UnitsNet.QuantityValue)" />
        public static SpecificVolume CubicMetersPerKilogram<T>(this T value) =>
             SpecificVolume.FromCubicMetersPerKilogram(Convert.ToDouble(value));

        #endregion

        #region MillicubicMeterPerKilogram

        /// <inheritdoc cref="SpecificVolume.FromMillicubicMetersPerKilogram(UnitsNet.QuantityValue)" />
        public static SpecificVolume MillicubicMetersPerKilogram<T>(this T value) =>
             SpecificVolume.FromMillicubicMetersPerKilogram(Convert.ToDouble(value));

        #endregion

    }
}
