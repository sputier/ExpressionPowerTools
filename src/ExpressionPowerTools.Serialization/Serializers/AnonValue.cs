﻿// Copyright (c) Jeremy Likness. All rights reserved.
// Licensed under the MIT License. See LICENSE in the repository root for license information.

using System;

namespace ExpressionPowerTools.Serialization.Serializers
{
    /// <summary>
    /// Represents the combination of a type and value.
    /// </summary>
    [Serializable]
    public class AnonValue
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnonValue"/> class.
        /// </summary>
        public AnonValue()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnonValue"/> class initalized
        /// with a type and value.
        /// </summary>
        /// <param name="type">The <see cref="Type"/> of the value.</param>
        /// <param name="value">The value.</param>
        public AnonValue(Type type, object value)
        {
            AnonValueType = ReflectionHelper.Instance.SerializeType(type);
            AnonVal = value;
        }

        /// <summary>
        /// Gets or sets the defined type that may be an interface.
        /// </summary>
        public SerializableType AnonValueType { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        public object AnonVal { get; set; }
    }
}