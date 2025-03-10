﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.VisualStudio.TestTools.UnitTesting
{
    using System;

    /// <summary>
    /// The test method attribute.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class TestMethodAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestMethodAttribute"/> class.
        /// </summary>
        public TestMethodAttribute()
        : this(null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestMethodAttribute"/> class.
        /// </summary>
        /// <param name="displayName">
        /// Display Name for the Test Window
        /// </param>
        public TestMethodAttribute(string displayName)
        {
            this.DisplayName = displayName;
        }

        /// <summary>
        /// Gets display Name for the Test Window
        /// </summary>
        public string DisplayName { get; private set; }

        /// <summary>
        /// Executes a test method.
        /// </summary>
        /// <param name="testMethod">The test method to execute.</param>
        /// <returns>An array of TestResult objects that represent the outcome(s) of the test.</returns>
        /// <remarks>Extensions can override this method to customize running a TestMethod.</remarks>
        public virtual TestResult[] Execute(ITestMethod testMethod)
        {
            return new TestResult[] { testMethod.Invoke(null) };
        }
    }
}
