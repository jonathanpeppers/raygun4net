using System;
using ObjCRuntime;
using Foundation;

[assembly: LinkWith ("libRaygun4iOS.a", LinkTarget.ArmV7s | LinkTarget.ArmV7 | LinkTarget.Simulator, ForceLoad = true)]
