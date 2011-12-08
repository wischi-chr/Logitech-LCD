/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.4
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class lgLcdNotificationContext : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal lgLcdNotificationContext(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(lgLcdNotificationContext obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~lgLcdNotificationContext() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          LogitechLCDPINVOKE.delete_lgLcdNotificationContext(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_p_f_int_q_const__p_void_unsigned_long_unsigned_long_unsigned_long_unsigned_long_unsigned_long__unsigned_long notificationCallback {
    set {
      LogitechLCDPINVOKE.lgLcdNotificationContext_notificationCallback_set(swigCPtr, SWIGTYPE_p_f_int_q_const__p_void_unsigned_long_unsigned_long_unsigned_long_unsigned_long_unsigned_long__unsigned_long.getCPtr(value));
    } 
    get {
      IntPtr cPtr = LogitechLCDPINVOKE.lgLcdNotificationContext_notificationCallback_get(swigCPtr);
      SWIGTYPE_p_f_int_q_const__p_void_unsigned_long_unsigned_long_unsigned_long_unsigned_long_unsigned_long__unsigned_long ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_f_int_q_const__p_void_unsigned_long_unsigned_long_unsigned_long_unsigned_long_unsigned_long__unsigned_long(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_void notifyContext {
    set {
      LogitechLCDPINVOKE.lgLcdNotificationContext_notifyContext_set(swigCPtr, SWIGTYPE_p_void.getCPtr(value));
    } 
    get {
      IntPtr cPtr = LogitechLCDPINVOKE.lgLcdNotificationContext_notifyContext_get(swigCPtr);
      SWIGTYPE_p_void ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
      return ret;
    } 
  }

  public lgLcdNotificationContext() : this(LogitechLCDPINVOKE.new_lgLcdNotificationContext(), true) {
  }

}