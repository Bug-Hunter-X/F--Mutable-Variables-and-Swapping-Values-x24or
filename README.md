# F# Mutable Variables and Swapping Values

This example demonstrates a common pitfall in F#: unexpected behavior when working with mutable variables, especially when swapping values within functions.

The `bug.fs` file contains code that showcases the issue. The `bugSolution.fs` file provides corrected implementations.

The key takeaway is understanding how mutability affects value assignments, particularly when using `ref` cells to simulate pass-by-reference semantics.