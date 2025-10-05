namespace Alchemio.Adapters

/// This is the interface/API module of the Adapters assembly.
/// Main purpose is to isolate/wrap third-party and C# code for
/// easy/functional consumption by Core and CLI.
/// Adapters can:
/// - Depend on third-party and C# code (dependencies);
/// - Depend on Contracts (shared types);
/// - Implement Contracts types for composition with Core in CLI;
/// - Use impure/imperative styles;
/// - IO is allowed as long as it is needed to help Adapters expose
///   pure-ish interface from this module to Core/CLI.
/// Any IO done for the sake of CLI/UX should be done in CLI, not here.
module Interface = 
    let hello = "Hello"

