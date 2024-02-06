using System;

[Serializable]
public class StringReference
{
   public bool UseConstant = true;
   public float ConstantValue;
   public StringVariable Variable;

   public float Value 
   {
        get { return UseConstant ? ConstantValue : Variable.Value; }
   }
}
