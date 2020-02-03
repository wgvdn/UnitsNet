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
//     Add CustomCode\UnitClasses\MyQuantity.extra.cs files to add code to generated unit classes.
//     Add UnitDefinitions\MyQuantity.json and run GeneratUnits.bat to generate new units or unit classes.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using Xunit;

namespace UnitsNet.Tests.CustomCode
{
    public class ForcePerLengthTests : ForcePerLengthTestsBase
    {
        protected override double CentinewtonsPerMeterInOneNewtonPerMeter => 1E2;
        protected override double DecinewtonsPerMeterInOneNewtonPerMeter => 1E1;
        protected override double KilogramsForcePerMeterInOneNewtonPerMeter => 0.101972;
        protected override double KilonewtonsPerMeterInOneNewtonPerMeter => 1E-3;
        protected override double MicronewtonsPerMeterInOneNewtonPerMeter => 1E6;
        protected override double MillinewtonsPerMeterInOneNewtonPerMeter => 1E3;
        protected override double NanonewtonsPerMeterInOneNewtonPerMeter => 1E9;
        protected override double NewtonsPerMeterInOneNewtonPerMeter => 1;
        protected override double NewtonsPerMillimeterInOneNewtonPerMeter => 1E-3;
        protected override double PoundsForcePerFootInOneNewtonPerMeter => 6.8521766E-2;
        protected override double PoundsForcePerInchInOneNewtonPerMeter => 5.710147162769201E-3;
        protected override double PoundsForcePerYardInOneNewtonPerMeter => 0.205565298;
        protected override double MeganewtonsPerMeterInOneNewtonPerMeter => 1E-6;

        [Fact]
        public void ForcePerLengthDividedByLengthEqualsPressure()
        {
            Pressure pressure = ForcePerLength.FromNewtonsPerMeter(90) / Length.FromMeters(9);
            Assert.Equal(pressure, Pressure.FromNewtonsPerSquareMeter(10));
        }

        [Fact]
        public void ForceDividedByForcePerLengthEqualsLength()
        {
            Length length = Force.FromNewtons(10) / ForcePerLength.FromNewtonsPerMeter(2);
            Assert.Equal(length, Length.FromMeters(5));
        }

        [Fact]
        public void ForcePerLenghTimesLengthEqualForce()
        {
            Force force = ForcePerLength.FromNewtonsPerMeter(10) * Length.FromMeters(9);
            Assert.Equal(force, Force.FromNewtons(90));
        }
    }
}
