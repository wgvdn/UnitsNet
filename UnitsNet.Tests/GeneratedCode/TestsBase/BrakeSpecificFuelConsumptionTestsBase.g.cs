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
using System.Globalization;
using System.Linq;
using System.Threading;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of BrakeSpecificFuelConsumption.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class BrakeSpecificFuelConsumptionTestsBase
    {
        protected abstract double GramsPerKiloWattHourInOneKilogramPerJoule { get; }
        protected abstract double KilogramsPerJouleInOneKilogramPerJoule { get; }
        protected abstract double PoundsPerMechanicalHorsepowerHourInOneKilogramPerJoule { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double GramsPerKiloWattHourTolerance { get { return 1e-5; } }
        protected virtual double KilogramsPerJouleTolerance { get { return 1e-5; } }
        protected virtual double PoundsPerMechanicalHorsepowerHourTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new BrakeSpecificFuelConsumption((double)0.0, BrakeSpecificFuelConsumptionUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new BrakeSpecificFuelConsumption();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(BrakeSpecificFuelConsumptionUnit.KilogramPerJoule, quantity.Unit);
        }


        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new BrakeSpecificFuelConsumption(double.PositiveInfinity, BrakeSpecificFuelConsumptionUnit.KilogramPerJoule));
            Assert.Throws<ArgumentException>(() => new BrakeSpecificFuelConsumption(double.NegativeInfinity, BrakeSpecificFuelConsumptionUnit.KilogramPerJoule));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new BrakeSpecificFuelConsumption(double.NaN, BrakeSpecificFuelConsumptionUnit.KilogramPerJoule));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new BrakeSpecificFuelConsumption(value: 1.0, unitSystem: null));
        }

        [Fact]
        public void BrakeSpecificFuelConsumption_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new BrakeSpecificFuelConsumption(1, BrakeSpecificFuelConsumptionUnit.KilogramPerJoule);

            QuantityInfo<BrakeSpecificFuelConsumptionUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(BrakeSpecificFuelConsumption.Zero, quantityInfo.Zero);
            Assert.Equal("BrakeSpecificFuelConsumption", quantityInfo.Name);
            Assert.Equal(QuantityType.BrakeSpecificFuelConsumption, quantityInfo.QuantityType);

            var units = EnumUtils.GetEnumValues<BrakeSpecificFuelConsumptionUnit>().Except(new[] {BrakeSpecificFuelConsumptionUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
#pragma warning disable 618
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
#pragma warning restore 618
        }

        [Fact]
        public void KilogramPerJouleToBrakeSpecificFuelConsumptionUnits()
        {
            BrakeSpecificFuelConsumption kilogramperjoule = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1);
            AssertEx.EqualTolerance(GramsPerKiloWattHourInOneKilogramPerJoule, kilogramperjoule.GramsPerKiloWattHour, GramsPerKiloWattHourTolerance);
            AssertEx.EqualTolerance(KilogramsPerJouleInOneKilogramPerJoule, kilogramperjoule.KilogramsPerJoule, KilogramsPerJouleTolerance);
            AssertEx.EqualTolerance(PoundsPerMechanicalHorsepowerHourInOneKilogramPerJoule, kilogramperjoule.PoundsPerMechanicalHorsepowerHour, PoundsPerMechanicalHorsepowerHourTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = BrakeSpecificFuelConsumption.From(1, BrakeSpecificFuelConsumptionUnit.GramPerKiloWattHour);
            AssertEx.EqualTolerance(1, quantity00.GramsPerKiloWattHour, GramsPerKiloWattHourTolerance);
            Assert.Equal(BrakeSpecificFuelConsumptionUnit.GramPerKiloWattHour, quantity00.Unit);

            var quantity01 = BrakeSpecificFuelConsumption.From(1, BrakeSpecificFuelConsumptionUnit.KilogramPerJoule);
            AssertEx.EqualTolerance(1, quantity01.KilogramsPerJoule, KilogramsPerJouleTolerance);
            Assert.Equal(BrakeSpecificFuelConsumptionUnit.KilogramPerJoule, quantity01.Unit);

            var quantity02 = BrakeSpecificFuelConsumption.From(1, BrakeSpecificFuelConsumptionUnit.PoundPerMechanicalHorsepowerHour);
            AssertEx.EqualTolerance(1, quantity02.PoundsPerMechanicalHorsepowerHour, PoundsPerMechanicalHorsepowerHourTolerance);
            Assert.Equal(BrakeSpecificFuelConsumptionUnit.PoundPerMechanicalHorsepowerHour, quantity02.Unit);

        }

        [Fact]
        public void FromKilogramsPerJoule_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => BrakeSpecificFuelConsumption.FromKilogramsPerJoule(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => BrakeSpecificFuelConsumption.FromKilogramsPerJoule(double.NegativeInfinity));
        }

        [Fact]
        public void FromKilogramsPerJoule_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => BrakeSpecificFuelConsumption.FromKilogramsPerJoule(double.NaN));
        }

        [Fact]
        public void As()
        {
            var kilogramperjoule = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1);
            AssertEx.EqualTolerance(GramsPerKiloWattHourInOneKilogramPerJoule, kilogramperjoule.As(BrakeSpecificFuelConsumptionUnit.GramPerKiloWattHour), GramsPerKiloWattHourTolerance);
            AssertEx.EqualTolerance(KilogramsPerJouleInOneKilogramPerJoule, kilogramperjoule.As(BrakeSpecificFuelConsumptionUnit.KilogramPerJoule), KilogramsPerJouleTolerance);
            AssertEx.EqualTolerance(PoundsPerMechanicalHorsepowerHourInOneKilogramPerJoule, kilogramperjoule.As(BrakeSpecificFuelConsumptionUnit.PoundPerMechanicalHorsepowerHour), PoundsPerMechanicalHorsepowerHourTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var kilogramperjoule = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1);

            var gramperkilowatthourQuantity = kilogramperjoule.ToUnit(BrakeSpecificFuelConsumptionUnit.GramPerKiloWattHour);
            AssertEx.EqualTolerance(GramsPerKiloWattHourInOneKilogramPerJoule, (double)gramperkilowatthourQuantity.Value, GramsPerKiloWattHourTolerance);
            Assert.Equal(BrakeSpecificFuelConsumptionUnit.GramPerKiloWattHour, gramperkilowatthourQuantity.Unit);

            var kilogramperjouleQuantity = kilogramperjoule.ToUnit(BrakeSpecificFuelConsumptionUnit.KilogramPerJoule);
            AssertEx.EqualTolerance(KilogramsPerJouleInOneKilogramPerJoule, (double)kilogramperjouleQuantity.Value, KilogramsPerJouleTolerance);
            Assert.Equal(BrakeSpecificFuelConsumptionUnit.KilogramPerJoule, kilogramperjouleQuantity.Unit);

            var poundpermechanicalhorsepowerhourQuantity = kilogramperjoule.ToUnit(BrakeSpecificFuelConsumptionUnit.PoundPerMechanicalHorsepowerHour);
            AssertEx.EqualTolerance(PoundsPerMechanicalHorsepowerHourInOneKilogramPerJoule, (double)poundpermechanicalhorsepowerhourQuantity.Value, PoundsPerMechanicalHorsepowerHourTolerance);
            Assert.Equal(BrakeSpecificFuelConsumptionUnit.PoundPerMechanicalHorsepowerHour, poundpermechanicalhorsepowerhourQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            BrakeSpecificFuelConsumption kilogramperjoule = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1);
            AssertEx.EqualTolerance(1, BrakeSpecificFuelConsumption.FromGramsPerKiloWattHour(kilogramperjoule.GramsPerKiloWattHour).KilogramsPerJoule, GramsPerKiloWattHourTolerance);
            AssertEx.EqualTolerance(1, BrakeSpecificFuelConsumption.FromKilogramsPerJoule(kilogramperjoule.KilogramsPerJoule).KilogramsPerJoule, KilogramsPerJouleTolerance);
            AssertEx.EqualTolerance(1, BrakeSpecificFuelConsumption.FromPoundsPerMechanicalHorsepowerHour(kilogramperjoule.PoundsPerMechanicalHorsepowerHour).KilogramsPerJoule, PoundsPerMechanicalHorsepowerHourTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            BrakeSpecificFuelConsumption v = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1);
            AssertEx.EqualTolerance(-1, -v.KilogramsPerJoule, KilogramsPerJouleTolerance);
            AssertEx.EqualTolerance(2, (BrakeSpecificFuelConsumption.FromKilogramsPerJoule(3)-v).KilogramsPerJoule, KilogramsPerJouleTolerance);
            AssertEx.EqualTolerance(2, (v + v).KilogramsPerJoule, KilogramsPerJouleTolerance);
            AssertEx.EqualTolerance(10, (v*10).KilogramsPerJoule, KilogramsPerJouleTolerance);
            AssertEx.EqualTolerance(10, (10*v).KilogramsPerJoule, KilogramsPerJouleTolerance);
            AssertEx.EqualTolerance(2, (BrakeSpecificFuelConsumption.FromKilogramsPerJoule(10)/5).KilogramsPerJoule, KilogramsPerJouleTolerance);
            AssertEx.EqualTolerance(2, BrakeSpecificFuelConsumption.FromKilogramsPerJoule(10)/BrakeSpecificFuelConsumption.FromKilogramsPerJoule(5), KilogramsPerJouleTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            BrakeSpecificFuelConsumption oneKilogramPerJoule = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1);
            BrakeSpecificFuelConsumption twoKilogramsPerJoule = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(2);

            Assert.True(oneKilogramPerJoule < twoKilogramsPerJoule);
            Assert.True(oneKilogramPerJoule <= twoKilogramsPerJoule);
            Assert.True(twoKilogramsPerJoule > oneKilogramPerJoule);
            Assert.True(twoKilogramsPerJoule >= oneKilogramPerJoule);

            Assert.False(oneKilogramPerJoule > twoKilogramsPerJoule);
            Assert.False(oneKilogramPerJoule >= twoKilogramsPerJoule);
            Assert.False(twoKilogramsPerJoule < oneKilogramPerJoule);
            Assert.False(twoKilogramsPerJoule <= oneKilogramPerJoule);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            BrakeSpecificFuelConsumption kilogramperjoule = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1);
            Assert.Equal(0, kilogramperjoule.CompareTo(kilogramperjoule));
            Assert.True(kilogramperjoule.CompareTo(BrakeSpecificFuelConsumption.Zero) > 0);
            Assert.True(BrakeSpecificFuelConsumption.Zero.CompareTo(kilogramperjoule) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            BrakeSpecificFuelConsumption kilogramperjoule = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1);
            Assert.Throws<ArgumentException>(() => kilogramperjoule.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            BrakeSpecificFuelConsumption kilogramperjoule = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1);
            Assert.Throws<ArgumentNullException>(() => kilogramperjoule.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1);
            var b = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(2);

 // ReSharper disable EqualExpressionComparison

            Assert.True(a == a);
            Assert.False(a != a);

            Assert.True(a != b);
            Assert.False(a == b);

            Assert.False(a == null);
            Assert.False(null == a);

// ReSharper restore EqualExpressionComparison
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            var a = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1);
            var b = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals(null));
        }

        [Fact]
        public void EqualsRelativeToleranceIsImplemented()
        {
            var v = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1);
            Assert.True(v.Equals(BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1), KilogramsPerJouleTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(BrakeSpecificFuelConsumption.Zero, KilogramsPerJouleTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            BrakeSpecificFuelConsumption kilogramperjoule = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1);
            Assert.False(kilogramperjoule.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            BrakeSpecificFuelConsumption kilogramperjoule = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1);
            Assert.False(kilogramperjoule.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(BrakeSpecificFuelConsumptionUnit.Undefined, BrakeSpecificFuelConsumption.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(BrakeSpecificFuelConsumptionUnit)).Cast<BrakeSpecificFuelConsumptionUnit>();
            foreach(var unit in units)
            {
                if(unit == BrakeSpecificFuelConsumptionUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(BrakeSpecificFuelConsumption.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 g/kWh", new BrakeSpecificFuelConsumption(1, BrakeSpecificFuelConsumptionUnit.GramPerKiloWattHour).ToString());
                Assert.Equal("1 kg/J", new BrakeSpecificFuelConsumption(1, BrakeSpecificFuelConsumptionUnit.KilogramPerJoule).ToString());
                Assert.Equal("1 lb/hph", new BrakeSpecificFuelConsumption(1, BrakeSpecificFuelConsumptionUnit.PoundPerMechanicalHorsepowerHour).ToString());
            }
            finally
            {
                Thread.CurrentThread.CurrentUICulture = prevCulture;
            }
        }

        [Fact]
        public void ToString_WithSwedishCulture_ReturnsUnitAbbreviationForEnglishCultureSinceThereAreNoMappings()
        {
            // Chose this culture, because we don't currently have any abbreviations mapped for that culture and we expect the en-US to be used as fallback.
            var swedishCulture = CultureInfo.GetCultureInfo("sv-SE");

            Assert.Equal("1 g/kWh", new BrakeSpecificFuelConsumption(1, BrakeSpecificFuelConsumptionUnit.GramPerKiloWattHour).ToString(swedishCulture));
            Assert.Equal("1 kg/J", new BrakeSpecificFuelConsumption(1, BrakeSpecificFuelConsumptionUnit.KilogramPerJoule).ToString(swedishCulture));
            Assert.Equal("1 lb/hph", new BrakeSpecificFuelConsumption(1, BrakeSpecificFuelConsumptionUnit.PoundPerMechanicalHorsepowerHour).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 kg/J", new BrakeSpecificFuelConsumption(0.123456, BrakeSpecificFuelConsumptionUnit.KilogramPerJoule).ToString("s1"));
                Assert.Equal("0.12 kg/J", new BrakeSpecificFuelConsumption(0.123456, BrakeSpecificFuelConsumptionUnit.KilogramPerJoule).ToString("s2"));
                Assert.Equal("0.123 kg/J", new BrakeSpecificFuelConsumption(0.123456, BrakeSpecificFuelConsumptionUnit.KilogramPerJoule).ToString("s3"));
                Assert.Equal("0.1235 kg/J", new BrakeSpecificFuelConsumption(0.123456, BrakeSpecificFuelConsumptionUnit.KilogramPerJoule).ToString("s4"));
            }
            finally
            {
                CultureInfo.CurrentUICulture = oldCulture;
            }
        }

        [Fact]
        public void ToString_SFormatAndCulture_FormatsNumberWithGivenDigitsAfterRadixForGivenCulture()
        {
            var culture = CultureInfo.InvariantCulture;
            Assert.Equal("0.1 kg/J", new BrakeSpecificFuelConsumption(0.123456, BrakeSpecificFuelConsumptionUnit.KilogramPerJoule).ToString("s1", culture));
            Assert.Equal("0.12 kg/J", new BrakeSpecificFuelConsumption(0.123456, BrakeSpecificFuelConsumptionUnit.KilogramPerJoule).ToString("s2", culture));
            Assert.Equal("0.123 kg/J", new BrakeSpecificFuelConsumption(0.123456, BrakeSpecificFuelConsumptionUnit.KilogramPerJoule).ToString("s3", culture));
            Assert.Equal("0.1235 kg/J", new BrakeSpecificFuelConsumption(0.123456, BrakeSpecificFuelConsumptionUnit.KilogramPerJoule).ToString("s4", culture));
        }
    }
}
