﻿using System;
using Microsoft.Extensions.DependencyInjection;

namespace YOYOFx.Extensions.DependencyInjection.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class ServiceDescriptorAttribute : Attribute
    {
        public ServiceDescriptorAttribute() : this(null) { }

        public ServiceDescriptorAttribute(Type serviceType) : this(serviceType, ServiceLifetime.Transient) { }

        public ServiceDescriptorAttribute(Type serviceType, ServiceLifetime lifetime)
        {
            ServiceType = serviceType;
            Lifetime = lifetime;
        }

        public Type ServiceType { get; }

        public ServiceLifetime Lifetime { get; }
    }
}