using System;
using ObjCRuntime;
using Foundation;

[assembly: LinkerSafe]
[assembly: LinkWith ("libRaygun4iOS.a", LinkTarget.ArmV7s | LinkTarget.ArmV7 | LinkTarget.Simulator, ForceLoad = true, SmartLink = true)]
