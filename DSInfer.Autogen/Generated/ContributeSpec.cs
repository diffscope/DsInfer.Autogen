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

public class ContributeSpec : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ContributeSpec(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ContributeSpec obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(ContributeSpec obj) {
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

  ~ContributeSpec() {
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
          dsinfer_csharp_bindingsPINVOKE.delete_ContributeSpec(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public int type() {
    int ret = dsinfer_csharp_bindingsPINVOKE.ContributeSpec_type(swigCPtr);
    return ret;
  }

  public ContributeSpec.State state() {
    ContributeSpec.State ret = (ContributeSpec.State)dsinfer_csharp_bindingsPINVOKE.ContributeSpec_state(swigCPtr);
    return ret;
  }

  public LibrarySpec parent() {
    global::System.IntPtr cPtr = dsinfer_csharp_bindingsPINVOKE.ContributeSpec_parent(swigCPtr);
    LibrarySpec ret = (cPtr == global::System.IntPtr.Zero) ? null : new LibrarySpec(cPtr, false);
    return ret;
  }

  public Environment env() {
    global::System.IntPtr cPtr = dsinfer_csharp_bindingsPINVOKE.ContributeSpec_env(swigCPtr);
    Environment ret = (cPtr == global::System.IntPtr.Zero) ? null : new Environment(cPtr, false);
    return ret;
  }

  public string id() {
    string ret = dsinfer_csharp_bindingsPINVOKE.ContributeSpec_id(swigCPtr);
    return ret;
  }

  public enum Type {
    Inference,
    Singer
  }

  public enum State {
    Invalid,
    Initialized,
    Ready,
    Finished,
    Deleted
  }

}

}
