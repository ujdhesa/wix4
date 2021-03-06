// Copyright (c) .NET Foundation and contributors. All rights reserved. Licensed under the Microsoft Reciprocal License. See LICENSE.TXT file in the project root for full license information.

namespace WixToolset.VisualStudio
{
    using System;
    using System.ComponentModel;
    using Microsoft.VisualStudio.Package;

    /// <summary>
    /// Subclasses <see cref="DesignPropertyDescriptor"/> to allow for non-bolded text in the property grid.
    /// </summary>
    public class WixDesignPropertyDescriptor : DesignPropertyDescriptor
    {
        // =========================================================================================
        // Constructors
        // =========================================================================================

        /// <summary>
        /// Initializes a new instance of the <see cref="WixDesignPropertyDescriptor"/> class.
        /// </summary>
        /// <param name="propertyDescriptor">The <see cref="PropertyDescriptor"/> to wrap.</param>
        public WixDesignPropertyDescriptor(PropertyDescriptor propertyDescriptor)
            : base(propertyDescriptor)
        {
        }

        // =========================================================================================
        // Methods
        // =========================================================================================

        /// <summary>
        /// By returning false here, we're always going to show the property as non-bolded.
        /// </summary>
        /// <param name="component">The component to check.</param>
        /// <returns>Always returns false.</returns>
        public override bool ShouldSerializeValue(object component)
        {
            return false;
        }
    }
}
