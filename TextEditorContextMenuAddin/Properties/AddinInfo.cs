using Mono.Addins;

[assembly: Addin (
	"TextEditorContextMenuAddin",
	Namespace = "MonoDevelop",
	Version = "0.1",
	Category = "IDE extensions")]

[assembly: AddinName ("TextEditorContextMenuAddin")]
[assembly: AddinDescription ("")]

[assembly: AddinDependency ("::MonoDevelop.Core", "8.0")]
[assembly: AddinDependency ("::MonoDevelop.Ide", "8.0")]
[assembly: AddinDependency ("::MonoDevelop.TextEditor", "8.0")]
