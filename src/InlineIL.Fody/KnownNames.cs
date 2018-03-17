﻿namespace InlineIL.Fody
{
    internal static class KnownNames
    {
        public static class Short
        {
            public const string IlType = "IL";

            public const string EmitMethod = "Emit";
            public const string PushMethod = "Push";
            public const string UnreachableMethod = "Unreachable";
            public const string ReturnMethod = "Return";
            public const string MarkLabelMethod = "MarkLabel";
            public const string DeclareLocalMethod = "DeclareLocal";
        }

        public static class Full
        {
            public const string IlType = "InlineIL.IL";
            public const string TypeRefType = "InlineIL.TypeRef";
            public const string MethodRefType = "InlineIL.MethodRef";
            public const string FieldRefType = "InlineIL.FieldRef";
            public const string LabelRefType = "InlineIL.LabelRef";
            public const string LocalRefType = "InlineIL.LocalRef";
        }
    }
}
