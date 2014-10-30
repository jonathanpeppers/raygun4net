using System;
using System.Drawing;

using ObjCRuntime;
using Foundation;
using UIKit;

namespace Mindscape.Raygun4Net.Xamarin.iOS
{
  [BaseType (typeof (NSObject))]
  internal interface Raygun {

    [Static, Export ("sharedReporterWithApiKey:")]
    Raygun SharedReporterWithApiKey (string apiKey);

    [Export ("identify:")]
    void Identify (string userId);

    [Export ("crash")]
    void Crash();

    [Export ("nextReportUUID")]
    string NextReportUUID { get; }
  }
}
