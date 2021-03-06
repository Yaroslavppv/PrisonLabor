﻿using Harmony;
using RimWorld;

namespace PrisonLabor.HarmonyPatches
{
    [HarmonyPatch(typeof(BillStack))]
    [HarmonyPatch("Delete")]
    [HarmonyPatch(new[] {typeof(Bill)})]
    internal class Patch_RemoveBillFromUtility
    {
        public static void Postfix(Bill bill)
        {
            BillUtility.Remove(bill);
        }
    }
}