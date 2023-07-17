namespace SnippetManager;

[Obsolete]
internal class AdminCheck
{
    /*static AdminCheck()
    {
        using WindowsIdentity identity = WindowsIdentity.GetCurrent();
        WindowsPrincipal principal = new(identity);

        CurrentProcess = principal.IsInRole(WindowsBuiltInRole.Administrator);
    }*/

    [Obsolete("Global snippets are no longer supported.", true)]
    public static bool CurrentProcess { get; }
}

/*  In previous versions of Snippet Manager, snippets can be viewed and written to
 *  program files (VS installation) folder into VC#.
 *  
 *  This required administrator permissions, so process always needed to ask
 *  for admin, if it's already not and pass informations for file movement
 *  as process arguments. Elevated process then moved the file and ended.
 *  
 *  This has been replaced by user's code snippets, which does not require
 *  administrator access. This class is scheduled for removal in the future.
 */