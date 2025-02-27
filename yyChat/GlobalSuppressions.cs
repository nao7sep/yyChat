// This file is used by Code Analysis to maintain SuppressMessage attributes that are applied to this project.
// Project-level suppressions either have no target or are given a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

// Suppresses the warning for public types in executable assemblies (CA1515).
// This allows types to remain public in applications where they might be accessed externally or for testing purposes.
[assembly: SuppressMessage ("Maintainability", "CA1515")]

// Disables the warning regarding local variable type usage (IDE0008).
// This allows the project to define its own convention for using 'var' vs. explicit types.
[assembly: SuppressMessage ("Style", "IDE0008")]

// Disables the warning about code formatting and indentation (IDE0055).
// This allows the existing formatting preferences to remain intact.
[assembly: SuppressMessage ("Style", "IDE0055")]

// Disables the warning for ignoring return values (IDE0058).
// This allows method calls used solely for side effects without assigning or using their results.
[assembly: SuppressMessage ("Style", "IDE0058")]

// Disables the warning for removing unneeded 'this' qualifiers (IDE0100).
// This preserves explicit references to current instance members when desired.
[assembly: SuppressMessage ("Style", "IDE0100")]

// Disables the suggestion to use primary constructors in classes (IDE0290).
// This allows the use of traditional constructor syntax, which may be preferred for clarity or compatibility reasons.
[assembly: SuppressMessage ("Style", "IDE0290")]
