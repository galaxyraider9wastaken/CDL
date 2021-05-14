#include "Vector.h"
#include <cmath>

Vector2 Vector:: AddVec2(Vector2 V1, Vector2 V2){
  Vector2 VA = Vector2(0, 0);
  VA.X = V1.X + V2.X;
  VA.Y = V1.Y + V2.Y;
  return VA; 
}
Vector3 Vector:: AddVec3(Vector3 V1, Vector3 V2){
  Vector3 VA = Vector2(0, 0, 0);
  VA.X = V1.X + V2.X;
  VA.Y = V1.Y + V2.Y;
  VA.Z = V1.Z + V2.Z;
  return VA; 
}
Vector4 Vector:: AddVec4(Vector4 V1, Vector4 V2){
  Vector4 VA = Vector2(0, 0, 0);
  VA.X = V1.X + V2.X;
  VA.Y = V1.Y + V2.Y;
  VA.Z = V1.Z + V2.Z;
  VA.W = V1.W + V2.W;
  return VA; 
}
Vector2 Vector:: SubtractVec2(Vector2 V1, Vector2 V2){
  Vector2 VA = Vector2(0, 0);
  VA.X = V1.X - V2.X;
  VA.Y = V1.Y - V2.Y;
  return VA; 
}
Vector3 Vector:: SubtractVec3(Vector3 V1, Vector3 V2){
  Vector3 VA = Vector2(0, 0, 0);
  VA.X = V1.X - V2.X;
  VA.Y = V1.Y - V2.Y;
  VA.Z = V1.Z - V2.Z;
  return VA; 
}
Vector4 Vector:: SubtractVec4(Vector4 V1, Vector4 V2){
  Vector4 VA = Vector2(0, 0, 0, 0);
  VA.X = V1.X - V2.X;
  VA.Y = V1.Y - V2.Y;
  VA.Z = V1.Z - V2.Z;
  VA.W = V1.W - V2.W;
  return VA; 
}
Vector2 Vector:: MultiplyVec2(Vector2 V1, Vector2 V2){
  Vector2 VA = Vector2(0, 0);
  VA.X = V1.X * V2.X;
  VA.Y = V1.Y * V2.Y;
  return VA; 
}
Vector3 Vector:: MultiplyVec3(Vector3 V1, Vector3 V2){
  Vector3 VA = Vector2(0, 0, 0);
  VA.X = V1.X * V2.X;
  VA.Y = V1.Y * V2.Y;
  VA.Z = V1.Z * V2.Z;
  return VA; 
}
Vector4 Vector:: MultiplyVec4(Vector4 V1, Vector4 V2){
  Vector4 VA = Vector2(0, 0, 0);
  VA.X = V1.X * V2.X;
  VA.Y = V1.Y * V2.Y;
  VA.Z = V1.Z * V2.Z;
  VA.W = V1.W * V2.W;
  return VA; 
}
Vector2 Vector:: DivideVec2(Vector2 V1, Vector2 V2){
  Vector2 VA = Vector2(0, 0);
  VA.X = V1.X / V2.X;
  VA.Y = V1.Y / V2.Y;
  return VA; 
}
Vector3 Vector:: DivideVec3(Vector3 V1, Vector3 V2){
  Vector3 VA = Vector2(0, 0, 0);
  VA.X = V1.X / V2.X;
  VA.Y = V1.Y / V2.Y;
  VA.Z = V1.Z / V2.Z;
  return VA; 
}
Vector4 Vector:: DivideVec4(Vector4 V1, Vector4 V2){
  Vector4 VA = Vector2(0, 0, 0, 0);
  VA.X = V1.X / V2.X;
  VA.Y = V1.Y / V2.Y;
  VA.Z = V1.Z / V2.Z;
  VA.W = V1.W / V2.W;
  return VA; 
}
Vector2 Vector:: NormalizeVec2(Vector4 V1, Vector4 V2){
  Vector2 VA = Vector2(0, 0, 0, 0);
  VA.X = V1.X / V2.X;
  VA.Y = V1.Y / V2.Y;
  VA.Z = V1.Z / V2.Z;
  VA.W = V1.W / V2.W;
  return VA; 
}
