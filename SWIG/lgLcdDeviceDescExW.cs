/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.4
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class lgLcdDeviceDescExW : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal lgLcdDeviceDescExW(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(lgLcdDeviceDescExW obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~lgLcdDeviceDescExW() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          LogitechLCDPINVOKE.delete_lgLcdDeviceDescExW(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public uint deviceFamilyId {
    set {
      LogitechLCDPINVOKE.lgLcdDeviceDescExW_deviceFamilyId_set(swigCPtr, value);
    } 
    get {
      uint ret = LogitechLCDPINVOKE.lgLcdDeviceDescExW_deviceFamilyId_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_WCHAR deviceDisplayName {
    set {
      LogitechLCDPINVOKE.lgLcdDeviceDescExW_deviceDisplayName_set(swigCPtr, SWIGTYPE_p_WCHAR.getCPtr(value));
    } 
    get {
      IntPtr cPtr = LogitechLCDPINVOKE.lgLcdDeviceDescExW_deviceDisplayName_get(swigCPtr);
      SWIGTYPE_p_WCHAR ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_WCHAR(cPtr, false);
      return ret;
    } 
  }

  public uint Width {
    set {
      LogitechLCDPINVOKE.lgLcdDeviceDescExW_Width_set(swigCPtr, value);
    } 
    get {
      uint ret = LogitechLCDPINVOKE.lgLcdDeviceDescExW_Width_get(swigCPtr);
      return ret;
    } 
  }

  public uint Height {
    set {
      LogitechLCDPINVOKE.lgLcdDeviceDescExW_Height_set(swigCPtr, value);
    } 
    get {
      uint ret = LogitechLCDPINVOKE.lgLcdDeviceDescExW_Height_get(swigCPtr);
      return ret;
    } 
  }

  public uint Bpp {
    set {
      LogitechLCDPINVOKE.lgLcdDeviceDescExW_Bpp_set(swigCPtr, value);
    } 
    get {
      uint ret = LogitechLCDPINVOKE.lgLcdDeviceDescExW_Bpp_get(swigCPtr);
      return ret;
    } 
  }

  public uint NumSoftButtons {
    set {
      LogitechLCDPINVOKE.lgLcdDeviceDescExW_NumSoftButtons_set(swigCPtr, value);
    } 
    get {
      uint ret = LogitechLCDPINVOKE.lgLcdDeviceDescExW_NumSoftButtons_get(swigCPtr);
      return ret;
    } 
  }

  public uint Reserved1 {
    set {
      LogitechLCDPINVOKE.lgLcdDeviceDescExW_Reserved1_set(swigCPtr, value);
    } 
    get {
      uint ret = LogitechLCDPINVOKE.lgLcdDeviceDescExW_Reserved1_get(swigCPtr);
      return ret;
    } 
  }

  public uint Reserved2 {
    set {
      LogitechLCDPINVOKE.lgLcdDeviceDescExW_Reserved2_set(swigCPtr, value);
    } 
    get {
      uint ret = LogitechLCDPINVOKE.lgLcdDeviceDescExW_Reserved2_get(swigCPtr);
      return ret;
    } 
  }

  public lgLcdDeviceDescExW() : this(LogitechLCDPINVOKE.new_lgLcdDeviceDescExW(), true) {
  }

}