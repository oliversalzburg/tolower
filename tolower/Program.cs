using System;
using System.Collections.Generic;
using System.Text;

namespace tolower {
  /// <summary>
  /// Turns intput into lower case
  /// </summary>
  static class Program {
    /// <summary>
    /// Main entry point
    /// </summary>
    /// <param name="args"></param>
    static void Main( string[] args ) {
      string joinedInput = String.Join( " ", args );
      Console.WriteLine( joinedInput.ToLowerInvariant() );
    }
  }
}
