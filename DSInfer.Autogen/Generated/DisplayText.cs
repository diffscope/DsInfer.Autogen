//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.2.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace DsInfer {

public class DisplayText : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal DisplayText(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(DisplayText obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(DisplayText obj) {
    if (obj != null) {
      if (!obj.swigCMemOwn)
        throw new global::System.ApplicationException("Cannot release ownership as memory is not owned");
      global::System.Runtime.InteropServices.HandleRef ptr = obj.swigCPtr;
      obj.swigCMemOwn = false;
      obj.Dispose();
      return ptr;
    } else {
      return new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
    }
  }

  ~DisplayText() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          dsinfer_csharp_bindingsPINVOKE.delete_DisplayText(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public DisplayText() : this(dsinfer_csharp_bindingsPINVOKE.new_DisplayText__SWIG_0(), true) {
  }

  public DisplayText(string text) : this(dsinfer_csharp_bindingsPINVOKE.new_DisplayText__SWIG_1(text), true) {
    if (dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Pending) throw dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Retrieve();
  }

  public DisplayText(JsonValue value) : this(dsinfer_csharp_bindingsPINVOKE.new_DisplayText__SWIG_2(JsonValue.getCPtr(value)), true) {
    if (dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Pending) throw dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Retrieve();
  }

  public DisplayText(string defaultText, StringMap texts) : this(dsinfer_csharp_bindingsPINVOKE.new_DisplayText__SWIG_3(defaultText, StringMap.getCPtr(texts)), true) {
    if (dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Pending) throw dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Retrieve();
  }

  public DisplayText(DisplayText rhs) : this(dsinfer_csharp_bindingsPINVOKE.new_DisplayText__SWIG_4(DisplayText.getCPtr(rhs)), true) {
    if (dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Pending) throw dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Retrieve();
  }

  public string text() {
    string ret = dsinfer_csharp_bindingsPINVOKE.DisplayText_text__SWIG_0(swigCPtr);
    return ret;
  }

  public string text(string locale) {
    string ret = dsinfer_csharp_bindingsPINVOKE.DisplayText_text__SWIG_1(swigCPtr, locale);
    if (dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Pending) throw dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isEmpty() {
    bool ret = dsinfer_csharp_bindingsPINVOKE.DisplayText_isEmpty(swigCPtr);
    return ret;
  }

}

}
