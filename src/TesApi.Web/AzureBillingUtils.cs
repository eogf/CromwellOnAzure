﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;

namespace TesApi.Web
{
    /// <summary>
    /// Utility class that provides mapping between VM names and billing meters
    /// </summary>
    public static class AzureBillingUtils
    {
        /// <summary>
        /// Lists all VM sizes verified supported by Azure Batch, along with the family and billing meter names
        /// </summary>
        /// <returns>List of VM sizes</returns>
        public static List<(string VmSize, string FamilyName, string MeterName, string MeterSubCategory)> GetVmSizesSupportedByBatch()
            => VmSizesFamiliesAndMeters.Where(v => VerifiedVmSizes.Contains(v.VmSize, StringComparer.OrdinalIgnoreCase)).ToList();

        private static IEnumerable<(string VmSize, string FamilyName, string MeterName, string MeterSubCategory)> VmSizesFamiliesAndMeters => new[]
        {
            ("Standard_A10", "standardA8_A11Family", "A10", "A Series"),
            ("Standard_A11", "standardA8_A11Family", "A11", "A Series"),
            ("Standard_A2", "standardA0_A7Family", "A2", "A Series"),
            ("Standard_A2_v2", "standardAv2Family", "A2 v2", "Av2 Series"),
            ("Standard_A2m_v2", "standardAv2Family", "A2m v2", "Av2 Series"),
            ("Standard_A3", "standardA0_A7Family", "A3", "A Series"),
            ("Standard_A4", "standardA0_A7Family", "A4", "A Series"),
            ("Standard_A4_v2", "standardAv2Family", "A4 v2", "Av2 Series"),
            ("Standard_A4m_v2", "standardAv2Family", "A4m v2", "Av2 Series"),
            ("Standard_A5", "standardA0_A7Family", "A5", "A Series"),
            ("Standard_A6", "standardA0_A7Family", "A6", "A Series"),
            ("Standard_A7", "standardA0_A7Family", "A7", "A Series"),
            ("Standard_A8", "standardA8_A11Family", "A8", "A Series"),
            ("Standard_A8_v2", "standardAv2Family", "A8 v2", "Av2 Series"),
            ("Standard_A8m_v2", "standardAv2Family", "A8m v2", "Av2 Series"),
            ("Standard_A9", "standardA8_A11Family", "A9", "A Series"),
            ("Standard_D11", "standardDFamily", "D11/DS11", "D/DS Series"),
            ("Standard_D11_v2", "standardDv2Family", "D11 v2/DS11 v2", "Dv2/DSv2 Series"),
            ("Standard_D12", "standardDFamily", "D12/DS12", "D/DS Series"),
            ("Standard_D12_v2", "standardDv2Family", "D12 v2/DS12 v2", "Dv2/DSv2 Series"),
            ("Standard_D13", "standardDFamily", "D13/DS13", "D/DS Series"),
            ("Standard_D13_v2", "standardDv2Family", "D13 v2/DS13 v2", "Dv2/DSv2 Series"),
            ("Standard_D14", "standardDFamily", "D14/DS14", "D/DS Series"),
            ("Standard_D14_v2", "standardDv2Family", "D14 v2/DS14 v2", "Dv2/DSv2 Series"),
            ("Standard_D15_v2", "standardDv2Family", "D15 v2/DS15 v2", "Dv2/DSv2 Series"),
            ("Standard_D16_v3", "standardDv3Family", "D16 v3/D16s v3", "Dv3/DSv3 Series"),
            ("Standard_D16a_v4", "standardDAv4Family", "D16a v4/D16as v4", "Dav4/Dasv4 Series"),
            ("Standard_D16as_v4", "standardDASv4Family", "D16a v4/D16as v4", "Dav4/Dasv4 Series"),
            ("Standard_D16d_v4", "standardDDv4Family", "D16d v4", "Ddv4 Series"),
            ("Standard_D16ds_v4", "standardDDSv4Family", "D16ds v4", "Ddsv4 Series"),
            ("Standard_D16s_v3", "standardDSv3Family", "D16 v3/D16s v3", "Dv3/DSv3 Series"),
            ("Standard_D2", "standardDFamily", "D2/DS2", "D/DS Series"),
            ("Standard_D2_v2", "standardDv2Family", "D2 v2/DS2 v2", "Dv2/DSv2 Series"),
            ("Standard_D2_v3", "standardDv3Family", "D2 v3/D2s v3", "Dv3/DSv3 Series"),
            ("Standard_D2a_v4", "standardDAv4Family", "D2a v4/D2as v4", "Dav4/Dasv4 Series"),
            ("Standard_D2as_v4", "standardDASv4Family", "D2a v4/D2as v4", "Dav4/Dasv4 Series"),
            ("Standard_D2d_v4", "standardDDv4Family", "D2d v4", "Ddv4 Series"),
            ("Standard_D2ds_v4", "standardDDSv4Family", "D2ds v4", "Ddsv4 Series"),
            ("Standard_D2s_v3", "standardDSv3Family", "D2 v3/D2s v3", "Dv3/DSv3 Series"),
            ("Standard_D3", "standardDFamily", "D3/DS3", "D/DS Series"),
            ("Standard_D3_v2", "standardDv2Family", "D3 v2/DS3 v2", "Dv2/DSv2 Series"),
            ("Standard_D32_v3", "standardDv3Family", "D32 v3/D32s v3", "Dv3/DSv3 Series"),
            ("Standard_D32a_v4", "standardDAv4Family", "D32a v4/D32as v4", "Dav4/Dasv4 Series"),
            ("Standard_D32as_v4", "standardDASv4Family", "D32a v4/D32as v4", "Dav4/Dasv4 Series"),
            ("Standard_D32d_v4", "standardDDv4Family", "D32d v4", "Ddv4 Series"),
            ("Standard_D32ds_v4", "standardDDSv4Family", "D32ds v4", "Ddsv4 Series"),
            ("Standard_D32s_v3", "standardDSv3Family", "D32 v3/D32s v3", "Dv3/DSv3 Series"),
            ("Standard_D4", "standardDFamily", "D4/DS4", "D/DS Series"),
            ("Standard_D4_v2", "standardDv2Family", "D4 v2/DS4 v2", "Dv2/DSv2 Series"),
            ("Standard_D4_v3", "standardDv3Family", "D4 v3/D4s v3", "Dv3/DSv3 Series"),
            ("Standard_D48_v3", "standardDv3Family", "D48 v3/D48s v3", "Dv3/DSv3 Series"),
            ("Standard_D48a_v4", "standardDAv4Family", "D48a v4/D48as v4", "Dav4/Dasv4 Series"),
            ("Standard_D48as_v4", "standardDASv4Family", "D48a v4/D48as v4", "Dav4/Dasv4 Series"),
            ("Standard_D48d_v4", "standardDDv4Family", "D48d v4", "Ddv4 Series"),
            ("Standard_D48ds_v4", "standardDDSv4Family", "D48ds v4", "Ddsv4 Series"),
            ("Standard_D48s_v3", "standardDSv3Family", "D48 v3/D48s v3", "Dv3/DSv3 Series"),
            ("Standard_D4a_v4", "standardDAv4Family", "D4a v4/D4as v4", "Dav4/Dasv4 Series"),
            ("Standard_D4as_v4", "standardDASv4Family", "D4a v4/D4as v4", "Dav4/Dasv4 Series"),
            ("Standard_D4d_v4", "standardDDv4Family", "D4d v4", "Ddv4 Series"),
            ("Standard_D4ds_v4", "standardDDSv4Family", "D4ds v4", "Ddsv4 Series"),
            ("Standard_D4s_v3", "standardDSv3Family", "D4 v3/D4s v3", "Dv3/DSv3 Series"),
            ("Standard_D5_v2", "standardDv2Family", "D5 v2/DS5 v2", "Dv2/DSv2 Series"),
            ("Standard_D64_v3", "standardDv3Family", "D64 v3/D64s v3", "Dv3/DSv3 Series"),
            ("Standard_D64a_v4", "standardDAv4Family", "D64a v4/D64as v4", "Dav4/Dasv4 Series"),
            ("Standard_D64as_v4", "standardDASv4Family", "D64a v4/D64as v4", "Dav4/Dasv4 Series"),
            ("Standard_D64d_v4", "standardDDv4Family", "D64d v4", "Ddv4 Series"),
            ("Standard_D64ds_v4", "standardDDSv4Family", "D64ds v4", "Ddsv4 Series"),
            ("Standard_D64s_v3", "standardDSv3Family", "D64 v3/D64s v3", "Dv3/DSv3 Series"),
            ("Standard_D8_v3", "standardDv3Family", "D8 v3/D8s v3", "Dv3/DSv3 Series"),
            ("Standard_D8a_v4", "standardDAv4Family", "D8a v4/D8as v4", "Dav4/Dasv4 Series"),
            ("Standard_D8as_v4", "standardDASv4Family", "D8a v4/D8as v4", "Dav4/Dasv4 Series"),
            ("Standard_D8d_v4", "standardDDv4Family", "D8d v4", "Ddv4 Series"),
            ("Standard_D8ds_v4", "standardDDSv4Family", "D8ds v4", "Ddsv4 Series"),
            ("Standard_D8s_v3", "standardDSv3Family", "D8 v3/D8s v3", "Dv3/DSv3 Series"),
            ("Standard_D96a_v4", "standardDAv4Family", "D96a v4/D96as v4", "Dav4/Dasv4 Series"),
            ("Standard_D96as_v4", "standardDASv4Family", "D96a v4/D96as v4", "Dav4/Dasv4 Series"),
            ("Standard_DC1s_v2", "standardDCSv2Family", "DC1s v2", "DCSv2 Series"),
            ("Standard_DC2s_v2", "standardDCSv2Family", "DC2s v2", "DCSv2 Series"),
            ("Standard_DC4s_v2", "standardDCSv2Family", "DC4s v2", "DCSv2 Series"),
            ("Standard_DS11", "standardDSFamily", "D11/DS11", "D/DS Series"),
            ("Standard_DS11_v2", "standardDSv2Family", "D11 v2/DS11 v2", "Dv2/DSv2 Series"),
            ("Standard_DS12", "standardDSFamily", "D12/DS12", "D/DS Series"),
            ("Standard_DS12_v2", "standardDSv2Family", "D12 v2/DS12 v2", "Dv2/DSv2 Series"),
            ("Standard_DS13", "standardDSFamily", "D13/DS13", "D/DS Series"),
            ("Standard_DS13_v2", "standardDSv2Family", "D13 v2/DS13 v2", "Dv2/DSv2 Series"),
            ("Standard_DS14", "standardDSFamily", "D14/DS14", "D/DS Series"),
            ("Standard_DS14_v2", "standardDSv2Family", "D14 v2/DS14 v2", "Dv2/DSv2 Series"),
            ("Standard_DS15_v2", "standardDSv2Family", "D15 v2/DS15 v2", "Dv2/DSv2 Series"),
            ("Standard_DS2", "standardDSFamily", "D2/DS2", "D/DS Series"),
            ("Standard_DS2_v2", "standardDSv2Family", "D2 v2/DS2 v2", "Dv2/DSv2 Series"),
            ("Standard_DS3", "standardDSFamily", "D3/DS3", "D/DS Series"),
            ("Standard_DS3_v2", "standardDSv2Family", "D3 v2/DS3 v2", "Dv2/DSv2 Series"),
            ("Standard_DS4", "standardDSFamily", "D4/DS4", "D/DS Series"),
            ("Standard_DS4_v2", "standardDSv2Family", "D4 v2/DS4 v2", "Dv2/DSv2 Series"),
            ("Standard_DS5_v2", "standardDSv2Family", "D5 v2/DS5 v2", "Dv2/DSv2 Series"),
            ("Standard_E16_v3", "standardEv3Family", "E16 v3/E16s v3", "Ev3/ESv3 Series"),
            ("Standard_E16a_v4", "standardEAv4Family", "E16a v4/E16as v4", "Eav4/Easv4 Series"),
            ("Standard_E16as_v4", "standardEASv4Family", "E16a v4/E16as v4", "Eav4/Easv4 Series"),
            ("Standard_E16d_v4", "standardEDv4Family", "E16d v4", "Edv4 Series"),
            ("Standard_E16ds_v4", "standardEDSv4Family", "E16ds v4", "Edsv4 Series"),
            ("Standard_E16s_v3", "standardESv3Family", "E16 v3/E16s v3", "Ev3/ESv3 Series"),
            ("Standard_E2_v3", "standardEv3Family", "E2 v3/E2s v3", "Ev3/ESv3 Series"),
            ("Standard_E2a_v4", "standardEAv4Family", "E2a v4/E2as v4", "Eav4/Easv4 Series"),
            ("Standard_E2as_v4", "standardEASv4Family", "E2a v4/E2as v4", "Eav4/Easv4 Series"),
            ("Standard_E2d_v4", "standardEDv4Family", "E2d v4", "Edv4 Series"),
            ("Standard_E2ds_v4", "standardEDSv4Family", "E2ds v4", "Edsv4 Series"),
            ("Standard_E2s_v3", "standardESv3Family", "E2 v3/E2s v3", "Ev3/ESv3 Series"),
            ("Standard_E32_v3", "standardEv3Family", "E32 v3/E32s v3", "Ev3/ESv3 Series"),
            ("Standard_E32a_v4", "standardEAv4Family", "E32a v4/E32as v4", "Eav4/Easv4 Series"),
            ("Standard_E32as_v4", "standardEASv4Family", "E32a v4/E32as v4", "Eav4/Easv4 Series"),
            ("Standard_E32d_v4", "standardEDv4Family", "E32d v4", "Edv4 Series"),
            ("Standard_E32ds_v4", "standardEDSv4Family", "E32ds v4", "Edsv4 Series"),
            ("Standard_E32s_v3", "standardESv3Family", "E32 v3/E32s v3", "Ev3/ESv3 Series"),
            ("Standard_E4_v3", "standardEv3Family", "E4 v3/E4s v3", "Ev3/ESv3 Series"),
            ("Standard_E48_v3", "standardEv3Family", "E48 v3/E48s v3", "Ev3/ESv3 Series"),
            ("Standard_E48a_v4", "standardEAv4Family", "E48a v4/E48as v4", "Eav4/Easv4 Series"),
            ("Standard_E48as_v4", "standardEASv4Family", "E48a v4/E48as v4", "Eav4/Easv4 Series"),
            ("Standard_E48d_v4", "standardEDv4Family", "E48d v4", "Edv4 Series"),
            ("Standard_E48ds_v4", "standardEDSv4Family", "E48ds v4", "Edsv4 Series"),
            ("Standard_E48s_v3", "standardESv3Family", "E48 v3/E48s v3", "Ev3/ESv3 Series"),
            ("Standard_E4a_v4", "standardEAv4Family", "E4a v4/E4as v4", "Eav4/Easv4 Series"),
            ("Standard_E4as_v4", "standardEASv4Family", "E4a v4/E4as v4", "Eav4/Easv4 Series"),
            ("Standard_E4d_v4", "standardEDv4Family", "E4d v4", "Edv4 Series"),
            ("Standard_E4ds_v4", "standardEDSv4Family", "E4ds v4", "Edsv4 Series"),
            ("Standard_E4s_v3", "standardESv3Family", "E4 v3/E4s v3", "Ev3/ESv3 Series"),
            ("Standard_E64_v3", "standardEv3Family", "E64 v3/E64s v3", "Ev3/ESv3 Series"),
            ("Standard_E64a_v4", "standardEAv4Family", "E64a v4/E64as v4", "Eav4/Easv4 Series"),
            ("Standard_E64as_v4", "standardEASv4Family", "E64a v4/E64as v4", "Eav4/Easv4 Series"),
            ("Standard_E64d_v4", "standardEDv4Family", "E64d v4", "Edv4 Series"),
            ("Standard_E64ds_v4", "standardEDSv4Family", "E64ds v4", "Edsv4 Series"),
            ("Standard_E64i_v3", "standardEIv3Family", "E64i v3/E64is v3", "Ev3/ESv3 Series"),
            ("Standard_E64s_v3", "standardESv3Family", "E64 v3/E64s v3", "Ev3/ESv3 Series"),
            ("Standard_E8_v3", "standardEv3Family", "E8 v3/E8s v3", "Ev3/ESv3 Series"),
            ("Standard_E80ids_v4", "standardXEIDSv4Family", "E80ids v4", "Edsv4 Series"),
            ("Standard_E80is_v4", "standardXEISv4Family", "E80is v4", "Esv4 Series"),
            ("Standard_E8a_v4", "standardEAv4Family", "E8a v4/E8as v4", "Eav4/Easv4 Series"),
            ("Standard_E8as_v4", "standardEASv4Family", "E8a v4/E8as v4", "Eav4/Easv4 Series"),
            ("Standard_E8d_v4", "standardEDv4Family", "E8d v4", "Edv4 Series"),
            ("Standard_E8ds_v4", "standardEDSv4Family", "E8ds v4", "Edsv4 Series"),
            ("Standard_E8s_v3", "standardESv3Family", "E8 v3/E8s v3", "Ev3/ESv3 Series"),
            ("Standard_E96a_v4", "standardEAv4Family", "E96a v4/E96as v4", "Eav4/Easv4 Series"),
            ("Standard_E96as_v4", "standardEASv4Family", "E96a v4/E96as v4", "Eav4/Easv4 Series"),
            ("Standard_F16", "standardFFamily", "F16/F16s", "F/FS Series"),
            ("Standard_F16s", "standardFSFamily", "F16/F16s", "F/FS Series"),
            ("Standard_F16s_v2", "standardFSv2Family", "F16s v2", "FSv2 Series"),
            ("Standard_F2", "standardFFamily", "F2/F2s", "F/FS Series"),
            ("Standard_F2s", "standardFSFamily", "F2/F2s", "F/FS Series"),
            ("Standard_F2s_v2", "standardFSv2Family", "F2s v2", "FSv2 Series"),
            ("Standard_F32s_v2", "standardFSv2Family", "F32s v2", "FSv2 Series"),
            ("Standard_F4", "standardFFamily", "F4/F4s", "F/FS Series"),
            ("Standard_F48s_v2", "standardFSv2Family", "F48s v2", "FSv2 Series"),
            ("Standard_F4s", "standardFSFamily", "F4/F4s", "F/FS Series"),
            ("Standard_F4s_v2", "standardFSv2Family", "F4s v2", "FSv2 Series"),
            ("Standard_F64s_v2", "standardFSv2Family", "F64s v2", "FSv2 Series"),
            ("Standard_F72s_v2", "standardFSv2Family", "F72s v2", "FSv2 Series"),
            ("Standard_F8", "standardFFamily", "F8/F8s", "F/FS Series"),
            ("Standard_F8s", "standardFSFamily", "F8/F8s", "F/FS Series"),
            ("Standard_F8s_v2", "standardFSv2Family", "F8s v2", "FSv2 Series"),
            ("Standard_G1", "standardGFamily", "G1/GS1", "G/GS Series"),
            ("Standard_G2", "standardGFamily", "G2/GS2", "G/GS Series"),
            ("Standard_G3", "standardGFamily", "G3/GS3", "G/GS Series"),
            ("Standard_G4", "standardGFamily", "G4/GS4", "G/GS Series"),
            ("Standard_G5", "standardGFamily", "G5/GS5", "G/GS Series"),
            ("Standard_GS1", "standardGSFamily", "G1/GS1", "G/GS Series"),
            ("Standard_GS2", "standardGSFamily", "G2/GS2", "G/GS Series"),
            ("Standard_GS3", "standardGSFamily", "G3/GS3", "G/GS Series"),
            ("Standard_GS4", "standardGSFamily", "G4/GS4", "G/GS Series"),
            ("Standard_GS5", "standardGSFamily", "G5/GS5", "G/GS Series"),
            ("Standard_H16", "standardHFamily", "H16", "H Series"),
            ("Standard_H16_Promo", "standardHPromoFamily", "H16", "H Promo Series"),
            ("Standard_H16m", "standardHFamily", "H16m", "H Series"),
            ("Standard_H16m_Promo", "standardHPromoFamily", "H16m", "H Promo Series"),
            ("Standard_H16mr", "standardHFamily", "H16mr", "H Series"),
            ("Standard_H16mr_Promo", "standardHPromoFamily", "H16mr", "H Promo Series"),
            ("Standard_H16r", "standardHFamily", "H16r", "H Series"),
            ("Standard_H16r_Promo", "standardHPromoFamily", "H16r", "H Promo Series"),
            ("Standard_H8", "standardHFamily", "H8", "H Series"),
            ("Standard_H8_Promo", "standardHPromoFamily", "H8", "H Promo Series"),
            ("Standard_H8m", "standardHFamily", "H8m", "H Series"),
            ("Standard_H8m_Promo", "standardHPromoFamily", "H8m", "H Promo Series"),
            ("Standard_HB120-16rs_v3", "standardHBv3Family", "HB120rs_v3", "HBrsv3 Series"),
            ("Standard_HB120-32rs_v3", "standardHBv3Family", "HB120rs_v3", "HBrsv3 Series"),
            ("Standard_HB120-64rs_v3", "standardHBv3Family", "HB120rs_v3", "HBrsv3 Series"),
            ("Standard_HB120-96rs_v3", "standardHBv3Family", "HB120rs_v3", "HBrsv3 Series"),
            ("Standard_HB120rs_v2", "standardHBrsv2Family", "HB120rs v2", "HBSv2 Series"),
            ("Standard_HB120rs_v3", "standardHBv3Family", "HB120rs_v3", "HBrsv3 Series"),
            ("Standard_HB60rs", "standardHBSFamily", "HB60rs", "HBS Series"),
            ("Standard_HC44rs", "standardHCSFamily", "HC44rs", "HCS Series"),
            ("Standard_L16s", "standardLSFamily", "L16s", "LS Series"),
            ("Standard_L16s_v2", "standardLSv2Family", "L16s v2", "LSv2 Series"),
            ("Standard_L32s", "standardLSFamily", "L32s", "LS Series"),
            ("Standard_L32s_v2", "standardLSv2Family", "L32s v2", "LSv2 Series"),
            ("Standard_L48s_v2", "standardLSv2Family", "L48s v2", "LSv2 Series"),
            ("Standard_L4s", "standardLSFamily", "L4s", "LS Series"),
            ("Standard_L64s_v2", "standardLSv2Family", "L64s v2", "LSv2 Series"),
            ("Standard_L80s_v2", "standardLSv2Family", "L80s v2", "LSv2 Series"),
            ("Standard_L8s", "standardLSFamily", "L8s", "LS Series"),
            ("Standard_L8s_v2", "standardLSv2Family", "L8s v2", "LSv2 Series"),
            ("Standard_M128", "standardMSFamily", "M128s", "MS Series"),
            ("Standard_M128m", "standardMSFamily", "M128ms", "MS Series"),
            ("Standard_M128ms", "standardMSFamily", "M128ms", "MS Series"),
            ("Standard_M128s", "standardMSFamily", "M128s", "MS Series"),
            ("Standard_M16ms", "standardMSFamily", "M16ms", "MS Series"),
            ("Standard_M208ms_v2", "standardMSv2Family", "M208ms v2", "MSv2 Series"),
            ("Standard_M208s_v2", "standardMSv2Family", "M208s v2", "MSv2 Series"),
            ("Standard_M32ls", "standardMSFamily", "M32ls", "MS Series"),
            ("Standard_M32ms", "standardMSFamily", "M32ms", "MS Series"),
            ("Standard_M32ts", "standardMSFamily", "M32ts", "MS Series"),
            ("Standard_M416ms_v2", "standardMSv2Family", "M416ms v2", "MSv2 Series"),
            ("Standard_M416s_v2", "standardMSv2Family", "M416s v2", "MSv2 Series"),
            ("Standard_M64", "standardMSFamily", "M64s", "MS Series"),
            ("Standard_M64ls", "standardMSFamily", "M64ls", "MS Series"),
            ("Standard_M64m", "standardMSFamily", "M64ms", "MS Series"),
            ("Standard_M64ms", "standardMSFamily", "M64ms", "MS Series"),
            ("Standard_M64s", "standardMSFamily", "M64s", "MS Series"),
            ("Standard_M8ms", "standardMSFamily", "M8ms", "MS Series"),
            ("Standard_NC12", "standardNCFamily", "NC12", "NC Series"),
            ("Standard_NC12_Promo", "standardNCPromoFamily", "NC12", "NC Promo Series"),
            ("Standard_NC12s_v2", "standardNCSv2Family", "NC12s v2", "NCSv2 Series"),
            ("Standard_NC12s_v3", "standardNCSv3Family", "NC12s v3", "NCSv3 Series"),
            ("Standard_NC16as_T4_v3", "standardNCASt4v3Family", "NC16as T4 v3", "NCasv3 T4 Series"),
            ("Standard_NC24", "standardNCFamily", "NC24", "NC Series"),
            ("Standard_NC24_Promo", "standardNCPromoFamily", "NC24", "NC Promo Series"),
            ("Standard_NC24r", "standardNCFamily", "NC24R", "NC Series"),
            ("Standard_NC24r_Promo", "standardNCPromoFamily", "NC24r", "NC Promo Series"),
            ("Standard_NC24rs_v2", "standardNCSv2Family", "NC24rs v2", "NCSv2 Series"),
            ("Standard_NC24rs_v3", "standardNCSv3Family", "NC24rs v3", "NCSv3 Series"),
            ("Standard_NC24s_v2", "standardNCSv2Family", "NC24s v2", "NCSv2 Series"),
            ("Standard_NC24s_v3", "standardNCSv3Family", "NC24s v3", "NCSv3 Series"),
            ("Standard_NC4as_T4_v3", "standardNCASt4v3Family", "NC4as T4 v3", "NCasv3 T4 Series"),
            ("Standard_NC6", "standardNCFamily", "NC6", "NC Series"),
            ("Standard_NC6_Promo", "standardNCPromoFamily", "NC6", "NC Promo Series"),
            ("Standard_NC64as_T4_v3", "standardNCASt4v3Family", "NC64as T4 v3", "NCasv3 T4 Series"),
            ("Standard_NC6s_v2", "standardNCSv2Family", "NC6s v2", "NCSv2 Series"),
            ("Standard_NC6s_v3", "standardNCSv3Family", "NC6s v3", "NCSv3 Series"),
            ("Standard_NC8as_T4_v3", "standardNCASt4v3Family", "NC8as T4 v3", "NCasv3 T4 Series"),
            ("Standard_ND12s", "standardNDSFamily", "ND12s", "NDS Series"),
            ("Standard_ND24rs", "standardNDSFamily", "ND24rs", "NDS Series"),
            ("Standard_ND24s", "standardNDSFamily", "ND24s", "NDS Series"),
            ("Standard_ND40rs_v2", "standardNDSv2Family", "ND40rs v2", "NDrSv2 Series"),
            ("Standard_ND40s_v2", "standardNDSv2Family", "NDmr40s v2", "NDSv2 Series"),
            ("Standard_ND6s", "standardNDSFamily", "ND6s", "NDS Series"),
            ("Standard_ND96asr_v4", "standardNDASv4Family", "ND96asr v4", "NDasr A100 v4 Series"),
            ("Standard_NP10s", "standardNPSFamily", "NP10s", "NP Series"),
            ("Standard_NP20s", "standardNPSFamily", "NP20s", "NP Series"),
            ("Standard_NP40s", "standardNPSFamily", "NP40s", "NP Series"),
            ("Standard_NV12", "standardNVFamily", "NV12", "NV Series"),
            ("Standard_NV12_Promo", "standardNVPromoFamily", "NV12", "NV Promo Series"),
            ("Standard_NV12s_v3", "standardNVSv3Family", "NV12s v3", "NVSv3 Series"),
            ("Standard_NV16as_v4", "standardNVSv4Family", "NV16as v4", "NVasv4 Series"),
            ("Standard_NV24", "standardNVFamily", "NV24", "NV Series"),
            ("Standard_NV24_Promo", "standardNVPromoFamily", "NV24", "NV Promo Series"),
            ("Standard_NV24s_v3", "standardNVSv3Family", "NV24s v3", "NVSv3 Series"),
            ("Standard_NV32as_v4", "standardNVSv4Family", "NV32as v4", "NVasv4 Series"),
            ("Standard_NV48s_v3", "standardNVSv3Family", "NV48s v3", "NVSv3 Series"),
            ("Standard_NV4as_v4", "standardNVSv4Family", "NV4as v4", "NVasv4 Series"),
            ("Standard_NV6", "standardNVFamily", "NV6", "NV Series"),
            ("Standard_NV6_Promo", "standardNVPromoFamily", "NV6", "NV Promo Series"),
            ("Standard_NV8as_v4", "standardNVSv4Family", "NV8as v4", "NVasv4 Series"),
        };

        // TODO: Batch will provide an API for this in a future release of the client library
        private static IEnumerable<string> VerifiedVmSizes => new List<string>
        {
            "Standard_A1",
            "Standard_A1_v2",
            "Standard_A2",
            "Standard_A2_v2",
            "Standard_A2m_v2",
            "Standard_A3",
            "Standard_A4",
            "Standard_A4_v2",
            "Standard_A4m_v2",
            "Standard_A5",
            "Standard_A6",
            "Standard_A7",
            "Standard_A8_v2",
            "Standard_A8m_v2",
            "Standard_D1",
            "Standard_D1_v2",
            "Standard_D11",
            "Standard_D11_v2",
            "Standard_D12",
            "Standard_D12_v2",
            "Standard_D13",
            "Standard_D13_v2",
            "Standard_D14",
            "Standard_D14_v2",
            "Standard_D16_v3",
            "Standard_D16a_v4",
            "Standard_D16as_v4",
            "Standard_D16d_v4",
            "Standard_D16ds_v4",
            "Standard_D16s_v3",
            "Standard_D2",
            "Standard_D2_v2",
            "Standard_D2_v3",
            "Standard_D2a_v4",
            "Standard_D2as_v4",
            "Standard_D2d_v4",
            "Standard_D2ds_v4",
            "Standard_D2s_v3",
            "Standard_D3",
            "Standard_D3_v2",
            "Standard_D32_v3",
            "Standard_D32a_v4",
            "Standard_D32as_v4",
            "Standard_D32d_v4",
            "Standard_D32ds_v4",
            "Standard_D32s_v3",
            "Standard_D4",
            "Standard_D4_v2",
            "Standard_D4_v3",
            "Standard_D48_v3",
            "Standard_D48a_v4",
            "Standard_D48as_v4",
            "Standard_D48d_v4",
            "Standard_D48ds_v4",
            "Standard_D48s_v3",
            "Standard_D4a_v4",
            "Standard_D4as_v4",
            "Standard_D4d_v4",
            "Standard_D4ds_v4",
            "Standard_D4s_v3",
            "Standard_D5_v2",
            "Standard_D64_v3",
            "Standard_D64a_v4",
            "Standard_D64as_v4",
            "Standard_D64d_v4",
            "Standard_D64ds_v4",
            "Standard_D64s_v3",
            "Standard_D8_v3",
            "Standard_D8a_v4",
            "Standard_D8as_v4",
            "Standard_D8d_v4",
            "Standard_D8ds_v4",
            "Standard_D8s_v3",
            "Standard_D96a_v4",
            "Standard_D96as_v4",
            "Standard_DS1",
            "Standard_DS1_v2",
            "Standard_DS11",
            "Standard_DS11_v2",
            "Standard_DS12",
            "Standard_DS12_v2",
            "Standard_DS13",
            "Standard_DS13_v2",
            "Standard_DS14",
            "Standard_DS14_v2",
            "Standard_DS2",
            "Standard_DS2_v2",
            "Standard_DS3",
            "Standard_DS3_v2",
            "Standard_DS4",
            "Standard_DS4_v2",
            "Standard_DS5_v2",
            "Standard_E16_v3",
            "Standard_E16a_v4",
            "Standard_E16as_v4",
            "Standard_E16d_v4",
            "Standard_E16ds_v4",
            "Standard_E16s_v3",
            "Standard_E2_v3",
            "Standard_E2a_v4",
            "Standard_E2as_v4",
            "Standard_E2d_v4",
            "Standard_E2ds_v4",
            "Standard_E2s_v3",
            "Standard_E32_v3",
            "Standard_E32a_v4",
            "Standard_E32as_v4",
            "Standard_E32d_v4",
            "Standard_E32ds_v4",
            "Standard_E32s_v3",
            "Standard_E4_v3",
            "Standard_E48_v3",
            "Standard_E48a_v4",
            "Standard_E48as_v4",
            "Standard_E48d_v4",
            "Standard_E48ds_v4",
            "Standard_E48s_v3",
            "Standard_E4a_v4",
            "Standard_E4as_v4",
            "Standard_E4d_v4",
            "Standard_E4ds_v4",
            "Standard_E4s_v3",
            "Standard_E64_v3",
            "Standard_E64a_v4",
            "Standard_E64as_v4",
            "Standard_E64d_v4",
            "Standard_E64ds_v4",
            "Standard_E64i_v3",
            "Standard_E64s_v3",
            "Standard_E8_v3",
            "Standard_E80ids_v4",
            "Standard_E8a_v4",
            "Standard_E8as_v4",
            "Standard_E8d_v4",
            "Standard_E8ds_v4",
            "Standard_E8s_v3",
            "Standard_E96a_v4",
            "Standard_E96as_v4",
            "Standard_F1",
            "Standard_F16",
            "Standard_F16s",
            "Standard_F16s_v2",
            "Standard_F1s",
            "Standard_F2",
            "Standard_F2s",
            "Standard_F2s_v2",
            "Standard_F32s_v2",
            "Standard_F4",
            "Standard_F48s_v2",
            "Standard_F4s",
            "Standard_F4s_v2",
            "Standard_F64s_v2",
            "Standard_F72s_v2",
            "Standard_F8",
            "Standard_F8s",
            "Standard_F8s_v2",
            "Standard_G1",
            "Standard_G2",
            "Standard_G3",
            "Standard_G4",
            "Standard_G5",
            "Standard_GS1",
            "Standard_GS2",
            "Standard_GS3",
            "Standard_GS4",
            "Standard_GS5",
            "Standard_H16",
            "Standard_H16m",
            "Standard_H16mr",
            "Standard_H16r",
            "Standard_H8",
            "Standard_H8m",
            "Standard_HB120-16rs_v3",
            "Standard_HB120-32rs_v3",
            "Standard_HB120-64rs_v3",
            "Standard_HB120-96rs_v3",
            "Standard_HB120rs_v2",
            "Standard_HB120rs_v3",
            "Standard_HB60rs",
            "Standard_HC44rs",
            "Standard_L16s",
            "Standard_L16s_v2",
            "Standard_L32s",
            "Standard_L32s_v2",
            "Standard_L48s_v2",
            "Standard_L4s",
            "Standard_L64s_v2",
            "Standard_L80s_v2",
            "Standard_L8s",
            "Standard_L8s_v2",
            "Standard_M128",
            "Standard_M128m",
            "Standard_M128ms",
            "Standard_M128s",
            "Standard_M16ms",
            "Standard_M32ls",
            "Standard_M32ms",
            "Standard_M32ts",
            "Standard_M64",
            "Standard_M64ls",
            "Standard_M64m",
            "Standard_M64ms",
            "Standard_M64s",
            "Standard_M8ms",
            "Standard_NC12",
            "Standard_NC12s_v2",
            "Standard_NC12s_v3",
            "Standard_NC16as_T4_v3",
            "Standard_NC24",
            "Standard_NC24r",
            "Standard_NC24rs_v2",
            "Standard_NC24rs_v3",
            "Standard_NC24s_v2",
            "Standard_NC24s_v3",
            "Standard_NC4as_T4_v3",
            "Standard_NC6",
            "Standard_NC64as_T4_v3",
            "Standard_NC6s_v2",
            "Standard_NC6s_v3",
            "Standard_NC8as_T4_v3",
            "Standard_ND12s",
            "Standard_ND24rs",
            "Standard_ND24s",
            "Standard_ND6s",
            "Standard_NP10s",
            "Standard_NP20s",
            "Standard_NP40s",
            "Standard_NV12",
            "Standard_NV12s_v3",
            "Standard_NV16as_v4",
            "Standard_NV24",
            "Standard_NV24s_v3",
            "Standard_NV32as_v4",
            "Standard_NV48s_v3",
            "Standard_NV4as_v4",
            "Standard_NV6",
            "Standard_NV8as_v4"
        };
    }
}
