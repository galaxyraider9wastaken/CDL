#ifndef VECTOR2_H
#define VECTOR2_H

#include "Vector2.h"
#include "Vector3.h"
#include "Vector4.h"

class Vector{
public:
  static Vector2 AddVec2(Vector2 V1, Vector2 V2);
  static Vector3 AddVec3(Vector3 V1, Vector3 V2);
  static Vector4 AddVec4(Vector4 V1, Vector4 V2);
  static Vector2 SubtractVec2(Vector2 V1, Vector2 V2);
  static Vector3 SubtractVec3(Vector3 V1, Vector3 V2);
  static Vector4 SubtractVec4(Vector4 V1, Vector4 V2);
  static Vector2 MultiplyVec2(Vector2 V1, Vector2 V2);
  static Vector3 MultiplyVec3(Vector3 V1, Vector3 V2);
  static Vector4 MultiplyVec4(Vector4 V1, Vector4 V2);
  static Vector2 DivideVec2(Vector2 V1, Vector2 V2);
  static Vector3 DivideVec3(Vector3 V1, Vector3 V2);
  static Vector4 DivideVec4(Vector4 V1, Vector4 V2);
  static Vector2 NormalizeVec2(Vector2 V1, Vector2 V2);
  static Vector3 NormalizeVec3(Vector3 V1, Vector3 V2);
  static Vector4 NormalizeVec4(Vector4 V1, Vector4 V2);
};
#endif
