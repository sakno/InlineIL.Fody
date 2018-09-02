﻿using System;
using System.Diagnostics.CodeAnalysis;
using InlineIL;

[SuppressMessage("ReSharper", "UnusedMember.Global")]
public class LibRefTestCases
{
    public void Local()
    {
        TypeRef local = null;
        DoNothing(ref local);
    }

    public void Local2()
    {
        Foo<TypeRef> local = null;
        DoNothing(ref local);
    }

    public void GenericCall()
    {
        DoNothing<TypeRef>();
    }

    public void GenericCall2()
    {
        DoNothing<Foo<TypeRef>>();
    }

    [SuppressMessage("ReSharper", "UnusedParameter.Global")]
    public void Param(TypeRef typeRef)
    {
    }

    [SuppressMessage("ReSharper", "UnusedParameter.Global")]
    public void Param2(Foo<TypeRef> typeRef)
    {
    }

    [SomeAttribute(typeof(TypeRef))]
    public void AttributeCtor()
    {
    }

    [SomeAttribute(Type = typeof(TypeRef))]
    public void AttributeParam()
    {
    }

    [SuppressMessage("ReSharper", "UnusedParameter.Global")]
    public void AttributeMethodParam([SomeAttribute(typeof(TypeRef))] int foo)
    {
    }

    [SuppressMessage("ReSharper", "UnusedTypeParameter")]
    public void GenericConstraint<T>()
        where T : Foo<TypeRef>
    {
    }

    [SuppressMessage("ReSharper", "UnusedTypeParameter")]
    public void GenericParamAttribute<[SomeAttribute(typeof(TypeRef))] T>()
    {
    }

    private static void DoNothing<T>(ref T _)
    {
    }

    [SuppressMessage("ReSharper", "UnusedTypeParameter")]
    private static void DoNothing<T>()
    {
    }

    [SuppressMessage("ReSharper", "ClassNeverInstantiated.Local")]
    [SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
    [SuppressMessage("ReSharper", "UnusedTypeParameter")]
    public class Foo<T>
    {
    }

    [SuppressMessage("ReSharper", "UnusedTypeParameter")]
    public interface IFoo<T>
    {
    }

    private class SomeAttributeAttribute : Attribute
    {
        public Type Type { get; set; }

        public SomeAttributeAttribute()
        {
        }

        public SomeAttributeAttribute(Type type)
        {
            Type = type;
        }
    }

    [SomeAttribute(typeof(TypeRef))]
    public class TypeAttr
    {
    }

    public class FieldAttr
    {
        [SomeAttribute(typeof(TypeRef))] public int Item;
    }

    public class PropAttr
    {
        [SomeAttribute(typeof(TypeRef))]
        public int Item { get; set; }
    }

    public class EventAttr
    {
#pragma warning disable 67
        [SomeAttribute(typeof(TypeRef))]
        public event Action Item;
#pragma warning restore 67
    }

    public class FieldType
    {
        public TypeRef Item;
    }

    public class PropType
    {
        public TypeRef Item { get; set; }
    }

    public class EventType
    {
#pragma warning disable 67
        public event Action<TypeRef> Item;
#pragma warning restore 67
    }

    public class BaseType : Foo<TypeRef>
    {
    }

    public class InterfaceType : IFoo<TypeRef>
    {
    }
}
