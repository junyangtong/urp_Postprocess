using System; 
using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
using UnityEngine.Rendering; 
using UnityEngine.Rendering.Universal; 
 
[Serializable, VolumeComponentMenu("Post-processing/TiltShiftBlur")] 
public class TiltShiftBlur : VolumeComponent, IPostProcessComponent 
{ 
    [Range(0.0f, 1.0f)] 
    public FloatParameter Offset = new FloatParameter(0.1f); 
 
    [Range(0.0f, 5.0f)] 
    public FloatParameter Area = new FloatParameter(1.5f); 
 
    [Range(0.0f, 1.0f)] 
    public FloatParameter Spread = new FloatParameter(0.8f); 
 
    [Range(0.0f, 50.0f)] 
    public FloatParameter BlurInt = new FloatParameter(0f);

    [Range(0.0f, 10.0f)] 
    public FloatParameter BlurStep = new FloatParameter(5f); 
 
    public bool IsActive() => BlurInt.value > 0f; 
 
    public bool IsTileCompatible() => false; 
} 