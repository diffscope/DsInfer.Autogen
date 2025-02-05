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

public class JsonValue : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal JsonValue(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(JsonValue obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(JsonValue obj) {
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

  ~JsonValue() {
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
          dsinfer_csharp_bindingsPINVOKE.delete_JsonValue(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public JsonValue(JsonValue.Type type) : this(dsinfer_csharp_bindingsPINVOKE.new_JsonValue__SWIG_0((int)type), true) {
  }

  public JsonValue() : this(dsinfer_csharp_bindingsPINVOKE.new_JsonValue__SWIG_1(), true) {
  }

  public JsonValue(bool b) : this(dsinfer_csharp_bindingsPINVOKE.new_JsonValue__SWIG_2(b), true) {
  }

  public JsonValue(double n) : this(dsinfer_csharp_bindingsPINVOKE.new_JsonValue__SWIG_3(n), true) {
  }

  public JsonValue(int n) : this(dsinfer_csharp_bindingsPINVOKE.new_JsonValue__SWIG_4(n), true) {
  }

  public JsonValue(long n) : this(dsinfer_csharp_bindingsPINVOKE.new_JsonValue__SWIG_5(n), true) {
  }

  public JsonValue(string s) : this(dsinfer_csharp_bindingsPINVOKE.new_JsonValue__SWIG_6(s), true) {
    if (dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Pending) throw dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Retrieve();
  }

  public JsonValue(ByteArray bytes) : this(dsinfer_csharp_bindingsPINVOKE.new_JsonValue__SWIG_7(ByteArray.getCPtr(bytes)), true) {
    if (dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Pending) throw dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Retrieve();
  }

  public JsonValue(JsonArray a) : this(dsinfer_csharp_bindingsPINVOKE.new_JsonValue__SWIG_8(JsonArray.getCPtr(a)), true) {
    if (dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Pending) throw dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Retrieve();
  }

  public JsonValue(JsonObject o) : this(dsinfer_csharp_bindingsPINVOKE.new_JsonValue__SWIG_9(JsonObject.getCPtr(o)), true) {
    if (dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Pending) throw dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Retrieve();
  }

  public JsonValue(JsonValue other) : this(dsinfer_csharp_bindingsPINVOKE.new_JsonValue__SWIG_10(JsonValue.getCPtr(other)), true) {
    if (dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Pending) throw dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void swap(JsonValue other) {
    dsinfer_csharp_bindingsPINVOKE.JsonValue_swap(swigCPtr, JsonValue.getCPtr(other));
    if (dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Pending) throw dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Retrieve();
  }

  public JsonValue.Type type() {
    JsonValue.Type ret = (JsonValue.Type)dsinfer_csharp_bindingsPINVOKE.JsonValue_type(swigCPtr);
    return ret;
  }

  public bool isNull() {
    bool ret = dsinfer_csharp_bindingsPINVOKE.JsonValue_isNull(swigCPtr);
    return ret;
  }

  public bool isBool() {
    bool ret = dsinfer_csharp_bindingsPINVOKE.JsonValue_isBool(swigCPtr);
    return ret;
  }

  public bool isInteger() {
    bool ret = dsinfer_csharp_bindingsPINVOKE.JsonValue_isInteger(swigCPtr);
    return ret;
  }

  public bool isDouble() {
    bool ret = dsinfer_csharp_bindingsPINVOKE.JsonValue_isDouble(swigCPtr);
    return ret;
  }

  public bool isString() {
    bool ret = dsinfer_csharp_bindingsPINVOKE.JsonValue_isString(swigCPtr);
    return ret;
  }

  public bool isBinary() {
    bool ret = dsinfer_csharp_bindingsPINVOKE.JsonValue_isBinary(swigCPtr);
    return ret;
  }

  public bool isArray() {
    bool ret = dsinfer_csharp_bindingsPINVOKE.JsonValue_isArray(swigCPtr);
    return ret;
  }

  public bool isObject() {
    bool ret = dsinfer_csharp_bindingsPINVOKE.JsonValue_isObject(swigCPtr);
    return ret;
  }

  public bool isUndefined() {
    bool ret = dsinfer_csharp_bindingsPINVOKE.JsonValue_isUndefined(swigCPtr);
    return ret;
  }

  public bool toBool(bool defaultValue) {
    bool ret = dsinfer_csharp_bindingsPINVOKE.JsonValue_toBool__SWIG_0(swigCPtr, defaultValue);
    return ret;
  }

  public bool toBool() {
    bool ret = dsinfer_csharp_bindingsPINVOKE.JsonValue_toBool__SWIG_1(swigCPtr);
    return ret;
  }

  public int toInt(int defaultValue) {
    int ret = dsinfer_csharp_bindingsPINVOKE.JsonValue_toInt__SWIG_0(swigCPtr, defaultValue);
    return ret;
  }

  public int toInt() {
    int ret = dsinfer_csharp_bindingsPINVOKE.JsonValue_toInt__SWIG_1(swigCPtr);
    return ret;
  }

  public long toInt64(long defaultValue) {
    long ret = dsinfer_csharp_bindingsPINVOKE.JsonValue_toInt64__SWIG_0(swigCPtr, defaultValue);
    return ret;
  }

  public long toInt64() {
    long ret = dsinfer_csharp_bindingsPINVOKE.JsonValue_toInt64__SWIG_1(swigCPtr);
    return ret;
  }

  public double toDouble(double defaultValue) {
    double ret = dsinfer_csharp_bindingsPINVOKE.JsonValue_toDouble__SWIG_0(swigCPtr, defaultValue);
    return ret;
  }

  public double toDouble() {
    double ret = dsinfer_csharp_bindingsPINVOKE.JsonValue_toDouble__SWIG_1(swigCPtr);
    return ret;
  }

  public string toString(string defaultValue) {
    string ret = dsinfer_csharp_bindingsPINVOKE.JsonValue_toString__SWIG_0(swigCPtr, defaultValue);
    if (dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Pending) throw dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string toString() {
    string ret = dsinfer_csharp_bindingsPINVOKE.JsonValue_toString__SWIG_1(swigCPtr);
    return ret;
  }

  public ByteArray toBinary(ByteArray defaultValue) {
    ByteArray ret = new ByteArray(dsinfer_csharp_bindingsPINVOKE.JsonValue_toBinary__SWIG_0(swigCPtr, ByteArray.getCPtr(defaultValue)), true);
    if (dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Pending) throw dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ByteArray toBinary() {
    ByteArray ret = new ByteArray(dsinfer_csharp_bindingsPINVOKE.JsonValue_toBinary__SWIG_1(swigCPtr), true);
    return ret;
  }

  public JsonArray toArray(JsonArray defaultValue) {
    JsonArray ret = new JsonArray(dsinfer_csharp_bindingsPINVOKE.JsonValue_toArray__SWIG_0(swigCPtr, JsonArray.getCPtr(defaultValue)), true);
    if (dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Pending) throw dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public JsonArray toArray() {
    JsonArray ret = new JsonArray(dsinfer_csharp_bindingsPINVOKE.JsonValue_toArray__SWIG_1(swigCPtr), true);
    return ret;
  }

  public JsonObject toObject(JsonObject defaultValue) {
    JsonObject ret = new JsonObject(dsinfer_csharp_bindingsPINVOKE.JsonValue_toObject__SWIG_0(swigCPtr, JsonObject.getCPtr(defaultValue)), true);
    if (dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Pending) throw dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public JsonObject toObject() {
    JsonObject ret = new JsonObject(dsinfer_csharp_bindingsPINVOKE.JsonValue_toObject__SWIG_1(swigCPtr), true);
    return ret;
  }

  public string toJson(int indent) {
    string ret = dsinfer_csharp_bindingsPINVOKE.JsonValue_toJson__SWIG_0(swigCPtr, indent);
    return ret;
  }

  public string toJson() {
    string ret = dsinfer_csharp_bindingsPINVOKE.JsonValue_toJson__SWIG_1(swigCPtr);
    return ret;
  }

  public static JsonValue fromJson(string json, bool ignore_comments, /*cstype*/ out string error) {
    JsonValue ret = new JsonValue(dsinfer_csharp_bindingsPINVOKE.JsonValue_fromJson__SWIG_0(json, ignore_comments, out error), true);
    if (dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Pending) throw dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static JsonValue fromJson(string json, bool ignore_comments) {
    JsonValue ret = new JsonValue(dsinfer_csharp_bindingsPINVOKE.JsonValue_fromJson__SWIG_1(json, ignore_comments), true);
    if (dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Pending) throw dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ByteArray toCbor() {
    ByteArray ret = new ByteArray(dsinfer_csharp_bindingsPINVOKE.JsonValue_toCbor(swigCPtr), true);
    return ret;
  }

  public static JsonValue fromCbor(ByteArray cbor, /*cstype*/ out string error) {
    JsonValue ret = new JsonValue(dsinfer_csharp_bindingsPINVOKE.JsonValue_fromCbor__SWIG_0(ByteArray.getCPtr(cbor), out error), true);
    if (dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Pending) throw dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static JsonValue fromCbor(ByteArray cbor) {
    JsonValue ret = new JsonValue(dsinfer_csharp_bindingsPINVOKE.JsonValue_fromCbor__SWIG_1(ByteArray.getCPtr(cbor)), true);
    if (dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Pending) throw dsinfer_csharp_bindingsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public enum Type {
    Null = 0x0,
    Bool = 0x1,
    Integer = 0x2,
    Double = 0x3,
    String = 0x4,
    Binary = 0x5,
    Array = 0x11,
    Object = 0x12,
    Undefined = 0x80
  }

}

}
